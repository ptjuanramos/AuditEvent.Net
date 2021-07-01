using AuditEvent.Net.Serialization.Concrete;
using System;

namespace AuditEvent.Net.Serialization
{
    internal class SerializationHandlerFactory
    {
        public static ISerializationHandler GetInstance(SerializationHandlerType type)
        {
            return type switch
            {
                SerializationHandlerType.JSON => new JsonSerializationHandler(),
                SerializationHandlerType.XML => new XmlSerializationHandler(),
                _ => throw new EntryPointNotFoundException(),
            };
        }
    }
}
