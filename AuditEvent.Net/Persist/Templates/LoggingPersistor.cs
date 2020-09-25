using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Persist.Templates
{
    public class LoggingPersistor<T> : IPersistor<T>
    {
        public LoggingPersistor(ILogger logger)

        public T Persist(T objectToPersist)
        {
            return objectToPersist;
        }
    }
}
