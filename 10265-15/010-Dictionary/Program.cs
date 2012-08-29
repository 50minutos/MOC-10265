using System;
using System.Collections.Generic;
using System.Linq;

namespace _010_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> numeros =
    new Dictionary<int, String>();

            numeros.Add(1, "um");
            numeros.Add(2, "dois");
            numeros.Add(3, "tres");
            numeros.Add(4, "quatro");
            numeros.Add(5, "cinco");
            numeros.Add(6, "seis");
            numeros.Add(7, "sete");
            numeros.Add(8, "oito");
            numeros.Add(9, "nove");
            numeros.Add(10, "dez");

            var pares = from numero in numeros
                        where numero.Key % 2 == 0
                        select numero.Value;

            ObjectDumper.Write(pares);

            var x = new Dictionary<String, int>();
            
            x.Add("um", 1);
            x.Add("dois", 2);
            x.Add("três", 3);

            Console.WriteLine(numeros[x["três"] - x["um"]]);

            Console.ReadKey();
        }
    }
}
