using System.Collections.Generic;
using System.Linq;

namespace _002_ExtensionMethod
{
    public static class ListExtension
    {
        public static void AddUnique<T>(this List<T> lista, T item)
        {
            //eu sei que o HashSet<T> não aceita elementos repetidos... isso é um exemplo de extensão!!!
            
            if (!lista.Contains(item))
                lista.Add(item);
        }

        public static int Count<T>(this List<T> lista, T item)
        {
            return lista.Count(elemento => elemento.Equals(item));
        }
    }
}
