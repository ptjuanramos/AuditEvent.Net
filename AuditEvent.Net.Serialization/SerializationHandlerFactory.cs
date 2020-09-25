using AuditEvent.Net.Serialization.Handlers;
using AuditEvent.Net.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Serialization
{
    internal class SerializationHandlerFactory
    {
        public ISerializationHandler GetInstance(SerializationHandlerType type)
        {
            return type switch
            {
                SerializationHandlerType.JSON => new JsonSerializationHandler(),
                SerializationHandlerType.XML => new XmlSerializationHandler(),
                SerializationHandlerType.YAML => new YamlSerializationHandler(),
                _ => throw new EntryPointNotFoundException(),
            };
        }
    }
}
