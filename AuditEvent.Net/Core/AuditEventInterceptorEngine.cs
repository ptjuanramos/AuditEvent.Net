using AuditEvent.Net.Helpers;
using AuditEvent.Net.Interfaces;
using AuditEvent.Net.Serialization;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Serialization
{
    public class AuditEventInterceptorEngine
    {
        private readonly AuditEventInterceptor _auditEventInterceptor;
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

        public void Start()
        {
            //initialize interception process
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
