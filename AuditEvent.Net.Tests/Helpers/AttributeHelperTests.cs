using AuditEvent.Net.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Reflection;

namespace AuditEvent.Net.Tests.Helpers
{
    [TestClass]
    public class AttributeHelperTests
    {
        [TestMethod]
        public void GetFullMethodNameShouldReturnEmptyMethodNameIfMethodInfoIsNull()
        {
            string methodName = AttributeHelper.GetFullMethodName(null);
            Assert.AreEqual(string.Empty, methodName);
        }

        [TestMethod]
        public void GetFullMethodNameShouldReturnNameFromMethodInfo()
        {
            Mock<MethodInfo> mockedMethodInfo = new();
            Mock<Type> mockedType = new();

            string methodName = "MethodName";
            string className = "ClassName";
            
            mockedMethodInfo
                .SetupGet(m => m.Name)
                .Returns(methodName);

            mockedMethodInfo
                .SetupGet(m => m.ReflectedType)
                .Returns(mockedType.Object);

            mockedType
                .SetupGet(type => type.Name)
                .Returns(className);

            string resultMethodName = AttributeHelper.GetFullMethodName(mockedMethodInfo.Object);

            Assert.AreEqual(className + "." + methodName, resultMethodName);
        }
    }
}
