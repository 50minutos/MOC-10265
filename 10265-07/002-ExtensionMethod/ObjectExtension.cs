using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _002_ExtensionMethod
{
    public static class ObjectExtension
    {
        public static IEnumerable<String> ListarPropriedades(this Object o)
        {
            var t = o.GetType();

            return t.GetProperties().Select(propertyInfo => propertyInfo.ToString());
        }
        
        public static IEnumerable<String> ListarMetodos(this Object o)
        {
            var t = o.GetType();

            return t.GetMethods().Select(methodInfo => methodInfo.ToString());
        }
    }
}
