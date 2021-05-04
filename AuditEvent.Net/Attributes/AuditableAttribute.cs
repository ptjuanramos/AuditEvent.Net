using System;

namespace AuditEvent.Net.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuditableAttribute : Attribute
    {

    }
}
