using System.ComponentModel;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics.Abstractions
{
    public interface IProcess : IDisposable
    {
        /// <summary>Gets the base priority of the associated process.</summary>
        /// <returns>
        ///     The base priority, which is computed from the <see cref="P:System.Diagnostics.Process.PriorityClass"></see> of
        ///     the associated process.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> property to false to
        ///     access this property on Windows 98 and Windows Me.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process has exited.   -or-   The process has not started, so
        ///     there is no process ID.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        int BasePriority { get; }

        /// <summary>
        ///     Gets or sets whether the <see cref="E:System.Diagnostics.Process.Exited"></see> event should be raised when
        ///     the process terminates.
        /// </summary>
        /// <returns>
        ///     true if the <see cref="E:System.Diagnostics.Process.Exited"></see> event should be raised when the associated
        ///     process is terminated (through either an exit or a call to <see cref="M:System.Diagnostics.Process.Kill"></see>);
        ///     otherwise, false. The default is false. Note that the <see cref="E:System.Diagnostics.Process.Exited"></see> event
        ///     is raised even if the value of <see cref="P:System.Diagnostics.Process.EnableRaisingEvents"></see> is false when
        ///     the process exits during or before the user performs a <see cref="P:System.Diagnostics.Process.HasExited"></see>
        ///     check.
        /// </returns>
        [Browsable(false)]
        [DefaultValue(false)]
        bool EnableRaisingEvents { get; set; }

        /// <summary>Gets the value that the associated process specified when it terminated.</summary>
        /// <returns>The code that the associated process specified when it terminated.</returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process has not exited.   -or-   The process
        ///     <see cref="P:System.Diagnostics.Process.Handle"></see> is not valid.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.ExitCode"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        int ExitCode { get; }

        /// <summary>Gets the time that the associated process exited.</summary>
        /// <returns>A <see cref="T:System.DateTime"></see> that indicates when the associated process was terminated.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.ExitTime"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        DateTime ExitTime { get; }

        /// <summary>Gets the native handle of the associated process.</summary>
        /// <returns>
        ///     The handle that the operating system assigned to the associated process when the process was started. The
        ///     system uses this handle to keep track of process attributes.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process has not been started or has exited. The
        ///     <see cref="P:System.Diagnostics.Process.Handle"></see> property cannot be read because there is no process
        ///     associated with this <see cref="T:System.Diagnostics.Process"></see> instance.   -or-   The
        ///     <see cref="T:System.Diagnostics.Process"></see> instance has been attached to a running process but you do not have
        ///     the necessary permissions to get a handle with full access rights.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.Handle"></see> property for a process that is running on a remote computer.
        ///     This property is available only for processes that are running on the local computer.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        IntPtr Handle { get; }

        /// <summary>Gets the number of handles opened by the process.</summary>
        /// <returns>The number of operating system handles the process has opened.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> property to false to
        ///     access this property on Windows 98 and Windows Me.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        int HandleCount { get; }

        /// <summary>Gets a value indicating whether the associated process has been terminated.</summary>
        /// <returns>
        ///     true if the operating system process referenced by the <see cref="T:System.Diagnostics.Process"></see>
        ///     component has terminated; otherwise, false.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">There is no process associated with the object.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">The exit code for the process could not be retrieved.</exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.HasExited"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        bool HasExited { get; }

        /// <summary>Gets the unique identifier for the associated process.</summary>
        /// <returns>
        ///     The system-generated unique identifier of the process that is referenced by this
        ///     <see cref="T:System.Diagnostics.Process"></see> instance.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process's <see cref="P:System.Diagnostics.Process.Id"></see>
        ///     property has not been set.   -or-   There is no process associated with this
        ///     <see cref="T:System.Diagnostics.Process"></see> object.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> property to false to
        ///     access this property on Windows 98 and Windows Me.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        int Id { get; }

        /// <summary>Gets the name of the computer the associated process is running on.</summary>
        /// <returns>The name of the computer that the associated process is running on.</returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There is no process associated with this
        ///     <see cref="T:System.Diagnostics.Process"></see> object.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        string MachineName { get; }

        /// <summary>Gets the main module for the associated process.</summary>
        /// <returns>The <see cref="T:System.Diagnostics.ProcessModule"></see> that was used to start the process.</returns>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.MainModule"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     A 32-bit process is trying to access the modules of a 64-bit
        ///     process.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> to false to access this
        ///     property on Windows 98 and Windows Me.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process <see cref="P:System.Diagnostics.Process.Id"></see> is
        ///     not available.   -or-   The process has exited.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        ProcessModule MainModule { get; }

        /// <summary>Gets the window handle of the main window of the associated process.</summary>
        /// <returns>The system-generated window handle of the main window of the associated process.</returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The
        ///     <see cref="P:System.Diagnostics.Process.MainWindowHandle"></see> is not defined because the process has exited.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.MainWindowHandle"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> to false to access this
        ///     property on Windows 98 and Windows Me.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        IntPtr MainWindowHandle { get; }

        /// <summary>Gets the caption of the main window of the process.</summary>
        /// <returns>The main window title of the process.</returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The
        ///     <see cref="P:System.Diagnostics.Process.MainWindowTitle"></see> property is not defined because the process has
        ///     exited.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.MainWindowTitle"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> to false to access this
        ///     property on Windows 98 and Windows Me.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        string MainWindowTitle { get; }

        /// <summary>Gets or sets the maximum allowable working set size, in bytes, for the associated process.</summary>
        /// <returns>The maximum working set size that is allowed in memory for the process, in bytes.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The maximum working set size is invalid. It must be greater than or equal
        ///     to the minimum working set size.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     Working set information cannot be retrieved from the
        ///     associated process resource.   -or-   The process identifier or process handle is zero because the process has not
        ///     been started.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.MaxWorkingSet"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process <see cref="P:System.Diagnostics.Process.Id"></see> is
        ///     not available.   -or-   The process has exited.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        IntPtr MaxWorkingSet { get; set; }

        /// <summary>Gets or sets the minimum allowable working set size, in bytes, for the associated process.</summary>
        /// <returns>The minimum working set size that is required in memory for the process, in bytes.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The minimum working set size is invalid. It must be less than or equal to
        ///     the maximum working set size.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     Working set information cannot be retrieved from the
        ///     associated process resource.   -or-   The process identifier or process handle is zero because the process has not
        ///     been started.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are trying to access the
        ///     <see cref="P:System.Diagnostics.Process.MinWorkingSet"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process <see cref="P:System.Diagnostics.Process.Id"></see> is
        ///     not available.   -or-   The process has exited.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        IntPtr MinWorkingSet { get; set; }

        /// <summary>Gets the modules that have been loaded by the associated process.</summary>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.ProcessModule"></see> that represents the modules that have
        ///     been loaded by the associated process.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.Modules"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process <see cref="P:System.Diagnostics.Process.Id"></see> is
        ///     not available.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> to false to access this
        ///     property on Windows 98 and Windows Me.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.Modules"></see> property for either the system process or the idle process.
        ///     These processes do not have modules.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        ProcessModuleCollection Modules { get; }

        /// <summary>Gets the amount of nonpaged system memory, in bytes, allocated for the associated process.</summary>
        /// <returns>
        ///     The amount of memory, in bytes, the system has allocated for the associated process that cannot be written to
        ///     the virtual memory paging file.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.NonpagedSystemMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int NonpagedSystemMemorySize { get; }

        /// <summary>Gets the amount of nonpaged system memory, in bytes, allocated for the associated process.</summary>
        /// <returns>
        ///     The amount of system memory, in bytes, allocated for the associated process that cannot be written to the
        ///     virtual memory paging file.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long NonpagedSystemMemorySize64 { get; }

        /// <summary>Gets the amount of paged memory, in bytes, allocated for the associated process.</summary>
        /// <returns>
        ///     The amount of memory, in bytes, allocated by the associated process that can be written to the virtual memory
        ///     paging file.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.PagedMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int PagedMemorySize { get; }

        /// <summary>Gets the amount of paged memory, in bytes, allocated for the associated process.</summary>
        /// <returns>The amount of memory, in bytes, allocated in the virtual memory paging file for the associated process.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long PagedMemorySize64 { get; }

        /// <summary>Gets the amount of pageable system memory, in bytes, allocated for the associated process.</summary>
        /// <returns>
        ///     The amount of memory, in bytes, the system has allocated for the associated process that can be written to the
        ///     virtual memory paging file.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.PagedSystemMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int PagedSystemMemorySize { get; }

        /// <summary>Gets the amount of pageable system memory, in bytes, allocated for the associated process.</summary>
        /// <returns>
        ///     The amount of system memory, in bytes, allocated for the associated process that can be written to the virtual
        ///     memory paging file.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long PagedSystemMemorySize64 { get; }

        /// <summary>Gets the maximum amount of memory in the virtual memory paging file, in bytes, used by the associated process.</summary>
        /// <returns>
        ///     The maximum amount of memory, in bytes, allocated by the associated process that could be written to the
        ///     virtual memory paging file.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.PeakPagedMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int PeakPagedMemorySize { get; }

        /// <summary>Gets the maximum amount of memory in the virtual memory paging file, in bytes, used by the associated process.</summary>
        /// <returns>
        ///     The maximum amount of memory, in bytes, allocated in the virtual memory paging file for the associated process
        ///     since it was started.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long PeakPagedMemorySize64 { get; }

        /// <summary>Gets the maximum amount of virtual memory, in bytes, used by the associated process.</summary>
        /// <returns>The maximum amount of virtual memory, in bytes, that the associated process has requested.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.PeakVirtualMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int PeakVirtualMemorySize { get; }

        /// <summary>Gets the maximum amount of virtual memory, in bytes, used by the associated process.</summary>
        /// <returns>The maximum amount of virtual memory, in bytes, allocated for the associated process since it was started.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long PeakVirtualMemorySize64 { get; }

        /// <summary>Gets the peak working set size for the associated process, in bytes.</summary>
        /// <returns>The maximum amount of physical memory that the associated process has required all at once, in bytes.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.PeakWorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int PeakWorkingSet { get; }

        /// <summary>Gets the maximum amount of physical memory, in bytes, used by the associated process.</summary>
        /// <returns>The maximum amount of physical memory, in bytes, allocated for the associated process since it was started.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long PeakWorkingSet64 { get; }

        /// <summary>
        ///     Gets or sets a value indicating whether the associated process priority should temporarily be boosted by the
        ///     operating system when the main window has the focus.
        /// </summary>
        /// <returns>
        ///     true if dynamic boosting of the process priority should take place for a process when it is taken out of the
        ///     wait state; otherwise, false. The default is false.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     Priority boost information could not be retrieved from the
        ///     associated process resource.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.   -or-   The process identifier or process handle is zero. (The
        ///     process has not been started.)
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.PriorityBoostEnabled"></see> property for a process that is running on a
        ///     remote computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process <see cref="P:System.Diagnostics.Process.Id"></see> is
        ///     not available.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        bool PriorityBoostEnabled { get; set; }

        /// <summary>Gets or sets the overall priority category for the associated process.</summary>
        /// <returns>
        ///     The priority category for the associated process, from which the
        ///     <see cref="P:System.Diagnostics.Process.BasePriority"></see> of the process is calculated.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     Process priority information could not be set or retrieved
        ///     from the associated process resource.   -or-   The process identifier or process handle is zero. (The process has
        ///     not been started.)
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.PriorityClass"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process <see cref="P:System.Diagnostics.Process.Id"></see> is
        ///     not available.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     You have set the
        ///     <see cref="P:System.Diagnostics.Process.PriorityClass"></see> to AboveNormal or BelowNormal when using Windows 98
        ///     or Windows Millennium Edition (Windows Me). These platforms do not support those values for the priority class.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
        ///     Priority class cannot be set because it does not
        ///     use a valid value, as defined in the <see cref="T:System.Diagnostics.ProcessPriorityClass"></see> enumeration.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        ProcessPriorityClass PriorityClass { get; set; }

        /// <summary>Gets the amount of private memory, in bytes, allocated for the associated process.</summary>
        /// <returns>The number of bytes allocated by the associated process that cannot be shared with other processes.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.PrivateMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int PrivateMemorySize { get; }

        /// <summary>Gets the amount of private memory, in bytes, allocated for the associated process.</summary>
        /// <returns>
        ///     The amount of memory, in bytes, allocated for the associated process that cannot be shared with other
        ///     processes.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long PrivateMemorySize64 { get; }

        /// <summary>Gets the privileged processor time for this process.</summary>
        /// <returns>
        ///     A <see cref="T:System.TimeSpan"></see> that indicates the amount of time that the process has spent running
        ///     code inside the operating system core.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.PrivilegedProcessorTime"></see> property for a process that is running on a
        ///     remote computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        TimeSpan PrivilegedProcessorTime { get; }

        /// <summary>Gets the name of the process.</summary>
        /// <returns>The name that the system uses to identify the process to the user.</returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process does not have an identifier, or no process is
        ///     associated with the <see cref="T:System.Diagnostics.Process"></see>.   -or-   The associated process has exited.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> to false to access this
        ///     property on Windows 98 and Windows Me.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">The process is not on this computer.</exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        string ProcessName { get; }

        /// <summary>Gets or sets the processors on which the threads in this process can be scheduled to run.</summary>
        /// <returns>
        ///     A bitmask representing the processors that the threads in the associated process can run on. The default
        ///     depends on the number of processors on the computer. The default value is 2 n -1, where n is the number of
        ///     processors.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     <see cref="P:System.Diagnostics.Process.ProcessorAffinity"></see> information could not be set or retrieved from
        ///     the associated process resource.   -or-   The process identifier or process handle is zero. (The process has not
        ///     been started.)
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.ProcessorAffinity"></see> property for a process that is running on a
        ///     remote computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process <see cref="P:System.Diagnostics.Process.Id"></see> was
        ///     not available.   -or-   The process has exited.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        IntPtr ProcessorAffinity { get; set; }

        /// <summary>Gets a value indicating whether the user interface of the process is responding.</summary>
        /// <returns>true if the user interface of the associated process is responding to the system; otherwise, false.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> to false to access this
        ///     property on Windows 98 and Windows Me.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There is no process associated with this
        ///     <see cref="T:System.Diagnostics.Process"></see> object.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.Responding"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        bool Responding { get; }

#if NETSTANDARD2_0
/// <summary>Gets the native handle to this process.</summary>
/// <returns>The native handle to this process.</returns>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        SafeProcessHandle SafeHandle { get; }
#endif

        /// <summary>Gets the Terminal Services session identifier for the associated process.</summary>
        /// <returns>The Terminal Services session identifier for the associated process.</returns>
        /// <exception cref="T:System.NullReferenceException">There is no session associated with this process.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There is no process associated with this session identifier.
        ///     -or-   The associated process is not on this machine.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The <see cref="P:System.Diagnostics.Process.SessionId"></see>
        ///     property is not supported on Windows 98.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        int SessionId { get; }

        /// <summary>Gets a stream used to read the error output of the application.</summary>
        /// <returns>
        ///     A <see cref="T:System.IO.StreamReader"></see> that can be used to read the standard error stream of the
        ///     application.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The <see cref="P:System.Diagnostics.Process.StandardError"></see>
        ///     stream has not been defined for redirection; ensure
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError"></see> is set to true and
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> is set to false.   - or -   The
        ///     <see cref="P:System.Diagnostics.Process.StandardError"></see> stream has been opened for asynchronous read
        ///     operations with <see cref="M:System.Diagnostics.Process.BeginErrorReadLine"></see>.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        StreamReader StandardError { get; }

        /// <summary>Gets a stream used to write the input of the application.</summary>
        /// <returns>
        ///     A <see cref="T:System.IO.StreamWriter"></see> that can be used to write the standard input stream of the
        ///     application.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The <see cref="P:System.Diagnostics.Process.StandardInput"></see>
        ///     stream has not been defined because <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput"></see>
        ///     is set to false.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        StreamWriter StandardInput { get; }

        /// <summary>Gets a stream used to read the textual output of the application.</summary>
        /// <returns>
        ///     A <see cref="T:System.IO.StreamReader"></see> that can be used to read the standard output stream of the
        ///     application.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The <see cref="P:System.Diagnostics.Process.StandardOutput"></see>
        ///     stream has not been defined for redirection; ensure
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput"></see> is set to true and
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> is set to false.   - or -   The
        ///     <see cref="P:System.Diagnostics.Process.StandardOutput"></see> stream has been opened for asynchronous read
        ///     operations with <see cref="M:System.Diagnostics.Process.BeginOutputReadLine"></see>.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        StreamReader StandardOutput { get; }

        /// <summary>
        ///     Gets or sets the properties to pass to the <see cref="M:System.Diagnostics.Process.Start"></see> method of the
        ///     <see cref="T:System.Diagnostics.Process"></see>.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.Diagnostics.ProcessStartInfo"></see> that represents the data with which to start the
        ///     process. These arguments include the name of the executable file or document used to start the process.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        ///     The value that specifies the
        ///     <see cref="P:System.Diagnostics.Process.StartInfo"></see> is null.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        ProcessStartInfo StartInfo { get; set; }

        /// <summary>Gets the time that the associated process was started.</summary>
        /// <returns>An object  that indicates when the process started. An exception is thrown if the process is not running.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.StartTime"></see> property for a process that is running on a remote
        ///     computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">The process has exited.   -or-   The process has not been started.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred in the call to the Windows function.</exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        DateTime StartTime { get; }

        /// <summary>
        ///     Gets or sets the object used to marshal the event handler calls that are issued as a result of a process exit
        ///     event.
        /// </summary>
        /// <returns>
        ///     The <see cref="T:System.ComponentModel.ISynchronizeInvoke"></see> used to marshal event handler calls that are
        ///     issued as a result of an <see cref="E:System.Diagnostics.Process.Exited"></see> event on the process.
        /// </returns>
        [Browsable(false)]
        [DefaultValue(null)]
        ISynchronizeInvoke SynchronizingObject { get; set; }

        /// <summary>Gets the set of threads that are running in the associated process.</summary>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.ProcessThread"></see> representing the operating system
        ///     threads currently running in the associated process.
        /// </returns>
        /// <exception cref="T:System.SystemException">
        ///     The process does not have an
        ///     <see cref="P:System.Diagnostics.Process.Id"></see>, or no process is associated with the
        ///     <see cref="T:System.Diagnostics.Process"></see> instance.   -or-   The associated process has exited.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> to false to access this
        ///     property on Windows 98 and Windows Me.
        /// </exception>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        ProcessThreadCollection Threads { get; }

        /// <summary>Gets the total processor time for this process.</summary>
        /// <returns>
        ///     A <see cref="T:System.TimeSpan"></see> that indicates the amount of time that the associated process has spent
        ///     utilizing the CPU. This value is the sum of the <see cref="P:System.Diagnostics.Process.UserProcessorTime"></see>
        ///     and the <see cref="P:System.Diagnostics.Process.PrivilegedProcessorTime"></see>.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.TotalProcessorTime"></see> property for a process that is running on a
        ///     remote computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        TimeSpan TotalProcessorTime { get; }

        /// <summary>Gets the user processor time for this process.</summary>
        /// <returns>
        ///     A <see cref="T:System.TimeSpan"></see> that indicates the amount of time that the associated process has spent
        ///     running code inside the application portion of the process (not inside the operating system core).
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to access the
        ///     <see cref="P:System.Diagnostics.Process.UserProcessorTime"></see> property for a process that is running on a
        ///     remote computer. This property is available only for processes that are running on the local computer.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        TimeSpan UserProcessorTime { get; }

        /// <summary>Gets the size of the process's virtual memory, in bytes.</summary>
        /// <returns>The amount of virtual memory, in bytes, that the associated process has requested.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.VirtualMemorySize64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int VirtualMemorySize { get; }

        /// <summary>Gets the amount of the virtual memory, in bytes, allocated for the associated process.</summary>
        /// <returns>The amount of virtual memory, in bytes, allocated for the associated process.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long VirtualMemorySize64 { get; }

        /// <summary>Gets the associated process's physical memory usage, in bytes.</summary>
        /// <returns>The total amount of physical memory the associated process is using, in bytes.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Obsolete(
            "This property has been deprecated.  Please use System.Diagnostics.Process.WorkingSet64 instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        int WorkingSet { get; }

        /// <summary>Gets the amount of physical memory, in bytes, allocated for the associated process.</summary>
        /// <returns>The amount of physical memory, in bytes, allocated for the associated process.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me), which does not support this property.
        /// </exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        long WorkingSet64 { get; }

        /// <summary>
        ///     Occurs when an application writes to its redirected
        ///     <see cref="P:System.Diagnostics.Process.StandardError"></see> stream.
        /// </summary>
        /// <returns></returns>
        [Browsable(true)]
        event DataReceivedEventHandler ErrorDataReceived;

        /// <summary>Occurs when a process exits.</summary>
        /// <returns></returns>
        [Category("Behavior")]
        event EventHandler Exited;

        /// <summary>
        ///     Occurs each time an application writes a line to its redirected
        ///     <see cref="P:System.Diagnostics.Process.StandardOutput"></see> stream.
        /// </summary>
        /// <returns></returns>
        [Browsable(true)]
        event DataReceivedEventHandler OutputDataReceived;

        /// <summary>
        ///     Begins asynchronous read operations on the redirected
        ///     <see cref="P:System.Diagnostics.Process.StandardError"></see> stream of the application.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError"></see> property is false.   - or -   An
        ///     asynchronous read operation is already in progress on the
        ///     <see cref="P:System.Diagnostics.Process.StandardError"></see> stream.   - or -   The
        ///     <see cref="P:System.Diagnostics.Process.StandardError"></see> stream has been used by a synchronous read operation.
        /// </exception>
        void BeginErrorReadLine();

        /// <summary>
        ///     Begins asynchronous read operations on the redirected
        ///     <see cref="P:System.Diagnostics.Process.StandardOutput"></see> stream of the application.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput"></see> property is false.   - or -   An
        ///     asynchronous read operation is already in progress on the
        ///     <see cref="P:System.Diagnostics.Process.StandardOutput"></see> stream.   - or -   The
        ///     <see cref="P:System.Diagnostics.Process.StandardOutput"></see> stream has been used by a synchronous read
        ///     operation.
        /// </exception>
        void BeginOutputReadLine();

        /// <summary>
        ///     Cancels the asynchronous read operation on the redirected
        ///     <see cref="P:System.Diagnostics.Process.StandardError"></see> stream of an application.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The <see cref="P:System.Diagnostics.Process.StandardError"></see>
        ///     stream is not enabled for asynchronous read operations.
        /// </exception>
        void CancelErrorRead();

        /// <summary>
        ///     Cancels the asynchronous read operation on the redirected
        ///     <see cref="P:System.Diagnostics.Process.StandardOutput"></see> stream of an application.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The <see cref="P:System.Diagnostics.Process.StandardOutput"></see>
        ///     stream is not enabled for asynchronous read operations.
        /// </exception>
        void CancelOutputRead();

        /// <summary>Frees all the resources that are associated with this component.</summary>
        void Close();

        /// <summary>Closes a process that has a user interface by sending a close message to its main window.</summary>
        /// <returns>
        ///     true if the close message was successfully sent; false if the associated process does not have a main window
        ///     or if the main window is disabled (for example if a modal dialog is being shown).
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The platform is Windows 98 or Windows Millennium Edition
        ///     (Windows Me); set the <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> property to false to
        ///     access this property on Windows 98 and Windows Me.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process has already exited.   -or-   No process is associated
        ///     with this <see cref="T:System.Diagnostics.Process"></see> object.
        /// </exception>
        bool CloseMainWindow();

        /// <summary>Immediately stops the associated process.</summary>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     The associated process could not be terminated.   -or-   The
        ///     process is terminating.   -or-   The associated process is a Win16 executable.
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        ///     You are attempting to call
        ///     <see cref="M:System.Diagnostics.Process.Kill"></see> for a process that is running on a remote computer. The method
        ///     is available only for processes running on the local computer.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process has already exited.   -or-   There is no process
        ///     associated with this <see cref="T:System.Diagnostics.Process"></see> object.
        /// </exception>
        void Kill();

        /// <summary>Discards any information about the associated process that has been cached inside the process component.</summary>
        void Refresh();

        /// <summary>
        ///     Starts (or reuses) the process resource that is specified by the
        ///     <see cref="P:System.Diagnostics.Process.StartInfo"></see> property of this
        ///     <see cref="T:System.Diagnostics.Process"></see> component and associates it with the component.
        /// </summary>
        /// <returns>
        ///     true if a process resource is started; false if no new process resource is started (for example, if an
        ///     existing process is reused).
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     No file name was specified in the
        ///     <see cref="T:System.Diagnostics.Process"></see> component's
        ///     <see cref="P:System.Diagnostics.Process.StartInfo"></see>.   -or-   The
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> member of the
        ///     <see cref="P:System.Diagnostics.Process.StartInfo"></see> property is true while
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput"></see>,
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput"></see>, or
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError"></see> is true.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">There was an error in opening the associated file.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        bool Start();

        /// <summary>Formats the process's name as a string, combined with the parent component type, if applicable.</summary>
        /// <returns>
        ///     The <see cref="P:System.Diagnostics.Process.ProcessName"></see>, combined with the base component's
        ///     <see cref="M:System.Object.ToString"></see> return value.
        /// </returns>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     <see cref="M:System.Diagnostics.Process.ToString"></see> is
        ///     not supported on Windows 98.
        /// </exception>
        string ToString();

        /// <summary>
        ///     Instructs the <see cref="T:System.Diagnostics.Process"></see> component to wait indefinitely for the
        ///     associated process to exit.
        /// </summary>
        /// <exception cref="T:System.ComponentModel.Win32Exception">The wait setting could not be accessed.</exception>
        /// <exception cref="T:System.SystemException">
        ///     No process <see cref="P:System.Diagnostics.Process.Id"></see> has been set,
        ///     and a <see cref="P:System.Diagnostics.Process.Handle"></see> from which the
        ///     <see cref="P:System.Diagnostics.Process.Id"></see> property can be determined does not exist.   -or-   There is no
        ///     process associated with this <see cref="T:System.Diagnostics.Process"></see> object.   -or-   You are attempting to
        ///     call <see cref="M:System.Diagnostics.Process.WaitForExit"></see> for a process that is running on a remote
        ///     computer. This method is available only for processes that are running on the local computer.
        /// </exception>
        void WaitForExit();

        /// <summary>
        ///     Instructs the <see cref="T:System.Diagnostics.Process"></see> component to wait the specified number of
        ///     milliseconds for the associated process to exit.
        /// </summary>
        /// <param name="milliseconds">
        ///     The amount of time, in milliseconds, to wait for the associated process to exit. The maximum
        ///     is the largest possible value of a 32-bit integer, which represents infinity to the operating system.
        /// </param>
        /// <returns>true if the associated process has exited; otherwise, false.</returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">The wait setting could not be accessed.</exception>
        /// <exception cref="T:System.SystemException">
        ///     No process <see cref="P:System.Diagnostics.Process.Id"></see> has been set,
        ///     and a <see cref="P:System.Diagnostics.Process.Handle"></see> from which the
        ///     <see cref="P:System.Diagnostics.Process.Id"></see> property can be determined does not exist.   -or-   There is no
        ///     process associated with this <see cref="T:System.Diagnostics.Process"></see> object.   -or-   You are attempting to
        ///     call <see cref="M:System.Diagnostics.Process.WaitForExit(System.Int32)"></see> for a process that is running on a
        ///     remote computer. This method is available only for processes that are running on the local computer.
        /// </exception>
        bool WaitForExit(int milliseconds);

        /// <summary>
        ///     Causes the <see cref="T:System.Diagnostics.Process"></see> component to wait indefinitely for the associated
        ///     process to enter an idle state. This overload applies only to processes with a user interface and, therefore, a
        ///     message loop.
        /// </summary>
        /// <returns>true if the associated process has reached an idle state.</returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process does not have a graphical interface.   -or-   An
        ///     unknown error occurred. The process failed to enter an idle state.   -or-   The process has already exited.   -or-
        ///     No process is associated with this <see cref="T:System.Diagnostics.Process"></see> object.
        /// </exception>
        bool WaitForInputIdle();

        /// <summary>
        ///     Causes the <see cref="T:System.Diagnostics.Process"></see> component to wait the specified number of
        ///     milliseconds for the associated process to enter an idle state. This overload applies only to processes with a user
        ///     interface and, therefore, a message loop.
        /// </summary>
        /// <param name="milliseconds">
        ///     A value of 1 to <see cref="F:System.Int32.MaxValue"></see> that specifies the amount of
        ///     time, in milliseconds, to wait for the associated process to become idle. A value of 0 specifies an immediate
        ///     return, and a value of -1 specifies an infinite wait.
        /// </param>
        /// <returns>true if the associated process has reached an idle state; otherwise, false.</returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The process does not have a graphical interface.   -or-   An
        ///     unknown error occurred. The process failed to enter an idle state.   -or-   The process has already exited.   -or-
        ///     No process is associated with this <see cref="T:System.Diagnostics.Process"></see> object.
        /// </exception>
        bool WaitForInputIdle(int milliseconds);
    }
}