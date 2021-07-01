using AuditEvent.Net.Models;
using System.Threading.Tasks;

namespace AuditEvent.Net.Persistence.SQL
{
    public interface IAuditDatabaseConnection
    {
        public Task<OperationResult> CreateTableIfNotExists();

        public Task<OperationResult<Audit>> InsertAudit(Audit audit);
    }
}