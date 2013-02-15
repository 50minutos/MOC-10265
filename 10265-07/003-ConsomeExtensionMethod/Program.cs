using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using _000_AW;
using _002_ExtensionMethod;

namespace _003_ConsomeExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //MostrarObjectExtension();

            //MostrarListExtension();

            //MostrarObjectContextExtension();

            //MostrarOnXXXChangXXX();

            MostrarOnPropertyChangXXX();

            Console.ReadKey();
        }

        private static void MostrarOnPropertyChangXXX()
        {
            using (var e = new AdventureWorksEntities())
            {
                var c = e.Contatos.First();

                c.PropertyChanged += CPropertyChanged;
                c.PropertyChanging += CPropertyChanging;

                c.Nome += " alterado";
                c.Sobrenome = c.Sobrenome.ToUpper();
                c.DataDeAlteracao = DateTime.Now;
            }
        }

        static void CPropertyChanging(Object sender, PropertyChangingEventArgs e)
        {
            if ("Nome|Sobrenome".Contains(e.PropertyName))
                Console.WriteLine("o valor original da propriedade {0} é {1}",
                    e.PropertyName,
                    sender.GetType().GetProperty(e.PropertyName).GetValue(sender, null));
        }

        static void CPropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine("o valor atual da propriedade {0} é {1}",
                e.PropertyName,
                sender.GetType().GetProperty(e.PropertyName).GetValue(sender, null));
        }

        private static void MostrarOnXXXChangXXX()
        {
            using (var e = new AdventureWorksEntities())
            {
                e.Contatos.First().Nome += " alterado";
                //e.Contatos.First().Nome = null;
            }
        }

        private static void MostrarObjectContextExtension()
        {
            using (var e = new AdventureWorksEntities())
            {
                var c = e.Contatos.First();

                Console.WriteLine(e.FoiAlterado(c));

                c.Nome += " alterado";

                Console.WriteLine(e.FoiAlterado(c));
            }
        }

        private static void MostrarListExtension()
        {
            var nomes = new List<String> { "ADÃO", "EVA", "CAIM", "ABEL" };

            nomes.AddUnique("ADÃO");
            nomes.AddUnique("COBRA");

            nomes.Add("ADÃO");

            foreach (var nome in nomes) { Console.WriteLine(nome); }

            Console.WriteLine();

            Console.WriteLine(nomes.Count("ADÃO"));

            Console.WriteLine(new string('-', 80));

            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            numeros.AddUnique(5);

            foreach (var numero in numeros) { Console.WriteLine(numero); }
        }

        private static void MostrarObjectExtension()
        {
            var o = new Object();

            Console.WriteLine("Metodos de Object:");
            foreach (var s in o.ListarMetodos())
            {
                Console.WriteLine(s);
            }

            const int x = 10;

            Console.WriteLine("\nMetodos de int:");
            foreach (var s in x.ListarMetodos())
            {
                Console.WriteLine(s);
            }

            const String nome = "agnaldo";

            Console.WriteLine("\nMetodos de uma String:");
            foreach (var s in nome.ListarMetodos())
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nPropriedades de uma String:");
            foreach (var s in nome.ListarPropriedades())
            {
                Console.WriteLine(s);
            }
        }
    }
}
