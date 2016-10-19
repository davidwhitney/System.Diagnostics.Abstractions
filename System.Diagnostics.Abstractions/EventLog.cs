using System.ComponentModel;

namespace System.Diagnostics.Abstractions
{
    public class EventLog : IEventLog
    {
        private readonly Diagnostics.EventLog _inner;

        public EventLogEntryCollection Entries => _inner.Entries;
        public string LogDisplayName => _inner.LogDisplayName;
        public string Log { get { return _inner.Log; } set { _inner.Log = value; } }
        public string MachineName {  get { return _inner.MachineName; } set { _inner.MachineName = value; } }
        public long MaximumKilobytes { get { return _inner.MaximumKilobytes; } set { _inner.MaximumKilobytes = value; } }
        public OverflowAction OverflowAction => _inner.OverflowAction;
        public int MinimumRetentionDays => _inner.MinimumRetentionDays;
        public bool EnableRaisingEvents { get { return _inner.EnableRaisingEvents; } set { _inner.EnableRaisingEvents = value; } }
        public ISynchronizeInvoke SynchronizingObject { get { return _inner.SynchronizingObject; } set { _inner.SynchronizingObject = value; } }
        public string Source { get; set; }
        public event EntryWrittenEventHandler EntryWritten
        {
            add { _inner.EntryWritten += value; }
            remove { _inner.EntryWritten -= value; }
        }

        public EventLog() : this(new Diagnostics.EventLog()) { }
        public EventLog(Diagnostics.EventLog inner) { _inner = inner; }
        public EventLog(string logName) { _inner = new Diagnostics.EventLog(logName); }
        public EventLog(string logName, string machineName) { _inner = new Diagnostics.EventLog(logName, machineName); }
        public EventLog(string logName, string machineName, string source) { _inner = new Diagnostics.EventLog(logName, machineName, source); }

        public void BeginInit() => _inner.BeginInit();
        public void Clear() => _inner.Clear();
        public void Close() => _inner.Close();
        public void EndInit() => _inner.EndInit();
        public void ModifyOverflowPolicy(OverflowAction action, int retentionDays) => _inner.ModifyOverflowPolicy(action, retentionDays);
        public void RegisterDisplayName(string resourceFile, long resourceId) => _inner.RegisterDisplayName(resourceFile, resourceId);
        public void WriteEntry(string message) => _inner.WriteEntry(message);
        public void WriteEntry(string message, EventLogEntryType type) => _inner.WriteEntry(message, type);
        public void WriteEntry(string message, EventLogEntryType type, int eventID) => _inner.WriteEntry(message, type, eventID);
        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category) => _inner.WriteEntry(message, type, eventID, category);
        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData) => _inner.WriteEntry(message, type, eventID, category, rawData);
        public void WriteEvent(EventInstance instance, params object[] values) => _inner.WriteEvent(instance, values);
        public void WriteEvent(EventInstance instance, byte[] data, params object[] values) => _inner.WriteEvent(instance, data, values);

        public static implicit operator EventLog(Diagnostics.EventLog log)
        {
            return new EventLog(log);
        }

        public static implicit operator Diagnostics.EventLog(EventLog log)
        {
            return log._inner;
        }
    }
}