using AspectCore.DynamicProxy;
using AuditEvent.Net.Helpers;
using System;
using System.Threading.Tasks;

namespace AuditEvent.Net.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AuditableAttribute : AbstractInterceptorAttribute
    {
        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {
            string methodName = AttributeHelper.GetFullMethodName(context.ImplementationMethod);

            await next(context);

            //SerializationHelper serializationHelper = new(context);
            //string resultJson = serializationHelper.GetReturnAsJson();

            //await RegistAudit(context, logger, resultJson, methodName);

        }
    }
}
