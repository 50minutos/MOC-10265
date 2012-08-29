using System;
using System.Linq;

namespace _007_ArrayObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] array = { new Random(), 102.234, "SQL Server", 'S', 10, 120F, 1234M, "Agnaldo", true };

            var tipos = array
                .Select(item => item.GetType().Name)
                .OrderBy(item => item);

            ObjectDumper.Write(array);

            Console.WriteLine();

            ObjectDumper.Write(tipos);

            Console.ReadKey();
        }
    }
}
