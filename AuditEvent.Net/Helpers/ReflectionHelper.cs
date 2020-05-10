using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AuditEvent.Net.Helpers
{
    internal static class ReflectionHelper
    {
        /// <summary>
        /// Generic way to search classes that extend a certain base class(T)
        /// Base in a base class T this method will obtain the children classes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Type> GetChildClasses(Type typeOfBaseClass)
        {
            return Assembly.GetAssembly(typeOfBaseClass)
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeOfBaseClass));
        }

    }
}
