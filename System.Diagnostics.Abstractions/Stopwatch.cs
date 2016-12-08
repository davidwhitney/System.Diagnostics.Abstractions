namespace System.Diagnostics.Abstractions
{
    public class Stopwatch : IStopwatch
    {
        private readonly Diagnostics.Stopwatch _inner;

        public TimeSpan Elapsed => _inner.Elapsed;
        public long ElapsedMilliseconds => _inner.ElapsedMilliseconds;
        public long ElapsedTicks => _inner.ElapsedTicks;
        public bool IsRunning => _inner.IsRunning;

        public Stopwatch() : this(new Diagnostics.Stopwatch()) { }

        protected Stopwatch(Diagnostics.Stopwatch inner)
        {
            _inner = inner;
        }

        public void Reset()
        {
            _inner.Reset();
        }

        public void Restart()
        {
            _inner.Restart();
        }

        public void Start()
        {
            _inner.Start();
        }

        public void Stop()
        {
            _inner.Stop();
        }

        public static long GetTimestamp() { return Diagnostics.Stopwatch.GetTimestamp(); }

        public static long Frequency => Diagnostics.Stopwatch.Frequency;

        public static bool IsHighResolution => Diagnostics.Stopwatch.IsHighResolution;

        public static Stopwatch StartNew()
        {
            var diagnosticsSw = Diagnostics.Stopwatch.StartNew();
            return new Stopwatch(diagnosticsSw);
        }
    }
}
