using AuditEvent.Net.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net
{
    public interface IAuditEventInterceptorHandler
    {
        void Handle(InterceptionInfo interceptionInfo);
    }
}
