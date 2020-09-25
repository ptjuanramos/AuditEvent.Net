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
            switch(type)
            {
                case SerializationHandlerType.JSON:
                    return new JsonSerializationHandler();
                case SerializationHandlerType.XML:
                    return new XmlSerializationHandler();
                default:
                    throw new EntryPointNotFoundException();
            }
        }
    }
}
