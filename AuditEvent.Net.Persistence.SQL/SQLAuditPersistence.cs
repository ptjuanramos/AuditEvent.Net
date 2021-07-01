using AuditEvent.Net.Models;
using AuditEvent.Net.Persistence.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AuditEvent.Net.Persistence.SQL
{
    public class SQLAuditPersistence : IAuditPersistence
    {
        private readonly DbContext _dbContext;

        public SQLAuditPersistence(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public OperationResult<Audit> PersistAsync(Audit audit)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult<Audit> Persist(Audit audit)
        {
            DbSet<Audit> auditDbSet = _dbContext.Set<Audit>();
            EntityEntry<Audit> auditEntityEntry = auditDbSet.Add(audit);

            int addedEntities = _dbContext.SaveChanges();

            return new()
            {
                IsSuccess = addedEntities == 1,
                Result = auditEntityEntry.Entity
            };
        }
    }
}
