namespace System.Diagnostics.Abstractions
{
    public interface IFileVersionInfo
    {
        /// <summary>Gets the comments associated with the file.</summary>
        /// <returns>
        ///     The comments associated with the file or <see langword="null" /> if the file did not contain version
        ///     information.
        /// </returns>
        string Comments { get; }

        /// <summary>Gets the name of the company that produced the file.</summary>
        /// <returns>
        ///     The name of the company that produced the file or <see langword="null" /> if the file did not contain version
        ///     information.
        /// </returns>
        string CompanyName { get; }

        /// <summary>Gets the build number of the file.</summary>
        /// <returns>
        ///     A value representing the build number of the file or <see langword="null" /> if the file did not contain
        ///     version information.
        /// </returns>
        int FileBuildPart { get; }

        /// <summary>Gets the description of the file.</summary>
        /// <returns>The description of the file or <see langword="null" /> if the file did not contain version information.</returns>
        string FileDescription { get; }

        /// <summary>Gets the major part of the version number.</summary>
        /// <returns>
        ///     A value representing the major part of the version number or 0 (zero) if the file did not contain version
        ///     information.
        /// </returns>
        int FileMajorPart { get; }

        /// <summary>Gets the minor part of the version number of the file.</summary>
        /// <returns>
        ///     A value representing the minor part of the version number of the file or 0 (zero) if the file did not contain
        ///     version information.
        /// </returns>
        int FileMinorPart { get; }

        /// <summary>
        ///     Gets the name of the file that this instance of
        ///     <see cref="T:System.Diagnostics.Abstractions.FileVersionInfo" /> describes.
        /// </summary>
        /// <returns>
        ///     The name of the file described by this instance of
        ///     <see cref="T:System.Diagnostics.Abstractions.FileVersionInfo" />.
        /// </returns>
        string FileName { get; }

        /// <summary>Gets the file private part number.</summary>
        /// <returns>
        ///     A value representing the file private part number or <see langword="null" /> if the file did not contain
        ///     version information.
        /// </returns>
        int FilePrivatePart { get; }

        /// <summary>Gets the file version number.</summary>
        /// <returns>The version number of the file or <see langword="null" /> if the file did not contain version information.</returns>
        string FileVersion { get; }

        /// <summary>Gets the internal name of the file, if one exists.</summary>
        /// <returns>
        ///     The internal name of the file. If none exists, this property will contain the original name of the file
        ///     without the extension.
        /// </returns>
        string InternalName { get; }

        /// <summary>
        ///     Gets a value that specifies whether the file contains debugging information or is compiled with debugging
        ///     features enabled.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if the file contains debugging information or is compiled with debugging features enabled;
        ///     otherwise, <see langword="false" />.
        /// </returns>
        bool IsDebug { get; }

        /// <summary>
        ///     Gets a value that specifies whether the file has been modified and is not identical to the original shipping
        ///     file of the same version number.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if the file is patched; otherwise, <see langword="false" />.
        /// </returns>
        bool IsPatched { get; }

        /// <summary>Gets a value that specifies whether the file was built using standard release procedures.</summary>
        /// <returns>
        ///     <see langword="true" /> if the file is a private build; <see langword="false" /> if the file was built using
        ///     standard release procedures or if the file did not contain version information.
        /// </returns>
        bool IsPrivateBuild { get; }

        /// <summary>
        ///     Gets a value that specifies whether the file is a development version, rather than a commercially released
        ///     product.
        /// </summary>
        /// <returns>
        ///     <see langword="true" /> if the file is prerelease; otherwise, <see langword="false" />.
        /// </returns>
        bool IsPreRelease { get; }

        /// <summary>Gets a value that specifies whether the file is a special build.</summary>
        /// <returns>
        ///     <see langword="true" /> if the file is a special build; otherwise, <see langword="false" />.
        /// </returns>
        bool IsSpecialBuild { get; }

        /// <summary>Gets the default language string for the version info block.</summary>
        /// <returns>
        ///     The description string for the Microsoft Language Identifier in the version resource or
        ///     <see langword="null" /> if the file did not contain version information.
        /// </returns>
        string Language { get; }

        /// <summary>Gets all copyright notices that apply to the specified file.</summary>
        /// <returns>The copyright notices that apply to the specified file.</returns>
        string LegalCopyright { get; }

        /// <summary>Gets the trademarks and registered trademarks that apply to the file.</summary>
        /// <returns>
        ///     The trademarks and registered trademarks that apply to the file or <see langword="null" /> if the file did not
        ///     contain version information.
        /// </returns>
        string LegalTrademarks { get; }

        /// <summary>Gets the name the file was created with.</summary>
        /// <returns>The name the file was created with or <see langword="null" /> if the file did not contain version information.</returns>
        string OriginalFilename { get; }

        /// <summary>Gets information about a private version of the file.</summary>
        /// <returns>
        ///     Information about a private version of the file or <see langword="null" /> if the file did not contain version
        ///     information.
        /// </returns>
        string PrivateBuild { get; }

        /// <summary>Gets the build number of the product this file is associated with.</summary>
        /// <returns>
        ///     A value representing the build number of the product this file is associated with or <see langword="null" />
        ///     if the file did not contain version information.
        /// </returns>
        int ProductBuildPart { get; }

        /// <summary>Gets the major part of the version number for the product this file is associated with.</summary>
        /// <returns>
        ///     A value representing the major part of the product version number or <see langword="null" /> if the file did
        ///     not contain version information.
        /// </returns>
        int ProductMajorPart { get; }

        /// <summary>Gets the minor part of the version number for the product the file is associated with.</summary>
        /// <returns>
        ///     A value representing the minor part of the product version number or <see langword="null" /> if the file did
        ///     not contain version information.
        /// </returns>
        int ProductMinorPart { get; }

        /// <summary>Gets the name of the product this file is distributed with.</summary>
        /// <returns>
        ///     The name of the product this file is distributed with or <see langword="null" /> if the file did not contain
        ///     version information.
        /// </returns>
        string ProductName { get; }

        /// <summary>Gets the private part number of the product this file is associated with.</summary>
        /// <returns>
        ///     A value representing the private part number of the product this file is associated with or
        ///     <see langword="null" /> if the file did not contain version information.
        /// </returns>
        int ProductPrivatePart { get; }

        /// <summary>Gets the version of the product this file is distributed with.</summary>
        /// <returns>
        ///     The version of the product this file is distributed with or <see langword="null" /> if the file did not
        ///     contain version information.
        /// </returns>
        string ProductVersion { get; }

        /// <summary>Gets the special build information for the file.</summary>
        /// <returns>
        ///     The special build information for the file or <see langword="null" /> if the file did not contain version
        ///     information.
        /// </returns>
        string SpecialBuild { get; }
    }
}