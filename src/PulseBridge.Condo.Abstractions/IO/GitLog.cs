namespace PulseBridge.Condo.IO
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents a log of git commits.
    /// </summary>
    public class GitLog
    {
        #region Properties
        /// <summary>
        /// Gets or sets the git item specification from which to start the log.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the git item specification to which to end the log.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets the collection of commits contained within the log.
        /// </summary>
        public ICollection<GitCommit> Commits { get; } = new List<GitCommit>();

        /// <summary>
        /// Gets or sets the tag contained within the log.
        /// </summary>
        public ICollection<GitTag> Tags { get; } = new SortedSet<GitTag>();
        #endregion

        /// <inheritdoc />
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append(this.From ?? "<root>");
            builder.Append("..");
            builder.Append(this.To ?? "HEAD");

            return builder.ToString();
        }
    }
}
