using System.ComponentModel;
using System.Runtime.Versioning;
using System.Security.Permissions;

namespace System.Diagnostics.Abstractions
{
    public interface IEventLog
    {
        /// <devdoc>
        ///    <para>
        ///       Gets the contents of the event log.
        ///    </para>
        /// </devdoc>
        EventLogEntryCollection Entries { get; }

        /// <devdoc>
        ///    <para>
        ///    </para>
        /// </devdoc>
        string LogDisplayName { [ResourceExposure(ResourceScope.Machine)] [ResourceConsumption(ResourceScope.Machine)] get; }

        /// <devdoc>
        ///    <para>
        ///       Gets or sets the name of the log to read from and write to.
        ///    </para>
        /// </devdoc>
        string Log { get; set; }

        /// <devdoc>
        ///    <para>
        ///       Gets or sets the name of the computer on which to read or write events.
        ///    </para>
        /// </devdoc>
        string MachineName { get; set; }

        long MaximumKilobytes { get; [ResourceExposure(ResourceScope.None)] [ResourceConsumption(ResourceScope.Machine, ResourceScope.Machine)] set; }
        OverflowAction OverflowAction { get; }
        int MinimumRetentionDays { get; }

        /// <devdoc>
        /// </devdoc>
        bool EnableRaisingEvents { get; set; }

        /// <devdoc>
        ///    <para>
        ///       Represents the object used to marshal the event handler
        ///       calls issued as a result of an <see cref='System.Diagnostics.EventLog'/>
        ///       change.
        ///    </para>
        /// </devdoc>
        ISynchronizeInvoke SynchronizingObject { [HostProtection(Synchronization = true)] get; set; }

        /// <devdoc>
        ///    <para>
        ///       Gets or
        ///       sets the application name (source name) to register and use when writing to the event log.
        ///    </para>
        /// </devdoc>
        string Source { get; set; }

        /// <devdoc>
        ///    <para>
        ///       Occurs when an entry is written to the event log.
        ///    </para>
        /// </devdoc>
        event EntryWrittenEventHandler EntryWritten;

        /// <devdoc>
        /// </devdoc>
        void BeginInit();

        /// <devdoc>
        ///    <para>
        ///       Clears
        ///       the event log by removing all entries from it.
        ///    </para>
        /// </devdoc>
        void Clear();

        /// <devdoc>
        ///    <para>
        ///       Closes the event log and releases read and write handles.
        ///    </para>
        /// </devdoc>
        void Close();

        /// <devdoc>
        /// </devdoc>
        void EndInit();

        void ModifyOverflowPolicy(OverflowAction action, int retentionDays);
        void RegisterDisplayName(string resourceFile, long resourceId);

        /// <devdoc>
        ///    <para>
        ///       Writes an information type entry with the given message text to the event log.
        ///    </para>
        /// </devdoc>
        void WriteEntry(string message);

        /// <devdoc>
        ///    <para>
        ///       Writes an entry of the specified <see cref='EventLogEntryType'/> to the event log. Valid types are
        ///    <see langword='Error'/>, <see langword='Warning'/>, <see langword='Information'/>,
        ///    <see langword='Success Audit'/>, and <see langword='Failure Audit'/>.
        ///    </para>
        /// </devdoc>
        void WriteEntry(string message, EventLogEntryType type);

        /// <devdoc>
        ///    <para>
        ///       Writes an entry of the specified <see cref='EventLogEntryType'/>
        ///       and with the
        ///       user-defined <paramref name="eventID"/>
        ///       to
        ///       the event log.
        ///    </para>
        /// </devdoc>
        void WriteEntry(string message, EventLogEntryType type, int eventID);

        /// <devdoc>
        ///    <para>
        ///       Writes an entry of the specified type with the
        ///       user-defined <paramref name="eventID"/> and <paramref name="category"/>
        ///       to the event log. The <paramref name="category"/>
        ///       can be used by the event viewer to filter events in the log.
        ///    </para>
        /// </devdoc>
        void WriteEntry(string message, EventLogEntryType type, int eventID, short category);

        /// <devdoc>
        ///    <para>
        ///       Writes an entry of the specified type with the
        ///       user-defined <paramref name="eventID"/> and <paramref name="category"/> to the event log, and appends binary data to
        ///       the message. The Event Viewer does not interpret this data; it
        ///       displays raw data only in a combined hexadecimal and text format.
        ///    </para>
        /// </devdoc>
        void WriteEntry(string message, EventLogEntryType type, int eventID, short category,
            byte[] rawData);

        void WriteEvent(EventInstance instance, params Object[] values);
        void WriteEvent(EventInstance instance, byte[] data, params Object[] values);
    }
}