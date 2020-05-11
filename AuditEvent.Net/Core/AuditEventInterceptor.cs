using AuditEvent.Net.Interfaces;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Core
{
    internal class AuditEventInterceptor : IAuditEventInterceptor
    {
        
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
        }
    }
}
