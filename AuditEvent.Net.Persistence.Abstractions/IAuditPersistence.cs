using AuditEvent.Net.Models;

namespace AuditEvent.Net.Persistence.Abstractions
{
    public interface IAuditPersistence
    {
        public OperationResult<Audit> Persist(Audit audit);

        public OperationResult<Audit> PersistAsync(Audit audit);
    }
}
