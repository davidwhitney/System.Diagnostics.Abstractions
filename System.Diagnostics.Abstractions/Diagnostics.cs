namespace System.Diagnostics.Abstractions
{
    public class Diagnostics : IDiagnostics
    {
        public IFileVersionInfoFactory FileVersionInfo => new FileVersionInfoFactory();
        public IStopwatchFactory Stopwatch => new StopwatchFactory();
        public IProcessFactory Process => new ProcessFactory();
#if NET40
        public IEventLog EventLog(string logName)
        {
            return new EventLog(logName);
        }

        public IEventLog EventLog(string logName, string machineName)
        {
            return new EventLog(logName, machineName);
        }

        public IEventLog EventLog(string logName, string machineName, string source)
        {
            return new EventLog(logName, machineName, source);
        }
#endif
    }
}