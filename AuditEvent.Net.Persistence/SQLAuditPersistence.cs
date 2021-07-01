using AuditEvent.Net.Models;
using AuditEvent.Net.Persistence.Abstractions;

namespace AuditEvent.Net.Persistence
{
    public class SQLAuditPersistence : IAuditPersistence
    {
        public SQLAuditPersistence(DbContext)
        {

        }

        OperationResult<Audit> IAuditPersistence.Persist(Audit audit)
        {
            throw new System.NotImplementedException();
        }
    }
}
