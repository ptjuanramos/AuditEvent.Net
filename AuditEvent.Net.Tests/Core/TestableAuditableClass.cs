using AuditEvent.Net.Core;
using Castle.DynamicProxy;
using NUnit.Framework;
using System.Text;

namespace AuditEvent.Net.Tests.Core
{
    public class MasterAuditable : IAuditable
    {
        public int PropertyToChange { get; set; }

        public override void Intercept(IInvocation invocation)
        {
            PropertyToChange = 1;
            base.Intercept(invocation);
        }
    }

    public class AuditableClass : MasterAuditable
    {
        public virtual int MethodToIntercept()
        {
            //no interception the value is 0
            //with intercception the value is 1
            return base.PropertyToChange;
        }
    }
    public class TestableAuditableClass
    {

        protected AuditableClass Input;
        protected Auditable ClassThatIntercepts;

        [SetUp]
        public void Setup()
        {
            // create your interceptor
            ClassThatIntercepts = new Auditable();

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
