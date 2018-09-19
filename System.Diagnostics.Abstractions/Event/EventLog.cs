#if NET40
using System.ComponentModel;

namespace System.Diagnostics.Abstractions
{
    public class EventLog : IEventLog
    {
        private readonly System.Diagnostics.EventLog _inner;

        /// <inheritdoc />
        protected internal EventLog() : this(new System.Diagnostics.EventLog())
        {
        }

        /// <inheritdoc />
        protected internal EventLog(System.Diagnostics.EventLog inner)
        {
            _inner = inner;
        }

        /// <inheritdoc />
        public EventLog(string logName)
        {
            _inner = new System.Diagnostics.EventLog(logName);
        }

        /// <inheritdoc />
        public EventLog(string logName, string machineName)
        {
            _inner = new System.Diagnostics.EventLog(logName, machineName);
        }

        /// <inheritdoc />
        public EventLog(string logName, string machineName, string source)
        {
            _inner = new System.Diagnostics.EventLog(logName, machineName, source);
        }

        /// <inheritdoc />
        public EventLogEntryCollection Entries => _inner.Entries;

        /// <inheritdoc />
        public string LogDisplayName => _inner.LogDisplayName;

        /// <inheritdoc />
        public string Log
        {
            get => _inner.Log;
            set => _inner.Log = value;
        }

        /// <inheritdoc />
        public string MachineName
        {
            get => _inner.MachineName;
            set => _inner.MachineName = value;
        }

        /// <inheritdoc />
        public long MaximumKilobytes
        {
            get => _inner.MaximumKilobytes;
            set => _inner.MaximumKilobytes = value;
        }

        /// <inheritdoc />
        public OverflowAction OverflowAction => _inner.OverflowAction;

        /// <inheritdoc />
        public int MinimumRetentionDays => _inner.MinimumRetentionDays;

        /// <inheritdoc />
        public bool EnableRaisingEvents
        {
            get => _inner.EnableRaisingEvents;
            set => _inner.EnableRaisingEvents = value;
        }

        /// <inheritdoc />
        public ISynchronizeInvoke SynchronizingObject
        {
            get => _inner.SynchronizingObject;
            set => _inner.SynchronizingObject = value;
        }

        /// <inheritdoc />
        public string Source { get; set; }

        /// <inheritdoc />
        public event EntryWrittenEventHandler EntryWritten
        {
            add => _inner.EntryWritten += value;
            remove => _inner.EntryWritten -= value;
        }

        /// <inheritdoc />
        public void BeginInit()
        {
            _inner.BeginInit();
        }

        /// <inheritdoc />
        public void Clear()
        {
            _inner.Clear();
        }

        /// <inheritdoc />
        public void Close()
        {
            _inner.Close();
        }

        /// <inheritdoc />
        public void EndInit()
        {
            _inner.EndInit();
        }

        /// <inheritdoc />
        public void ModifyOverflowPolicy(OverflowAction action, int retentionDays)
        {
            _inner.ModifyOverflowPolicy(action, retentionDays);
        }

        /// <inheritdoc />
        public void RegisterDisplayName(string resourceFile, long resourceId)
        {
            _inner.RegisterDisplayName(resourceFile, resourceId);
        }

        /// <inheritdoc />
        public void WriteEntry(string message)
        {
            _inner.WriteEntry(message);
        }

        /// <inheritdoc />
        public void WriteEntry(string message, EventLogEntryType type)
        {
            _inner.WriteEntry(message, type);
        }

        /// <inheritdoc />
        public void WriteEntry(string message, EventLogEntryType type, int eventID)
        {
            _inner.WriteEntry(message, type, eventID);
        }

        /// <inheritdoc />
        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category)
        {
            _inner.WriteEntry(message, type, eventID, category);
        }

        /// <inheritdoc />
        public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
        {
            _inner.WriteEntry(message, type, eventID, category, rawData);
        }

        /// <inheritdoc />
        public void WriteEvent(EventInstance instance, params object[] values)
        {
            _inner.WriteEvent(instance, values);
        }

        /// <inheritdoc />
        public void WriteEvent(EventInstance instance, byte[] data, params object[] values)
        {
            _inner.WriteEvent(instance, data, values);
        }

        public static implicit operator EventLog(System.Diagnostics.EventLog log)
        {
            return new EventLog(log);
        }

        public static implicit operator System.Diagnostics.EventLog(EventLog log)
        {
            return log._inner;
        }
    }
}
#endif