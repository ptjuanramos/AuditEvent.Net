using AuditEvent.Net.Core;
using Castle.DynamicProxy;
using NUnit.Framework;
using System.Text;

namespace AuditEvent.Net.Tests.Core
{
    public class MasterAuditable : IInterceptor
    {
        public static int PropertyToChange { get; set; }

        public void Intercept(IInvocation invocation)
        {
            PropertyToChange = 1;
            invocation.Proceed();
        }
    }

    public class AuditableClass : MasterAuditable
    {
        public virtual int MethodToIntercept()
        {
            //no interception the value is 0
            //with intercception the value is 1
            return PropertyToChange;
        }
    }
    public class TestableAuditableClass
    {

        protected AuditableClass Input;
        protected MasterAuditable ClassThatIntercepts;

        [SetUp]
        public void Setup()
        {
            // create your interceptor
            ClassThatIntercepts = new MasterAuditable();

            // create your proxy
            var generator = new ProxyGenerator();
            Input = generator.CreateClassProxy<AuditableClass>(ClassThatIntercepts);
        }

        [Test]
        public void MethodToIntercept_IsIntercepted_WithReturnValue1()
        {
            Assert.AreEqual(1, Input.MethodToIntercept());
        }
    }
}
