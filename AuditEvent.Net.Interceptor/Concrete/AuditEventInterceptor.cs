using AuditEvent.Net.Interceptor.Interfaces;
using AuditEvent.Net.Interceptor.Models;
using Castle.DynamicProxy;

namespace AuditEvent.Net.Interceptor.Concrete
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
