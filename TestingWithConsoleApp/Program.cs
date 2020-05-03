using AuditEvent.Net.Attributes.Attributes;
using AuditEvent.Net.Core;
using System;

namespace TestingWithConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AuditedClass auditedClass = new AuditedClass();
            auditedClass.AuditedMethod();
        }
    }
    
    public class AuditedClass
    {
        [Auditable]
        public virtual void AuditedMethod()
        {
            Console.WriteLine("Audited method");
        }
    }
}
