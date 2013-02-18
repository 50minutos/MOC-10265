using System;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Threading;
using _001_AW;

namespace _003_Refresh
{
    class Program
    {
        private static readonly Random r;

        static Program()
        {
            r = r ?? new Random();
        }
        
        static void Main(string[] args)
        {
            for (var i = 0; i < 3; i++)
            {
                new Thread(AlterarProduto).Start();
            }

            Console.ReadKey();
        }

        private static void AlterarProduto()
        {
            using (var e = new AdventureWorksEntities())
            {
                var p = e.Produtos.First();

                Console.WriteLine(p.Preco);

                p.Preco = r.Next(1, 101);
                p.DataDeAlteracao = DateTime.Now;

                try
                {
                    e.SaveChanges();
                }
                catch (OptimisticConcurrencyException)
                {
                    //Console.WriteLine("Client wins");
                    //e.Refresh(RefreshMode.ClientWins, p);

                    Console.WriteLine("Store wins");
                    e.Refresh(RefreshMode.StoreWins, p);
                    
                    e.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0}\n\t{1}", ex.GetType().Name, ex.Message);
                }
                finally
                {
                    Console.WriteLine("{0} -> {1} - {2}", Thread.CurrentThread.ManagedThreadId, p.Nome, p.Preco);
                }
            }
        }
    }
}
