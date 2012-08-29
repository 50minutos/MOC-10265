using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _005_CustomizarEdmx
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa {Id = 1, Nome = "ADÃO", NomeConjuge = "EVA"};

            Console.WriteLine("{0}\n{1}\n{2}", p.Id, p.Nome, p.NomeConjuge);

            Console.ReadKey();
        }
    }
}
