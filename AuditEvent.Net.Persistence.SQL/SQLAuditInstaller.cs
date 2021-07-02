using AuditEvent.Net.Persistence.SQL.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuditEvent.Net.Persistence.SQL
{
    public class SQLAuditInstaller : IDisposable
    {
        private readonly string _connectionString;

        public SQLAuditInstaller(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Dispose()
        {
            
        }

        public void Install()
        {
            string installerRawScript = InstallerHelper.GetInstallRawScript();
            string installerScript = InstallerHelper.ReplacePlaceHolders(installerRawScript, new());

            using SqlConnection sqlConnection = new(_connectionString);
            using SqlCommand sqlCommand = new(installerScript, sqlConnection);

            sqlConnection.Open();
            int auditInserted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
