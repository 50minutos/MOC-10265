using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using _001_AW;

namespace _002_Concorrencia
{
    class Program
    {
        private static readonly Random R;

        static Program()
        {
            R = R ?? new Random();
        }

        static void Main(string[] args)
        {
            //for (var i = 0; i < 5; i++)
            //    new Thread(AlterarContato).Start();

            //for (var i = 0; i < 5; i++)
            //    new Thread(AlterarProduto).Start();

            Console.ReadKey();
        }

        private static void AlterarContato()
        {
            using (var e = new AdventureWorksEntities())
            {
                var c = e.Contatos.First();

                Console.WriteLine(c.Nome);
                
                c.Nome += ObterComplemento();
                c.DataDeAlteracao = DateTime.Now;

                e.SaveChanges();

                Console.WriteLine("{0} -> {1} - {2:dd/MM/yyyy HH:mm:ss.fff}", Thread.CurrentThread.ManagedThreadId, c.Nome, c.DataDeAlteracao);
            }
        }

        private static void AlterarProduto()
        {
            using (var e = new AdventureWorksEntities())
            {
                var p = e.Produtos.First();

                Console.WriteLine(p.Preco);

                p.Preco = ObterPreco();
                //p.DataDeAlteracao = DateTime.Now;


                e.SaveChanges();

                Console.WriteLine("{0} -> {1} - {2}", Thread.CurrentThread.ManagedThreadId, p.Nome, p.Preco);
            }
        }

        private static int ObterPreco()
        {
            return R.Next(1, 101);
        }

        private static String ObterComplemento()
        {
            return ((char)R.Next(65, 91)).ToString(CultureInfo.InvariantCulture);
        }
    }
}
