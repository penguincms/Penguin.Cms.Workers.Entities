using Penguin.Entities;

namespace Penguin.Cms.Workers.Entities
{
    /// <summary>
    /// A class representing an instance of a worker completing its work
    /// </summary>
    public class WorkerCompletion : AuditableEntity
    {
        /// <summary>
        /// Worker completions are immutable and should not need to be audited
        /// </summary>
        public override bool AuditLogChanges => false;

        /// <summary>
        /// The name of the worker this completion is for
        /// </summary>
        public string Name { get; set; }
    }
}