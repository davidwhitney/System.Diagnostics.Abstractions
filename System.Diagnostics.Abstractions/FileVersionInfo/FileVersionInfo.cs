namespace System.Diagnostics.Abstractions
{
    public class FileVersionInfo : IFileVersionInfo
    {
        private readonly System.Diagnostics.FileVersionInfo _inner;

        /// <inheritdoc />
        protected internal FileVersionInfo(System.Diagnostics.FileVersionInfo inner)
        {
            _inner = inner;
        }

        /// <inheritdoc />
        public string Comments => _inner.Comments;

        /// <inheritdoc />
        public string CompanyName => _inner.CompanyName;

        /// <inheritdoc />
        public int FileBuildPart => _inner.FileBuildPart;

        /// <inheritdoc />
        public string FileDescription => _inner.FileDescription;

        /// <inheritdoc />
        public int FileMajorPart => _inner.FileMajorPart;

        /// <inheritdoc />
        public int FileMinorPart => _inner.FileMinorPart;

        /// <inheritdoc />
        public string FileName => _inner.FileName;

        /// <inheritdoc />
        public int FilePrivatePart => _inner.FilePrivatePart;

        /// <inheritdoc />
        public string FileVersion => _inner.FileVersion;

        /// <inheritdoc />
        public string InternalName => _inner.InternalName;

        /// <inheritdoc />
        public bool IsDebug => _inner.IsDebug;

        /// <inheritdoc />
        public bool IsPatched => _inner.IsPatched;

        /// <inheritdoc />
        public bool IsPrivateBuild => _inner.IsPrivateBuild;

        /// <inheritdoc />
        public bool IsPreRelease => _inner.IsPreRelease;

        /// <inheritdoc />
        public bool IsSpecialBuild => _inner.IsSpecialBuild;

        /// <inheritdoc />
        public string Language => _inner.Language;

        /// <inheritdoc />
        public string LegalCopyright => _inner.LegalCopyright;

        /// <inheritdoc />
        public string LegalTrademarks => _inner.LegalTrademarks;

        /// <inheritdoc />
        public string OriginalFilename => _inner.OriginalFilename;

        /// <inheritdoc />
        public string PrivateBuild => _inner.PrivateBuild;

        /// <inheritdoc />
        public int ProductBuildPart => _inner.ProductBuildPart;

        /// <inheritdoc />
        public int ProductMajorPart => _inner.ProductMajorPart;

        /// <inheritdoc />
        public int ProductMinorPart => _inner.ProductMinorPart;

        /// <inheritdoc />
        public string ProductName => _inner.ProductName;

        /// <inheritdoc />
        public int ProductPrivatePart => _inner.ProductPrivatePart;

        /// <inheritdoc />
        public string ProductVersion => _inner.ProductVersion;

        /// <inheritdoc />
        public string SpecialBuild => _inner.SpecialBuild;
    }
}