using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Attributes.Properties
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MaskedValueAttribute : Attribute
    {
        public string ValueReplacement { get; }

        /// <summary>
        /// By default the value replacement is a <see cref="Guid"/>
        /// </summary>
        public MaskedValueAttribute() : this(Guid.NewGuid().ToString()) {}

        /// <param name="valueReplacement">Replacement value when the property is audited</param>
        public MaskedValueAttribute(string valueReplacement)
        {
            ValueReplacement = valueReplacement;
        }
    }
}
