using AuditEvent.Net.Models;
using AuditEvent.Net.Persistence.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AuditEvent.Net.Persistence.SQL
{
    public class SQLAuditPersistence : IAuditPersistence
    {

        public OperationResult<Audit> PersistAsync(Audit audit)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<Audit> Persist(Audit audit)
        {
            throw new System.NotImplementedException();
        }
    }
}
