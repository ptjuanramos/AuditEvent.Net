using System;
using System.Collections.Generic;
using System.Text;

namespace AuditEvent.Net.Persist
{
    public interface IPersistor<T>
    {
        T Persist(T objectToPersist);
    }
}
