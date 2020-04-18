namespace System.Diagnostics.Abstractions
{
    public class StopwatchFactory : IStopwatchFactory
    {
        /// <inheritdoc />
        public long GetTimestamp()
        {
            return System.Diagnostics.Stopwatch.GetTimestamp();
        }

        /// <inheritdoc />
        public long Frequency => System.Diagnostics.Stopwatch.Frequency;

        /// <inheritdoc />
        public bool IsHighResolution => System.Diagnostics.Stopwatch.IsHighResolution;

        /// <inheritdoc />
        public Stopwatch StartNew()
        {
            var diagnosticsSw = System.Diagnostics.Stopwatch.StartNew();
            return new Stopwatch(diagnosticsSw);
        }
    }
}