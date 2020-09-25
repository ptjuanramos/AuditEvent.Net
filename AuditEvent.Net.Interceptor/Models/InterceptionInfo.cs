using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AuditEvent.Net.Interceptor.Models
{
    public class InterceptionInfo
    {
        public MethodInfo MethodInfo { get; set; }
        public object[] Arguments { get; set; }
        public object ReturnValue { get; set; }
    }
}
