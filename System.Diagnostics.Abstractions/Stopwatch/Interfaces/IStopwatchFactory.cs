namespace System.Diagnostics.Abstractions
{
    public interface IStopwatchFactory
    {
        /// <summary>Gets the frequency of the timer as the number of ticks per second. This field is read-only.</summary>
        /// <returns></returns>
        long Frequency { get; }

        /// <summary>Indicates whether the timer is based on a high-resolution performance counter. This field is read-only.</summary>
        /// <returns></returns>
        bool IsHighResolution { get; }

        /// <summary>Gets the current number of ticks in the timer mechanism.</summary>
        /// <returns>A long integer representing the tick counter value of the underlying timer mechanism.</returns>
        long GetTimestamp();

        /// <summary>
        ///     Initializes a new <see cref="T:System.Diagnostics.Abstractions.Stopwatch"></see> instance, sets the elapsed
        ///     time property to zero, and starts measuring elapsed time.
        /// </summary>
        /// <returns>A <see cref="T:System.Diagnostics.Abstractions.Stopwatch"></see> that has just begun measuring elapsed time.</returns>
        Stopwatch StartNew();
    }
}