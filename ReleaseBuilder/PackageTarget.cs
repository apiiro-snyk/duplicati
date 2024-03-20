using System.Text.RegularExpressions;

namespace ReleaseBuilder;

/// <summary>
/// The operating systems we can build for
/// </summary>
public enum OSType
{
    /// <summary>
    /// The Windows OS
    /// </summary>
    Windows,
    /// <summary>
    /// The MacOS
    /// </summary>
    MacOS,
    /// <summary>
    /// Linux, any variant
    /// </summary>
    Linux
}

/// <summary>
/// The system architecture
/// </summary>
public enum ArchType
{
    /// <summary>
    /// An x86 64-bit architecture
    /// </summary>
    x64,
    /// <summary>
    /// An x86 32-bit architecture
    /// </summary>
    x86,
    /// <summary>
    /// The ARM-64 architecture
    /// </summary>
    Arm64,
    /// <summary>
    /// The ARM v7 architecture
    /// </summary>
    Arm7
}

/// <summary>
/// The different package types
/// </summary>
public enum PackageType
{
    /// <summary>
    /// The basic zip package
    /// </summary>
    Zip,
    /// <summary>
    /// The Windows installer format
    /// </summary>
    MSI,
    /// <summary>
    /// The debian package format
    /// </summary>
    Deb,
    /// <summary>
    /// The Redhat package manager format
    /// </summary>
    RPM,
    /// <summary>
    /// Docker build
    /// </summary>
    Docker,
    /// <summary>
    /// Apple Disk Image
    /// </summary>
    DMG,
    /// <summary>
    /// The MacOS pkg format 
    /// </summary>
    MacPkg,
    /// <summary>
    /// The synology zip format
    /// </summary>
    Synologyzip
}

/// <summary>
/// Mapping of a package target
/// </summary>
/// <param name="OS">The operating system</param>
/// <param name="Arch">The CPU architecture</param>
/// <param name="Package">The installer package</param>
public record PackageTarget(OSType OS, ArchType Arch, PackageType Package)
{
    /// <summary>
    /// Returns a string representation of the OS.
    /// </summary>
    /// <param name="os">The operating system</param>
    /// <returns>The operating system id-string</returns>
    /// <remarks>This is using .Net RID: https://learn.microsoft.com/en-us/dotnet/core/rid-catalog</remarks>
    private static string OSToString(OSType os)
        => os switch
        {
            OSType.Windows => "win",
            OSType.Linux => "linux",
            OSType.MacOS => "osx",
            _ => throw new Exception("Not supported OS")
        };

    /// <summary>
    /// Returns a string representation of the CPU architecture
    /// </summary>
    /// <param name="arch">The architecture</param>
    /// <returns>The CPU architecture id-string</returns>
    /// <remarks>This is using .Net RID: https://learn.microsoft.com/en-us/dotnet/core/rid-catalog</remarks>
    private static string ArchToString(ArchType arch)
        => arch switch
        {
            ArchType.x64 => "x64",
            ArchType.x86 => "x86",
            ArchType.Arm64 => "arm64",
            ArchType.Arm7 => "arm7",
            _ => throw new Exception("Not supported arch")
        };

    /// <summary>
    /// Returns a string representation of the package type
    /// </summary>
    /// <param name="package">The package type</param>
    /// <returns>The package type id-string</returns>
    private static string PackageToString(PackageType package)
        => package switch
        {
            PackageType.Zip => "zip",
            PackageType.MSI => "msi",
            PackageType.Deb => "deb",
            PackageType.RPM => "rpm",
            PackageType.DMG => "dmg",
            PackageType.MacPkg => "pkg",
            PackageType.Synologyzip => "syno",
            PackageType.Docker => "docker",
            _ => throw new Exception("Not supported package type")
        };


    /// <summary>
    /// Gets the RID string for the operating system
    /// </summary>
    public string OSString => OSToString(OS);

    /// <summary>
    /// Gets the RID string for the CPU architecture
    /// </summary>
    public string ArchString => ArchToString(Arch);

    /// <summary>
    /// Gets the id string for the package
    /// </summary>
    public string PackageString => PackageToString(Package);

    /// <summary>
    /// String map of operating system RIDs
    /// </summary>
    private static Dictionary<string, OSType> OSTypeParse = Enum.GetValues<OSType>().ToDictionary(OSToString, x => x, StringComparer.OrdinalIgnoreCase);
    /// <summary>
    /// String map of architecture RIDs
    /// </summary>
    private static Dictionary<string, ArchType> ArchTypeParse = Enum.GetValues<ArchType>().ToDictionary(ArchToString, x => x, StringComparer.OrdinalIgnoreCase);
    /// <summary>
    /// String map of package type ids
    /// </summary>
    private static Dictionary<string, PackageType> PackageTypeParse = Enum.GetValues<PackageType>().ToDictionary(PackageToString, x => x, StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// The RID string for .Net build commands
    /// </summary>
    public string BuildArchString => $"{OSString}-{ArchString}";

    /// <summary>
    /// The package string for the updater
    /// </summary>
    public string PackageTargetString => $"{BuildArchString}.{PackageString}";

    /// <summary>
    /// Parses a string representation of a package target
    /// </summary>
    /// <param name="id">The id to parse</param>
    /// <returns>The <see cref="PackageTarget"/> matching the string</returns>
    public static PackageTarget ParsePackageId(string id)
    {
        var re = Regex.Match(id, @"(?<os>\w+)-(?<arch>\w+)\.(?<package>\w+)");
        if (!re.Success)
            throw new Exception($"Invalid package id: {id}");

        if (!OSTypeParse.TryGetValue(re.Groups["os"].Value, out var os))
            throw new Exception($"Not supported OS type: {re.Groups["os"].Value}");
        if (!ArchTypeParse.TryGetValue(re.Groups["arch"].Value, out var arch))
            throw new Exception($"Not supported Arch type: {re.Groups["arch"].Value}");
        if (!PackageTypeParse.TryGetValue(re.Groups["package"].Value, out var package))
            throw new Exception($"Not supported Package type: {re.Groups["package"].Value}");

        return new PackageTarget(os, arch, package);
    }
}