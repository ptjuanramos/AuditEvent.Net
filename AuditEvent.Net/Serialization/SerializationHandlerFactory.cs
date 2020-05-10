using AuditEvent.Net.Serialization.Handlers;
using AuditEvent.Net.Serialization.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Serialization
{
    internal class SerializationHandlerFactory
    {
        public ISerializationHandler GetInstance(SerializerHandlerType type)
        {
            switch(type)
            {
                case SerializerHandlerType.JSON:
                    return new JsonSerializationHandler();
                case SerializerHandlerType.XML:
                    return new XmlSerializationHandler();
                case SerializerHandlerType.YAML:
                    return new YamlSerializationHandler();
                default:
                    throw new EntryPointNotFoundException();
            }
        }
    }
}
