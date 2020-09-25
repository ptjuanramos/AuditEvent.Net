using AuditEvent.Net.Interceptor.Interfaces;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Interceptor.Concrete
{
    public static class AuditEventInterceptorEngine
    {
        public static T WithInterceptor<T>(this T _, IAuditEventInterceptor auditEventInterceptor)
        {
            ProxyGenerator proxyGenerator = new ProxyGenerator(); //TODO: find a better way to cache this instance and a way to set IAuditEventInterceptor
            return (T)proxyGenerator
                .CreateInterfaceProxyWithoutTarget(typeof(T), auditEventInterceptor);
        }
    }
}
