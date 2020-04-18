namespace System.Diagnostics.Abstractions
{
    public class Stopwatch : IStopwatch
    {
        private readonly System.Diagnostics.Stopwatch _inner;

        public Stopwatch() : this(new System.Diagnostics.Stopwatch())
        {
        }

        protected internal Stopwatch(System.Diagnostics.Stopwatch inner)
        {
            _inner = inner;
        }

        public static long Frequency => System.Diagnostics.Stopwatch.Frequency;

        public static bool IsHighResolution => System.Diagnostics.Stopwatch.IsHighResolution;

        public TimeSpan Elapsed => _inner.Elapsed;
        public long ElapsedMilliseconds => _inner.ElapsedMilliseconds;
        public long ElapsedTicks => _inner.ElapsedTicks;
        public bool IsRunning => _inner.IsRunning;

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

        public static long GetTimestamp()
        {
            return System.Diagnostics.Stopwatch.GetTimestamp();
        }

        public static Stopwatch StartNew()
        {
            var diagnosticsSw = System.Diagnostics.Stopwatch.StartNew();
            return new Stopwatch(diagnosticsSw);
        }
    }
}