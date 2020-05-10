using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Attributes.Properties
{
    /// <summary>
    /// Used in serialization process
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MaskedValueAttribute : Attribute
    {
        public object ValueReplacement { get; }

        public MaskedValueAttribute() : this(default) {}

        /// <param name="valueReplacement">Replacement value when the property is audited</param>
        public MaskedValueAttribute(object valueReplacement)
        {
            ValueReplacement = valueReplacement;
        }
    }
}
