using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "50minutos treinamentos em tecnologia";

            foreach (var item in s)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            var letras = from letra in s
                         select letra;

            foreach (var item in letras)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            var maisLetras = s.Select(x => x);

            foreach (var item in maisLetras)
            {
                Console.Write("{0} ", item);
            }


            Console.ReadKey();
        }
    }
}
