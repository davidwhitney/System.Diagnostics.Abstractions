using System.Security;

namespace System.Diagnostics.Abstractions
{
    public class ProcessFactory : IProcessFactory
    {
        /// <inheritdoc />
        public void EnterDebugMode()
        {
            Process.EnterDebugMode();
        }

        /// <inheritdoc />
        public IProcess GetCurrentProcess()
        {
            return Process.GetCurrentProcess();
        }

        /// <inheritdoc />
        public IProcess GetProcessById(int processId)
        {
            return Process.GetProcessById(processId);
        }

        /// <inheritdoc />
        public IProcess GetProcessById(int processId, string machineName)
        {
            return Process.GetProcessById(processId, machineName);
        }

        /// <inheritdoc />
        public IProcess[] GetProcesses()
        {
            return Process.GetProcesses();
        }

        /// <inheritdoc />
        public IProcess[] GetProcesses(string machineName)
        {
            return Process.GetProcesses(machineName);
        }

        /// <inheritdoc />
        public IProcess[] GetProcessesByName(string processName)
        {
            return Process.GetProcessesByName(processName);
        }

        /// <inheritdoc />
        public IProcess[] GetProcessesByName(string processName, string machineName)
        {
            return Process.GetProcessesByName(processName, machineName);
        }

        /// <inheritdoc />
        public void LeaveDebugMode()
        {
            Process.LeaveDebugMode();
        }

        /// <inheritdoc />
        public IProcess Start(ProcessStartInfo startInfo)
        {
            return Process.Start(startInfo);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName)
        {
            return Process.Start(fileName);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments)
        {
            return Process.Start(fileName, arguments);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName, string userName, SecureString password, string domain)
        {
            return Process.Start(fileName, userName, password, domain);
        }

        /// <inheritdoc />
        public IProcess Start(string fileName, string arguments, string userName, SecureString password, string domain)
        {
            return Process.Start(fileName, arguments, userName, password, domain);
        }
    }
}