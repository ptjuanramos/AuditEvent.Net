using System.Reflection;

namespace AuditEvent.Net.Helpers
{
    public static class AttributeHelper
    {
        public static string GetFullMethodName(MethodInfo methodInfo)
        {
            if (methodInfo == null)
                return string.Empty;

            string methodName = methodInfo.Name;
            string className = methodInfo.ReflectedType.Name;

            return className + "." + methodName;
        }
    }
}
