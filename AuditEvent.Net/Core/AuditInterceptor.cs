using Ninject;
using Ninject.Extensions.Interception;
using Ninject.Extensions.Interception.Infrastructure.Language;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace AuditEvent.Net.Core
{
    public class AuditInterceptor : NinjectModule, IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine(invocation.Request.Method.Name);
            invocation.Proceed();
        }

        public override void Load()
        {
            Bind<InterceptedClass>().ToSelf().Intercept().With<AuditInterceptor>();
        }
    }

    public interface IInterceptedClass
    {
        void Method();
    }

    public class InterceptedClass : IInterceptedClass
    {
        public void Method()
        {
            Console.WriteLine("Being intercepted"); 
        }
    }
}
