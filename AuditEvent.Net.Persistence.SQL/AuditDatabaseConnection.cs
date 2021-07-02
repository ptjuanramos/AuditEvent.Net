using AuditEvent.Net.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditEvent.Net.Persistence.SQL
{
    public class AuditDatabaseConnection : IAuditDatabaseConnection
    {
        private readonly string _connectionString;

        public AuditDatabaseConnection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("AuditEvent");
        }

        private bool IsAuditTableExists()
        {
            string cmdText = @"IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=Audits) SELECT 1 ELSE SELECT 0";

            using SqlConnection sqlConnection = new(_connectionString);
            using SqlCommand sqlCommand = new(cmdText, sqlConnection);

            sqlConnection.Open();            
            int? result = sqlCommand.ExecuteScalar() as int?;
            sqlConnection.Close();

            return result.Value == 1;
        }

        public Task<OperationResult> CreateTableIfNotExists()
        {
            if(!IsAuditTableExists())
            {
                string query =
                    $@"CREATE TABLE [Audits] (
                        Id              UNIQUEIDENTIFIER            DEFAULT NEWID(),
                        Question        NVARCHAR (MAX)              NOT NULL, 
                        Input           NVARCHAR (MAX),
                        Output          NVARCHAR (MAX),
                        CONSTRAINT      [CONSTRAINTPK_Audits]       PRIMARY KEY(Id) 
                    )";

                using SqlConnection sqlConnection = new(_connectionString);
                using SqlCommand sqlCommand = new(query, sqlConnection);

                sqlConnection.Open();
                int auditInserted = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return null; //TODO
            }

            throw new NotImplementedException();
        }

        public Task<OperationResult<Audit>> InsertAudit(Audit audit)
        {
            throw new NotImplementedException();
        }
    }
}
