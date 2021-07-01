using System;
using System.Linq;
using System.Reflection;

namespace AuditEvent.Net.Attributes
{
    public class AuditGenerationHook
    {
        public void MethodsInspected()
        {
        }

        public void NonProxyableMemberNotification(Type type, MemberInfo memberInfo)
        {
        }

        private static bool ClassHasAuditableAttribute(Type type)
        {
            return Attribute
                .GetCustomAttributes(type)
                .Any(a => a.GetType() == typeof(AuditableAttribute));
        }

        public bool ShouldInterceptMethod(Type type, MethodInfo methodInfo)
        {
            if (ClassHasAuditableAttribute(type))
                return true;

            return methodInfo
                .CustomAttributes
                .Any(a => a.AttributeType == typeof(AuditableAttribute));
        }
    }
}
