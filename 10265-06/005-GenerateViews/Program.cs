using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _004_AWPre;

namespace _005_GenerateViews
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var e = new AdventureWorksEntities())
            {
                foreach (var contato in e.Contatos.Take(20))
                {
                    Console.WriteLine(contato.Nome);
                }
            }

            Console.ReadKey();
        }
    }
}
