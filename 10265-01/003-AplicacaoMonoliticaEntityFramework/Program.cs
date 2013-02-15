using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _003_AplicacaoMonoliticaEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                //foreach (var item in e.Contatos.Take(10))
                //{
                //    var nome = String.Format("{0} {1} {2}", item.Nome, item.NomeDoMeio, item.Sobrenome);

                //    Console.WriteLine(nome.Replace("  ", " "));
                //}

                foreach (var nome in e.Contatos.Take(10).Select(item =>  item.Nome + " " + (item.NomeDoMeio ?? "") + " " + item.Sobrenome))
                    Console.WriteLine(nome.Replace("  ", " "));
            }

            Console.ReadKey();
        }
    }
}
