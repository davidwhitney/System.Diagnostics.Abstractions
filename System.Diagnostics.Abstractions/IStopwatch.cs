namespace System.Diagnostics.Abstractions
{
    public interface IStopwatch
    {
        //public static readonly long Frequency;
        ////
        //// Summary:
        ////     Indicates whether the timer is based on a high-resolution performance counter.
        ////     This field is read-only.
        //public static readonly bool IsHighResolution;

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

        ///// <devdoc>
        /////    <para>
        /////         Gets the current number of ticks in the timer mechanism.
        /////    </para>
        ///// </devdoc> 
        //public static long GetTimestamp();

        ///// <devdoc>
        /////    <para>
        /////         Initializes a new System.Diagnostics.Stopwatch instance, sets the elapsed time
        /////         property to zero, and starts measuring elapsed time.
        /////    </para>
        ///// </devdoc> 
        //public static Stopwatch StartNew();

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
