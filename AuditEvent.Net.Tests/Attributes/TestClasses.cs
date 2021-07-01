using AuditEvent.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditEvent.Net.Tests.Attributes
{
    static class TestClasses
    {
        public class DummyWithoutAttribute
        {
            public void Test() { }
        }

        public class DummyWithClassAttribute { }

        public class DummyWithMethodWithAttribute
        {
            [Auditable]
            public void Test() { }
        }
    }
}
