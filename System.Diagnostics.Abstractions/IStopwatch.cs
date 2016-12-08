namespace System.Diagnostics.Abstractions
{
    public interface IStopwatch
    {
        /// <devdoc>
        ///    <para>
        ///          Gets the total elapsed time measured by the current instance.
        ///      </para>
        /// </devdoc>     
        TimeSpan Elapsed { get; }

        /// <devdoc>
        ///    <para>
        ///         Gets the total elapsed time measured by the current instance, in milliseconds.
        ///    </para>
        /// </devdoc>
        long ElapsedMilliseconds { get; }

        /// <devdoc>
        ///    <para>
        ///         Gets the total elapsed time measured by the current instance, in timer ticks.
        ///    </para>
        /// </devdoc> 
        long ElapsedTicks { get; }

        /// <devdoc>
        ///    <para>
        ///         Gets a value indicating whether the System.Diagnostics.Stopwatch timer is running.
        ///    </para>
        /// </devdoc> 
        bool IsRunning { get; }

        /// <devdoc>
        ///    <para>
        ///     Stops time interval measurement and resets the elapsed time to zero.
        ///    </para>
        /// </devdoc> 
        void Reset();

        /// <devdoc>
        ///    <para>
        ///         Stops time interval measurement, resets the elapsed time to zero, and starts
        ///         measuring elapsed time.
        ///    </para>
        /// </devdoc> 
        void Restart();

        /// <devdoc>
        ///    <para>
        ///         Starts, or resumes, measuring elapsed time for an interval.
        ///    </para>
        /// </devdoc> 
        void Start();

        /// <devdoc>
        ///    <para>
        ///          Stops measuring elapsed time for an interval.
        ///    </para>
        /// </devdoc> 
        void Stop();
    }
}
