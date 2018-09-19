using System.Security;

namespace System.Diagnostics.Abstractions
{
    public interface IProcessFactory
    {
        /// <summary>
        ///     Puts a <see cref="T:System.Diagnostics.Process"></see> component in state to interact with operating system
        ///     processes that run in a special mode by enabling the native property SeDebugPrivilege on the current thread.
        /// </summary>
        void EnterDebugMode();

        /// <summary>
        ///     Gets a new <see cref="T:System.Diagnostics.Process"></see> component and associates it with the currently
        ///     active process.
        /// </summary>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Process"></see> component associated with the process resource that is
        ///     running the calling application.
        /// </returns>
        IProcess GetCurrentProcess();

        /// <summary>
        ///     Returns a new <see cref="T:System.Diagnostics.Process"></see> component, given the identifier of a process on
        ///     the local computer.
        /// </summary>
        /// <param name="processId">The system-unique identifier of a process resource.</param>
        /// <returns>
        ///     A <see cref="T:System.Diagnostics.Process"></see> component that is associated with the local process resource
        ///     identified by the <paramref name="processId">processId</paramref> parameter.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The process specified by the
        ///     <paramref name="processId">processId</paramref> parameter is not running. The identifier might be expired.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">The process was not started by this object.</exception>
        IProcess GetProcessById(int processId);

        /// <summary>
        ///     Returns a new <see cref="T:System.Diagnostics.Process"></see> component, given a process identifier and the
        ///     name of a computer on the network.
        /// </summary>
        /// <param name="processId">The system-unique identifier of a process resource.</param>
        /// <param name="machineName">The name of a computer on the network.</param>
        /// <returns>
        ///     A <see cref="T:System.Diagnostics.Process"></see> component that is associated with a remote process resource
        ///     identified by the <paramref name="processId">processId</paramref> parameter.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The process specified by the
        ///     <paramref name="processId">processId</paramref> parameter is not running. The identifier might be expired.   -or-
        ///     The <paramref name="machineName">machineName</paramref> parameter syntax is invalid. The name might have length
        ///     zero (0).
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///     The <paramref name="machineName">machineName</paramref> parameter is
        ///     null.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">The process was not started by this object.</exception>
        IProcess GetProcessById(int processId, string machineName);

        /// <summary>
        ///     Creates a new <see cref="T:System.Diagnostics.Process"></see> component for each process resource on the local
        ///     computer.
        /// </summary>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.Process"></see> that represents all the process resources
        ///     running on the local computer.
        /// </returns>
        IProcess[] GetProcesses();

        /// <summary>
        ///     Creates a new <see cref="T:System.Diagnostics.Process"></see> component for each process resource on the
        ///     specified computer.
        /// </summary>
        /// <param name="machineName">The computer from which to read the list of processes.</param>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.Process"></see> that represents all the process resources
        ///     running on the specified computer.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The <paramref name="machineName">machineName</paramref> parameter syntax
        ///     is invalid. It might have length zero (0).
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///     The <paramref name="machineName">machineName</paramref> parameter is
        ///     null.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The operating system platform does not support this operation
        ///     on remote computers.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There are problems accessing the performance counter API's used to
        ///     get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">A problem occurred accessing an underlying system API.</exception>
        IProcess[] GetProcesses(string machineName);

        /// <summary>
        ///     Creates an array of new <see cref="T:System.Diagnostics.Process"></see> components and associates them with
        ///     all the process resources on the local computer that share the specified process name.
        /// </summary>
        /// <param name="processName">The friendly name of the process.</param>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.Process"></see> that represents the process resources running
        ///     the specified application or file.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There are problems accessing the performance counter API's used to
        ///     get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP.
        /// </exception>
        IProcess[] GetProcessesByName(string processName);

        /// <summary>
        ///     Creates an array of new <see cref="T:System.Diagnostics.Process"></see> components and associates them with
        ///     all the process resources on a remote computer that share the specified process name.
        /// </summary>
        /// <param name="processName">The friendly name of the process.</param>
        /// <param name="machineName">The name of a computer on the network.</param>
        /// <returns>
        ///     An array of type <see cref="T:System.Diagnostics.Process"></see> that represents the process resources running
        ///     the specified application or file.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        ///     The <paramref name="machineName">machineName</paramref> parameter syntax
        ///     is invalid. It might have length zero (0).
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">
        ///     The <paramref name="machineName">machineName</paramref> parameter is
        ///     null.
        /// </exception>
        /// <exception cref="T:System.PlatformNotSupportedException">
        ///     The operating system platform does not support this operation
        ///     on remote computers.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        ///     There are problems accessing the performance counter API's used to
        ///     get process information. This exception is specific to Windows NT, Windows 2000, and Windows XP.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">A problem occurred accessing an underlying system API.</exception>
        IProcess[] GetProcessesByName(string processName, string machineName);

        /// <summary>
        ///     Takes a <see cref="T:System.Diagnostics.Process"></see> component out of the state that lets it interact with
        ///     operating system processes that run in a special mode.
        /// </summary>
        void LeaveDebugMode();

        /// <summary>
        ///     Starts the process resource that is specified by the parameter containing process start information (for
        ///     example, the file name of the process to start) and associates the resource with a new
        ///     <see cref="T:System.Diagnostics.Process"></see> component.
        /// </summary>
        /// <param name="startInfo">
        ///     The <see cref="T:System.Diagnostics.ProcessStartInfo"></see> that contains the information that
        ///     is used to start the process, including the file name and any command-line arguments.
        /// </param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Process"></see> that is associated with the process resource, or null if
        ///     no process resource is started. Note that a new process that’s started alongside already running instances of the
        ///     same process will be independent from the others. In addition, Start may return a non-null Process with its
        ///     <see cref="P:System.Diagnostics.Process.HasExited"></see> property already set to true. In this case, the started
        ///     process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     No file name was specified in the
        ///     <paramref name="startInfo">startInfo</paramref> parameter's
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.FileName"></see> property.   -or-   The
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> property of the
        ///     <paramref name="startInfo">startInfo</paramref> parameter is true and the
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput"></see>,
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput"></see>, or
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError"></see> property is also true.   -or-   The
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute"></see> property of the
        ///     <paramref name="startInfo">startInfo</paramref> parameter is true and the
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.UserName"></see> property is not null or empty or the
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.Password"></see> property is not null.
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="startInfo">startInfo</paramref> parameter is null.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        ///     The file specified in the
        ///     <paramref name="startInfo">startInfo</paramref> parameter's
        ///     <see cref="P:System.Diagnostics.ProcessStartInfo.FileName"></see> property could not be found.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     An error occurred when opening the associated file.   -or-
        ///     The sum of the length of the arguments and the length of the full path to the process exceeds 2080. The error
        ///     message associated with this exception can be one of the following: "The data area passed to a system call is too
        ///     small." or "Access is denied."
        /// </exception>
        IProcess Start(ProcessStartInfo startInfo);

        /// <summary>
        ///     Starts a process resource by specifying the name of a document or application file and associates the resource
        ///     with a new <see cref="T:System.Diagnostics.Process"></see> component.
        /// </summary>
        /// <param name="fileName">The name of a document or application file to run in the process.</param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Process"></see> that is associated with the process resource, or null if
        ///     no process resource is started. Note that a new process that’s started alongside already running instances of the
        ///     same process will be independent from the others. In addition, Start may return a non-null Process with its
        ///     <see cref="P:System.Diagnostics.Process.HasExited"></see> property already set to true. In this case, the started
        ///     process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when opening the associated file.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The PATH environment variable has a string containing quotes.</exception>
        IProcess Start(string fileName);

        /// <summary>
        ///     Starts a process resource by specifying the name of an application and a set of command-line arguments, and
        ///     associates the resource with a new <see cref="T:System.Diagnostics.Process"></see> component.
        /// </summary>
        /// <param name="fileName">The name of an application file to run in the process.</param>
        /// <param name="arguments">Command-line arguments to pass when starting the process.</param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Process"></see> that is associated with the process resource, or null if
        ///     no process resource is started. Note that a new process that’s started alongside already running instances of the
        ///     same process will be independent from the others. In addition, Start may return a non-null Process with its
        ///     <see cref="P:System.Diagnostics.Process.HasExited"></see> property already set to true. In this case, the started
        ///     process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">
        ///     The <paramref name="fileName">fileName</paramref> or
        ///     <paramref name="arguments">arguments</paramref> parameter is null.
        /// </exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     An error occurred when opening the associated file.   -or-
        ///     The sum of the length of the arguments and the length of the full path to the process exceeds 2080. The error
        ///     message associated with this exception can be one of the following: "The data area passed to a system call is too
        ///     small." or "Access is denied."
        /// </exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        /// <exception cref="T:System.IO.FileNotFoundException">The PATH environment variable has a string containing quotes.</exception>
        IProcess Start(string fileName, string arguments);

        /// <summary>
        ///     Starts a process resource by specifying the name of an application, a user name, a password, and a domain and
        ///     associates the resource with a new <see cref="T:System.Diagnostics.Process"></see> component.
        /// </summary>
        /// <param name="fileName">The name of an application file to run in the process.</param>
        /// <param name="userName">The user name to use when starting the process.</param>
        /// <param name="password">
        ///     A <see cref="T:System.Security.SecureString"></see> that contains the password to use when
        ///     starting the process.
        /// </param>
        /// <param name="domain">The domain to use when starting the process.</param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Process"></see> that is associated with the process resource, or null if
        ///     no process resource is started. Note that a new process that’s started alongside already running instances of the
        ///     same process will be independent from the others. In addition, Start may return a non-null Process with its
        ///     <see cref="P:System.Diagnostics.Process.HasExited"></see> property already set to true. In this case, the started
        ///     process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">No file name was specified.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">There was an error in opening the associated file.</exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        IProcess Start(string fileName, string userName, SecureString password, string domain);

        /// <summary>
        ///     Starts a process resource by specifying the name of an application, a set of command-line arguments, a user
        ///     name, a password, and a domain and associates the resource with a new
        ///     <see cref="T:System.Diagnostics.Process"></see> component.
        /// </summary>
        /// <param name="fileName">The name of an application file to run in the process.</param>
        /// <param name="arguments">Command-line arguments to pass when starting the process.</param>
        /// <param name="userName">The user name to use when starting the process.</param>
        /// <param name="password">
        ///     A <see cref="T:System.Security.SecureString"></see> that contains the password to use when
        ///     starting the process.
        /// </param>
        /// <param name="domain">The domain to use when starting the process.</param>
        /// <returns>
        ///     A new <see cref="T:System.Diagnostics.Process"></see> that is associated with the process resource, or null if
        ///     no process resource is started. Note that a new process that’s started alongside already running instances of the
        ///     same process will be independent from the others. In addition, Start may return a non-null Process with its
        ///     <see cref="P:System.Diagnostics.Process.HasExited"></see> property already set to true. In this case, the started
        ///     process may have activated an existing instance of itself and then exited.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">No file name was specified.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">
        ///     An error occurred when opening the associated file.   -or-
        ///     The sum of the length of the arguments and the length of the full path to the associated file exceeds 2080. The
        ///     error message associated with this exception can be one of the following: "The data area passed to a system call is
        ///     too small." or "Access is denied."
        /// </exception>
        /// <exception cref="T:System.ObjectDisposedException">The process object has already been disposed.</exception>
        IProcess Start(string fileName, string arguments, string userName, SecureString password, string domain);
    }
}