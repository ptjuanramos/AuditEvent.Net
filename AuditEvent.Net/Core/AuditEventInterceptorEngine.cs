using AuditEvent.Net.Helpers;
using AuditEvent.Net.Interfaces;
using AuditEvent.Net.Serialization;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Core
{
    public class AuditEventInterceptorEngine
    {
        private readonly AuditEventInterceptor _auditEventInterceptor;
        private readonly ProxyGenerator _proxyGenerator;

        private readonly SerializationHandlerType _serializationHandlerType;

        private AuditEventInterceptorEngine(SerializationHandlerType serializationHandlerType)
        {
            _auditEventInterceptor = new AuditEventInterceptor();
            _serializationHandlerType = serializationHandlerType;
        }

        public static AuditEventInterceptorEngineBuilder Builder()
        {
            return new AuditEventInterceptorEngineBuilder();
        }

        //todo: move this to another class, this class should start the interception process only.
        public T Intercept<T>()
        {
            return (T) _proxyGenerator
                .CreateInterfaceProxyWithoutTarget(typeof(T), _auditEventInterceptor);
        }

        public class AuditEventInterceptorEngineBuilder
        {
            private SerializationHandlerType serializationHandlerType;

            public void WithSerializationHandlerType(SerializationHandlerType serializationHandlerType)
            {
                this.serializationHandlerType = serializationHandlerType;
            }

            public AuditEventInterceptorEngine Build()
            {
                return new AuditEventInterceptorEngine(serializationHandlerType);
            }
        }
    }
}
