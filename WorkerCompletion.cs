using Penguin.Auditing.Abstractions.Attributes;
using Penguin.Cms.Entities;

namespace Penguin.Cms.Workers.Entities
{
    /// <summary>
    /// A class representing an instance of a worker completing its work
    /// </summary>
    [DontAuditChanges]
    public class WorkerCompletion : Entity
    {
        /// <summary>
        /// The name of the worker this completion is for
        /// </summary>
        public string Name { get; set; }
    }
}