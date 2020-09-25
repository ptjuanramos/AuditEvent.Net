using AuditEvent.Net.Interceptor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Interceptor.Interfaces
{
    public interface IAuditEventInterceptorHandler
    {
        void Handle(InterceptionInfo interceptionInfo);
    }
}
