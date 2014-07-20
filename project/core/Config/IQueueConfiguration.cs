using System.Collections.Generic;

namespace ThoughtWorks.CruiseControl.Core.Config
{
    /// <summary>
    /// Defines the configuration settings for a queue.
    /// </summary>
    public interface IQueueConfiguration
    {
        /// <summary>
        /// The name of the queue.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Defines how duplicates should be handled.
        /// </summary>
        QueueDuplicateHandlingMode HandlingMode { get; set; }

        /// <summary>
        /// A list of the names of any other queues which should be locked when a project in this queue is building.
        /// </summary>
        string LockQueueNames { get; set; }
		
		/// <summary>
        /// The maximum size of the the queue
        /// </summary>
        int MaxSize { get; set; }

		/// <summary>
        /// URL to hit prior to enqueuing a project
        /// </summary>
		string PreEnQueueValidationUrl { get; set; }
		
        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        /// <value>The projects in this queue.</value>
        List<Project> Projects { get; set; }
    }
}
