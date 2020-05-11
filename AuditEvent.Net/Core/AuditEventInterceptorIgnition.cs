using AuditEvent.Net.Interfaces;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Core
{
    internal class AuditEventInterceptorIgnition
    {
        private readonly IAuditEventInterceptor _auditEventInterceptor;
        private readonly ProxyGenerator _proxyGenerator;

        public AuditEventInterceptorIgnition(IAuditEventInterceptor auditEventInterceptor)
        {
            _auditEventInterceptor = auditEventInterceptor;
            _proxyGenerator = new ProxyGenerator();
        }

        public T Intercept<T>()
        {
            return (T)_proxyGenerator
                .CreateInterfaceProxyWithoutTarget(typeof(T), _auditEventInterceptor);
        }
    }
}
