﻿using AuditEvent.Net.Models;
using Castle.DynamicProxy;

namespace AuditEvent.Net.Interceptor
{
    internal class AuditEventInterceptor : IAuditEventInterceptor
    {
        private readonly IAuditEventInterceptorHandler _auditEventInterceptorHandler;

        public AuditEventInterceptor(IAuditEventInterceptorHandler auditEventInterceptorHandler)
        {
            _auditEventInterceptorHandler = auditEventInterceptorHandler;
        }

        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

            _auditEventInterceptorHandler.Handle(new InterceptionInfo
            {
                Arguments = invocation.Arguments,
                MethodInfo = invocation.Method,
                ReturnValue = invocation.ReturnValue
            });
        }
    }
}