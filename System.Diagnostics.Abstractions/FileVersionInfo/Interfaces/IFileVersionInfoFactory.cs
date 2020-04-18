namespace System.Diagnostics.Abstractions
{
    public interface IFileVersionInfoFactory
    {
        /// <summary>
        ///     Returns a <see cref="T:System.Diagnostics.Abtractions.FileVersionInfo" /> representing the version information
        ///     associated with the specified file.
        /// </summary>
        /// <param name="fileName">The fully qualified path and name of the file to retrieve the version information for. </param>
        /// <returns>
        ///     A <see cref="T:System.Diagnostics.Abtractions.FileVersionInfo" /> containing information about the file. If
        ///     the file did not contain version information, the <see cref="T:System.Diagnostics.FileVersionInfo" /> contains only
        ///     the name of the file requested.
        /// </returns>
        /// <exception cref="T:System.IO.FileNotFoundException">The file specified cannot be found. </exception>
        IFileVersionInfo GetVersionInfo(string path);
    }
}