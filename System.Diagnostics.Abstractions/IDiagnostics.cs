namespace System.Diagnostics.Abstractions
{
    public interface IDiagnostics
    {
        IFileVersionInfoFactory FileVersionInfo { get; }
        IStopwatchFactory Stopwatch { get; }
        IProcessFactory Process { get; }
#if NET40
        IEventLog EventLog(string logName);
        IEventLog EventLog(string logName, string machineName);
        IEventLog EventLog(string logName, string machineName, string source);
#endif
    }
}