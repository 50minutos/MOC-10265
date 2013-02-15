using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace _002_AplicacaoMonoliticaLinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            //tratamento de exceções não implementado para não "poluir" o código

            using (var dc = new AdventureWorksDataContext())
            {
                dc.Log = Console.Out;

                var nomes = dc.GetTable<Contato>()
                            .Take(10)
                            .Select(n => n);

                //foreach (var item in nomes)
                //{
                //    var nome = String.Format("{0} {1} {2}", item.Nome, item.NomeDoMeio, item.Sobrenome);

                //    Console.WriteLine(nome.Replace("  ", " "));
                //}

                foreach (var nome in nomes.Select(item => String.Format("{0} {1} {2}", item.Nome, item.NomeDoMeio, item.Sobrenome)))
                    Console.WriteLine(nome.Replace("  ", " "));
            }

            Console.ReadKey();
        }
    }
}
