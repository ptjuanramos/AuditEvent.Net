using AuditEvent.Net.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Tests.Core
{
    [TestFixture]
    public class TestableAuditableClass
    {
        
        public void TestMethod()
        {

        }

        [Test]
        public void ProxyGenerator_Test()
        {
            AuditInterceptor auditInterceptor = new AuditInterceptor();
            auditInterceptor.Load();

            InterceptedClass interceptedClass = new InterceptedClass();
            interceptedClass.Method();
        }
    }
}
