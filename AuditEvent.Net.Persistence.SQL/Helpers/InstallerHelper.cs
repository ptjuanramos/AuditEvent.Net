using System.IO;
using System.Reflection;

namespace AuditEvent.Net.Persistence.SQL.Helpers
{
    internal static class InstallerHelper
    {
        public static string GetInstallRawScript()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var resourceName = "sql-scripts/Install.sql";

            using Stream stream = assembly.GetManifestResourceStream(resourceName);
            using StreamReader reader = new(stream);

            return reader.ReadToEnd();
        }

        public static string ReplacePlaceHolders(string rawScript, InstallerInfo installerInfo)
        {
            return rawScript.Replace("$(AuditEventSchema)", installerInfo.Schema);
        }
    }
}
