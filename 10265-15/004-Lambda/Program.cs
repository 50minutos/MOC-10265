using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _004_Lambda
{
    class Program
    {
        static Func<int, int, int> Menor = (n1, n2) => n1 < n2 ? n1 : n2;
        static Func<int, bool> Par = n => n % 2 == 0;
        static Func<String, int> Len = s => s.Length;

        static void Main(string[] args)
        {
            Console.WriteLine(Menor(10, -21));
            Console.WriteLine(Par(11));
            Console.WriteLine(Par(12));
            Console.WriteLine(Len("green"));

            Console.ReadKey();
        }
    }
}
