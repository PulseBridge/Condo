using System;

namespace AM.Condo.Diagnostics
{
    /// <summary>
    /// Represents a logger that does nothing.
    /// </summary>
    public class NoOpLogger : ILogger
    {
        #region Methods
        /// <inheritdoc />
        public void LogError(Exception exception)
        {
        }

        /// <inheritdoc />
        public void LogError(string error)
        {
        }

        /// <inheritdoc />
        public void LogMessage(string message, LogLevel level)
        {
        }

        /// <inheritdoc />
        public void LogWarning(string warning)
        {
        }
        #endregion
    }
}
