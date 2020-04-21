using AuditEvent.Net.Attributes.Properties;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Tests.Attributes.Properties
{
    [TestFixture]
    public class TestingMaskableProperty
    {
        [MaskedValue]
        public string SensitiveInformation_DefaultReplacementValue { get; set; }

        [MaskedValue("CUSTOM_REPLACEMENT_VALUE")]
        public string SensitiveInformation_WithCustomReplacementValue { get; set; }

        [Test]
        public void Test_PropertiesReplacementValues()
        {
            //Attribute.GetCustomAttribute(typeof(Maskable))
        }
    }
}
