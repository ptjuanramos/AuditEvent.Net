using AuditEvent.Net.Core;
using System;

namespace TestingWithConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AuditInterceptor auditInterceptor = new AuditInterceptor();
            auditInterceptor.Load();

            InterceptedClass interceptedClass = new InterceptedClass();
            interceptedClass.Method();

        }
    }
}
