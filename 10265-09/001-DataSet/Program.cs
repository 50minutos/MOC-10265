using System;
using System.Linq;

namespace _001_DataSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new AdventureWorksDataSetTableAdapters.ContactTableAdapter().GetData().FirstOrDefault();

            if (c == null) return;

            var antiga = Console.ForegroundColor;

            foreach (var pi in c.GetType().GetProperties().Where(pi => pi.CanRead))
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(pi.Name);
                    Console.ForegroundColor = antiga;
                    Console.WriteLine("{0}\n", pi.GetValue(c, null));
                }
                catch { }
            }

            Console.ReadKey();
        }
    }
}
