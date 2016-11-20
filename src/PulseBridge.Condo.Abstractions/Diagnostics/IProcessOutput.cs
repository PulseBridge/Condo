namespace PulseBridge.Condo.Diagnostics
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the properties and methods required to implement output from a process.
    /// </summary>
    public interface IProcessOutput
    {
        #region Properties
        /// <summary>
        /// Gets the standard output.
        /// </summary>
        IReadOnlyCollection<string> Output { get; }

        /// <summary>
        /// Gets the standard error.
        /// </summary>
        IReadOnlyCollection<string> Error { get; }

        /// <summary>
        /// Gets the exit code of the process.
        /// </summary>
        int ExitCode { get; }

        /// <summary>
        /// Gets a value indicating whether or not the process was successful.
        /// </summary>
        bool Success { get; }
        #endregion
    }
}