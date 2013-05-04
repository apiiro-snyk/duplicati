﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Main.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Interface {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Interface() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Main.Strings.Interface", typeof(Interface).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad sorting of backup times detected.
        /// </summary>
        internal static string BadSortingDetectedError {
            get {
                return ResourceManager.GetString("BadSortingDetectedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad sort order on volumes detected.
        /// </summary>
        internal static string BadVolumeSortOrder {
            get {
                return ResourceManager.GetString("BadVolumeSortOrder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When using cleanup the manifests and hashes must be verified.
        /// </summary>
        internal static string CannotCleanWithoutHashesError {
            get {
                return ResourceManager.GetString("CannotCleanWithoutHashesError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hash checks cannot be disabled while performing a backup.
        /// </summary>
        internal static string CannotSkipHashChecksOnBackup {
            get {
                return ResourceManager.GetString("CannotSkipHashChecksOnBackup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to verfiy the backup chain when the option --dont-read-manifests is active.
        /// </summary>
        internal static string CannotVerifyChain {
            get {
                return ResourceManager.GetString("CannotVerifyChain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hash checks cannot be disabled while performing a verification.
        /// </summary>
        internal static string CannotVerifyWithoutHashes {
            get {
                return ResourceManager.GetString("CannotVerifyWithoutHashes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified compression module was not found: {0}. Avaliable compression modules: {1}.
        /// </summary>
        internal static string CompressionModuleNotFoundError {
            get {
                return ResourceManager.GetString("CompressionModuleNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If this error cannot be resolved, you can either create a new full backup or delete the offending manifests manually, followed by a cleanup command. The offending manifest files are:.
        /// </summary>
        internal static string DeleteManifestsSuggestion {
            get {
                return ResourceManager.GetString("DeleteManifestsSuggestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting backup at {0}.
        /// </summary>
        internal static string DeletingBackupSetMessage {
            get {
                return ResourceManager.GetString("DeletingBackupSetMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The option {0} is deprecated: {1}.
        /// </summary>
        internal static string DeprecatedOptionUsedWarning {
            get {
                return ResourceManager.GetString("DeprecatedOptionUsedWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature cache is disabled when performing verification.
        /// </summary>
        internal static string DisablingSignatureCacheForVerification {
            get {
                return ResourceManager.GetString("DisablingSignatureCacheForVerification", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The option --{0} exists more than once, please report this to the developers.
        /// </summary>
        internal static string DuplicateOptionNameWarning {
            get {
                return ResourceManager.GetString("DuplicateOptionNameWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified encryption module was not found: {0}. Avaliable encryption modules: {1}.
        /// </summary>
        internal static string EncryptionModuleNotFoundError {
            get {
                return ResourceManager.GetString("EncryptionModuleNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while running the backup, no files were uploaded: {0}.
        /// </summary>
        internal static string ErrorRunningBackup {
            get {
                return ResourceManager.GetString("ErrorRunningBackup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Additionally these files were found but are not listed in the manifest:.
        /// </summary>
        internal static string ExtraFilesMessage {
            get {
                return ResourceManager.GetString("ExtraFilesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to find control files in: {0}.
        /// </summary>
        internal static string FailedToFindControlFilesMessage {
            get {
                return ResourceManager.GetString("FailedToFindControlFilesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A hash check failed, this is an indication of a corrupt file: {0}.
        /// </summary>
        internal static string FileHashFailure {
            get {
                return ResourceManager.GetString("FileHashFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The manifest report that the file should be named {0} but it was named {1}.
        /// </summary>
        internal static string FilenameMismatchError {
            get {
                return ResourceManager.GetString("FilenameMismatchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Files are not deleted, use the --force command to actually remove files.
        /// </summary>
        internal static string FilesAreNotForceDeletedMessage {
            get {
                return ResourceManager.GetString("FilesAreNotForceDeletedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file {0} has size {1} but should have size {2}.
        /// </summary>
        internal static string FileSizeMismatchError {
            get {
                return ResourceManager.GetString("FileSizeMismatchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A full backup is made because no existing backup chains were found on the destination.
        /// </summary>
        internal static string FullBecauseBackendIsEmpty {
            get {
                return ResourceManager.GetString("FullBecauseBackendIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A full backup was forced with the --{0} flag.
        /// </summary>
        internal static string FullBecauseFlagWasSet {
            get {
                return ResourceManager.GetString("FullBecauseFlagWasSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A full backup is made because the latest full backup is from {0} and the full backup threshold is {1}.
        /// </summary>
        internal static string FullBecauseLastFullIsFrom {
            get {
                return ResourceManager.GetString("FullBecauseLastFullIsFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A full backup is made because the source folders have changed.
        /// </summary>
        internal static string FullBecauseSourceFoldersChanged {
            get {
                return ResourceManager.GetString("FullBecauseSourceFoldersChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A full backup is made because the current chain has {0} incremental backups and the full backup threshold is {1}.
        /// </summary>
        internal static string FullBecauseThereAreNIncrementals {
            get {
                return ResourceManager.GetString("FullBecauseThereAreNIncrementals", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An incremental backup is made because the latest full backup is from {0} and the full backup threshold is {1}.
        /// </summary>
        internal static string IncrementalBecauseLastFullIsFrom {
            get {
                return ResourceManager.GetString("IncrementalBecauseLastFullIsFrom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An incremental backup is made because no full backup criteria was found.
        /// </summary>
        internal static string IncrementalBecauseNoFlagsWereSet {
            get {
                return ResourceManager.GetString("IncrementalBecauseNoFlagsWereSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An incremental backup is made because the current chain has {0} incremental backups and the full backup threshold is {1}.
        /// </summary>
        internal static string IncrementalBecauseThereAreNIncrementals {
            get {
                return ResourceManager.GetString("IncrementalBecauseThereAreNIncrementals", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An internal error occured, and the operation was aborted to protect the backup sets.
        /// </summary>
        internal static string InternalDeleteCountError {
            get {
                return ResourceManager.GetString("InternalDeleteCountError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The manifest file {0} is invalid, as it specifies that there should be {1} signature volumes and {2} content volumes..
        /// </summary>
        internal static string InvalidManifestFileCount {
            get {
                return ResourceManager.GetString("InvalidManifestFileCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabling manifests is only possible on restores, and it should only be used as a last resort..
        /// </summary>
        internal static string ManifestsMustBeRead {
            get {
                return ResourceManager.GetString("ManifestsMustBeRead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not allowed to disable manifest reading when performing a backup. Disabling manifests is only possible on restores, and it should only be used as a last resort..
        /// </summary>
        internal static string ManifestsMustBeReadOnBackups {
            get {
                return ResourceManager.GetString("ManifestsMustBeReadOnBackups", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more manifests are from version 1, which requires that filenames searched are relative.
        /// </summary>
        internal static string ManifestVersionRequiresRelativeNamesWarning {
            get {
                return ResourceManager.GetString("ManifestVersionRequiresRelativeNamesWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When using the foresthash storage method, the option --{0} must be set.
        /// </summary>
        internal static string MissingDatabasepathError {
            get {
                return ResourceManager.GetString("MissingDatabasepathError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The manifest file {0} specifies that there should be {1} volume pairs, but the following pairs were not found: {2}.
        /// </summary>
        internal static string MissingFilesDetected {
            get {
                return ResourceManager.GetString("MissingFilesDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature file for a content volume was missing, date: {0}, volumenumber: {1}, content volume filename: {2}.
        /// </summary>
        internal static string MissingSignatureFile {
            get {
                return ResourceManager.GetString("MissingSignatureFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No filenames given for find-last-file.
        /// </summary>
        internal static string NoFilesGivenError {
            get {
                return ResourceManager.GetString("NoFilesGivenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No source folders specified for backup.
        /// </summary>
        internal static string NoSourceFoldersError {
            get {
                return ResourceManager.GetString("NoSourceFoldersError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not deleting backup at time: {0}, because later backups depend on it.
        /// </summary>
        internal static string NotDeletingBackupSetMessage {
            get {
                return ResourceManager.GetString("NotDeletingBackupSetMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The backup at time {0} is not removed because it is the last full backup, use --allow-full-removal to include this backup in the delete.
        /// </summary>
        internal static string NotDeletingLastFullMessage {
            get {
                return ResourceManager.GetString("NotDeletingLastFullMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of source folders in the latest backup is {0}, but the number of specified folders is now {1}. It is not allowed to change source folders for a backup..
        /// </summary>
        internal static string NumberOfSourceFoldersHasChangedError {
            get {
                return ResourceManager.GetString("NumberOfSourceFoldersHasChangedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed after uploading {0} volume(s). Error message: {1}.
        /// </summary>
        internal static string PartialUploadMessage {
            get {
                return ResourceManager.GetString("PartialUploadMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to apply content file {0}, error message: {1}.
        /// </summary>
        internal static string PatchProcessingBestEffortError {
            get {
                return ResourceManager.GetString("PatchProcessingBestEffortError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The manifest file {0} indicates that the previous manifest file should be {1} but it was {2}.
        /// </summary>
        internal static string PreviousManifestFilenameMismatchError {
            get {
                return ResourceManager.GetString("PreviousManifestFilenameMismatchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The manifest file {0} indicates that the previous manifest hash should be {1} but it was {2}.
        /// </summary>
        internal static string PreviousManifestHashMismatchError {
            get {
                return ResourceManager.GetString("PreviousManifestHashMismatchError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read the primary manifest {0}, attempting secondary, if available. Error message: {1}.
        /// </summary>
        internal static string PrimaryManifestReadErrorLogMessage {
            get {
                return ResourceManager.GetString("PrimaryManifestReadErrorLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Secondary manifest file found: {0}, attempting read..
        /// </summary>
        internal static string ReadingSecondaryManifestLogMessage {
            get {
                return ResourceManager.GetString("ReadingSecondaryManifestLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing partial file: {0}.
        /// </summary>
        internal static string RemovingPartialFilesMessage {
            get {
                return ResourceManager.GetString("RemovingPartialFilesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read the secondary manifest {0}. Error message: {1}.
        /// </summary>
        internal static string SecondaryManifestReadErrorLogMessage {
            get {
                return ResourceManager.GetString("SecondaryManifestReadErrorLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Signature cache path was not given as an argument.
        /// </summary>
        internal static string SignatureCachePathMissingError {
            get {
                return ResourceManager.GetString("SignatureCachePathMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to download signature file {0}, error message: {1}.
        /// </summary>
        internal static string SignatureDownloadBestEffortError {
            get {
                return ResourceManager.GetString("SignatureDownloadBestEffortError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The content volume {0} is not present in the manifest and is not used.
        /// </summary>
        internal static string SkippedContentVolumeLogMessage {
            get {
                return ResourceManager.GetString("SkippedContentVolumeLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature file {0} was skipped because the signature file was not found in the manifest.
        /// </summary>
        internal static string SkippedUnlistedSignatureFileWarning {
            get {
                return ResourceManager.GetString("SkippedUnlistedSignatureFileWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} is included multiple times.
        /// </summary>
        internal static string SourceDirIsIncludedMultipleTimesError {
            get {
                return ResourceManager.GetString("SourceDirIsIncludedMultipleTimesError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {1} is a subfolder of {0}. It is not allowed to specify the same folder multiple times..
        /// </summary>
        internal static string SourceDirsAreRelatedError {
            get {
                return ResourceManager.GetString("SourceDirsAreRelatedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source folder {0} does not exist, aborting backup.
        /// </summary>
        internal static string SourceFolderIsMissingError {
            get {
                return ResourceManager.GetString("SourceFolderIsMissingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} is no longer in the source folder set. It is not allowed to change source folders for a backup..
        /// </summary>
        internal static string SourceFoldersHasChangedError {
            get {
                return ResourceManager.GetString("SourceFoldersHasChangedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation {0} has started.
        /// </summary>
        internal static string StartingOperationMessage {
            get {
                return ResourceManager.GetString("StartingOperationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Building filelist ....
        /// </summary>
        internal static string StatusBuildingFilelist {
            get {
                return ResourceManager.GetString("StatusBuildingFilelist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Completed.
        /// </summary>
        internal static string StatusCompleted {
            get {
                return ResourceManager.GetString("StatusCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating volume {0}.
        /// </summary>
        internal static string StatusCreatingVolume {
            get {
                return ResourceManager.GetString("StatusCreatingVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading content, volume {0}.
        /// </summary>
        internal static string StatusDownloadingContentVolume {
            get {
                return ResourceManager.GetString("StatusDownloadingContentVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Downloading signatures, volume {0}.
        /// </summary>
        internal static string StatusDownloadingSignatureVolume {
            get {
                return ResourceManager.GetString("StatusDownloadingSignatureVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading remote filelist.
        /// </summary>
        internal static string StatusLoadingFilelist {
            get {
                return ResourceManager.GetString("StatusLoadingFilelist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patching restore with #{0}.
        /// </summary>
        internal static string StatusPatching {
            get {
                return ResourceManager.GetString("StatusPatching", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing: {0}.
        /// </summary>
        internal static string StatusProcessing {
            get {
                return ResourceManager.GetString("StatusProcessing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading incremental data ....
        /// </summary>
        internal static string StatusReadingIncrementalData {
            get {
                return ResourceManager.GetString("StatusReadingIncrementalData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading incremental data from: {0}.
        /// </summary>
        internal static string StatusReadingIncrementalFile {
            get {
                return ResourceManager.GetString("StatusReadingIncrementalFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading incremental data.
        /// </summary>
        internal static string StatusReadingIncrementals {
            get {
                return ResourceManager.GetString("StatusReadingIncrementals", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading manifest file: {0}.
        /// </summary>
        internal static string StatusReadingManifest {
            get {
                return ResourceManager.GetString("StatusReadingManifest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading signatures: {0}, vol {1}.
        /// </summary>
        internal static string StatusReadingSignatureFile {
            get {
                return ResourceManager.GetString("StatusReadingSignatureFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started.
        /// </summary>
        internal static string StatusStarted {
            get {
                return ResourceManager.GetString("StatusStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading content, volume {0}.
        /// </summary>
        internal static string StatusUploadingContentVolume {
            get {
                return ResourceManager.GetString("StatusUploadingContentVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading manifest, volume {0}.
        /// </summary>
        internal static string StatusUploadingManifestVolume {
            get {
                return ResourceManager.GetString("StatusUploadingManifestVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading signatures, volume {0}.
        /// </summary>
        internal static string StatusUploadingSignatureVolume {
            get {
                return ResourceManager.GetString("StatusUploadingSignatureVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading verification file.
        /// </summary>
        internal static string StatusUploadingVerificationVolume {
            get {
                return ResourceManager.GetString("StatusUploadingVerificationVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for upload to complete ....
        /// </summary>
        internal static string StatusWaitingForUpload {
            get {
                return ResourceManager.GetString("StatusWaitingForUpload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The backup contains {0} folders but {1} target folders were supplied.
        /// </summary>
        internal static string TooFewTargetFoldersError {
            get {
                return ResourceManager.GetString("TooFewTargetFoldersError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The backup contains {0} folder(s) but {1} target folders were supplied.
        /// </summary>
        internal static string TooManyTargetFoldersWarning {
            get {
                return ResourceManager.GetString("TooManyTargetFoldersWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected compression mode: {0}.
        /// </summary>
        internal static string UnexpectedCompressionError {
            get {
                return ResourceManager.GetString("UnexpectedCompressionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation mode {0} was not expected.
        /// </summary>
        internal static string UnexpectedOperationTypeError {
            get {
                return ResourceManager.GetString("UnexpectedOperationTypeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{1}&quot; supplied to --{0} does not parse into a valid boolean, this will be treated as if it was set to &quot;true&quot;.
        /// </summary>
        internal static string UnsupportedBooleanValue {
            get {
                return ResourceManager.GetString("UnsupportedBooleanValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The option --{0} does not support the value &quot;{1}&quot;, supported values are: {2}.
        /// </summary>
        internal static string UnsupportedEnumerationValue {
            get {
                return ResourceManager.GetString("UnsupportedEnumerationValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{1}&quot; supplied to --{0} does not represent a valid integer.
        /// </summary>
        internal static string UnsupportedIntegerValue {
            get {
                return ResourceManager.GetString("UnsupportedIntegerValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The option --{0} is not supported because the module {1} is not currently loaded.
        /// </summary>
        internal static string UnsupportedOptionDisabledModuleWarning {
            get {
                return ResourceManager.GetString("UnsupportedOptionDisabledModuleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied option --{0} is not supported and will be ignored.
        /// </summary>
        internal static string UnsupportedOptionWarning {
            get {
                return ResourceManager.GetString("UnsupportedOptionWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{1}&quot; supplied to --{0} does not represent a valid path.
        /// </summary>
        internal static string UnsupportedPathValue {
            get {
                return ResourceManager.GetString("UnsupportedPathValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{1}&quot; supplied to --{0} does not represent a valid size.
        /// </summary>
        internal static string UnsupportedSizeValue {
            get {
                return ResourceManager.GetString("UnsupportedSizeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &quot;{1}&quot; supplied to --{0} does not represent a valid time.
        /// </summary>
        internal static string UnsupportedTimeValue {
            get {
                return ResourceManager.GetString("UnsupportedTimeValue", resourceCulture);
            }
        }
    }
}
