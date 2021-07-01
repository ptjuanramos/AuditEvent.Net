using AuditEvent.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditEvent.Net.Persistence.SQL
{
    public class AuditDatabaseConnection : IAuditDatabaseConnection
    {
        public Task<OperationResult> CreateTableIfNotExists()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<Audit>> InsertAudit(Audit audit)
        {
            throw new NotImplementedException();
        }
    }
}
