using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Concrete
{
    public static class AuditEventInterceptorEngine
    {
        public static T WithInterceptor<T>(this T _, IAuditEventInterceptor auditEventInterceptor)
        {
            ProxyGenerator proxyGenerator = new (); //TODO: find a better way to cache this instance and a way to set IAuditEventInterceptor
            return (T)proxyGenerator
                .CreateInterfaceProxyWithoutTarget(typeof(T), auditEventInterceptor);
        }
    }
}
