// Copyright (C) 2024, The Duplicati Team
// https://duplicati.com, hello@duplicati.com
// 
// Permission is hereby granted, free of charge, to any person obtaining a 
// copy of this software and associated documentation files (the "Software"), 
// to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, 
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in 
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS 
// OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using Duplicati.Library.Common;
using Duplicati.Library.Common.IO;
using Duplicati.Library.Interface;
using Duplicati.Library.Main;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;

namespace Duplicati.UnitTest
{
    public class RestoreHandlerTests : BasicSetupHelper
    {
        [Test]
        [Category("RestoreHandler")]
        public void RestoreEmptyFile()
        {
            string folderPath = Path.Combine(this.DATAFOLDER, "folder");
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "empty_file");
            File.WriteAllBytes(filePath, new byte[] { });

            Dictionary<string, string> options = new Dictionary<string, string>(this.TestOptions);
            using (Controller c = new Controller("file://" + this.TARGETFOLDER, options, null))
            {
                IBackupResults backupResults = c.Backup(new[] {this.DATAFOLDER});
                Assert.AreEqual(0, backupResults.Errors.Count());
                Assert.AreEqual(0, backupResults.Warnings.Count());
            }

            // Issue #4148 described a situation where the folders containing the empty file were not recreated properly.
            Dictionary<string, string> restoreOptions = new Dictionary<string, string>(this.TestOptions)
            {
                ["restore-path"] = this.RESTOREFOLDER,
                ["dont-compress-restore-paths"] = "true"
            };
            using (Controller c = new Controller("file://" + this.TARGETFOLDER, restoreOptions, null))
            {
                IRestoreResults restoreResults = c.Restore(new[] {filePath});
                Assert.AreEqual(0, restoreResults.Errors.Count());
                Assert.AreEqual(0, restoreResults.Warnings.Count());
            }

            // We need to strip the root part of the path.  Otherwise, Path.Combine will simply return the second argument
            // if it's determined to be an absolute path.
            string rootString = SystemIO.IO_OS.GetPathRoot(filePath);
            string newPathPart = filePath.Substring(rootString.Length);
            if (Platform.IsClientWindows)
            {
                // On Windows, the drive letter is included in the path when the dont-compress-restore-paths option is used.
                // The drive letter is assumed to be the first character of the path root (e.g., C:\).
                newPathPart = Path.Combine(rootString.Substring(0, 1), filePath.Substring(rootString.Length));
            }

            string restoredFilePath = Path.Combine(restoreOptions["restore-path"], newPathPart);
            Assert.IsTrue(File.Exists(restoredFilePath));
        }

        [Test]
        [Category("RestoreHandler")]
        public void RestoreInheritanceBreaks()
        {
            if (!Platform.IsClientWindows)
            {
                return;
            }

            string folderPath = Path.Combine(this.DATAFOLDER, "folder");
            Directory.CreateDirectory(folderPath);
            string filePath = Path.Combine(folderPath, "file");
            File.WriteAllBytes(filePath, new byte[] {0});

            // Protect access rules on the file.
            FileSecurity fileSecurity = File.GetAccessControl(filePath);
            fileSecurity.SetAccessRuleProtection(true, true);
            File.SetAccessControl(filePath, fileSecurity);

            Dictionary<string, string> options = new Dictionary<string, string>(this.TestOptions);
            using (Controller c = new Controller("file://" + this.TARGETFOLDER, options, null))
            {
                IBackupResults backupResults = c.Backup(new[] {this.DATAFOLDER});
                Assert.AreEqual(0, backupResults.Errors.Count());
                Assert.AreEqual(0, backupResults.Warnings.Count());
            }

            // First, restore without restoring permissions.
            Dictionary<string, string> restoreOptions = new Dictionary<string, string>(this.TestOptions) {["restore-path"] = this.RESTOREFOLDER};
            using (Controller c = new Controller("file://" + this.TARGETFOLDER, restoreOptions, null))
            {
                IRestoreResults restoreResults = c.Restore(new[] {filePath});
                Assert.AreEqual(0, restoreResults.Errors.Count());
                Assert.AreEqual(0, restoreResults.Warnings.Count());

                string restoredFilePath = Path.Combine(this.RESTOREFOLDER, "file");
                Assert.IsTrue(File.Exists(restoredFilePath));

                FileSecurity restoredFileSecurity = File.GetAccessControl(restoredFilePath);
                Assert.IsFalse(restoredFileSecurity.AreAccessRulesProtected);

                // Remove the restored file so that the later restore avoids the "Restore completed
                // without errors but no files were restored" warning.
                File.Delete(restoredFilePath);
            }

            // Restore with restoring permissions.
            restoreOptions["overwrite"] = "true";
            restoreOptions["restore-permissions"] = "true";
            using (Controller c = new Controller("file://" + this.TARGETFOLDER, restoreOptions, null))
            {
                IRestoreResults restoreResults = c.Restore(new[] {filePath});
                Assert.AreEqual(0, restoreResults.Errors.Count());
                Assert.AreEqual(0, restoreResults.Warnings.Count());

                string restoredFilePath = Path.Combine(this.RESTOREFOLDER, "file");
                Assert.IsTrue(File.Exists(restoredFilePath));

                FileSecurity restoredFileSecurity = File.GetAccessControl(restoredFilePath);
                Assert.IsTrue(restoredFileSecurity.AreAccessRulesProtected);
            }
        }
    }
}