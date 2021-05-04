using AuditEvent.Net.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditEvent.Net.Tests.Attributes
{
    [TestClass]
    public class AuditGenerationHookTests
    {
        [TestMethod]
        public void MustBeTrueWhenClassIsDecoratedWithAttribute()
        {
            AuditGenerationHook auditGenerationHook = new();
            bool result = auditGenerationHook.ShouldInterceptMethod(typeof(TestClasses.DummyWithClassAttribute), null);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MustBeTrueWhenMethodIsDecoratedWithAttribute()
        {
            AuditGenerationHook auditGenerationHook = new();

            bool result = auditGenerationHook.ShouldInterceptMethod(
                typeof(TestClasses.DummyWithMethodWithAttribute),
                typeof(TestClasses.DummyWithMethodWithAttribute).GetMethod(nameof(TestClasses.DummyWithMethodWithAttribute.Test)));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void MustBeFalseWhenNeitherMethodOrClassIsDecoratedWithAttribute()
        {
            AuditGenerationHook auditGenerationHook = new();

            bool result = auditGenerationHook.ShouldInterceptMethod(
                typeof(TestClasses.DummyWithoutAttribute),
                typeof(TestClasses.DummyWithoutAttribute).GetMethod(nameof(TestClasses.DummyWithoutAttribute.Test)));

            Assert.IsFalse(result);
        }
    }
}
