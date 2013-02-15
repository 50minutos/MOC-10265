using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace _002_xxxConnection
{
    class Program
    {
        static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            var c = new SqlConnection
            {
                ConnectionString = cs
            };

            c.StateChange += CStateChange;
            c.Disposed += CDisposed;

            c.Open();

            Thread.Sleep(2000);

            c.Close();

            //c.Dispose();
            ////ou
            //c = null;
            //GC.Collect();
            //Thread.Sleep(2000);

            Console.ReadKey();
        }

        static void CDisposed(object sender, EventArgs e)
        {
            Console.WriteLine("o objeto de conexão foi descartado da memória");
        }

        static void CStateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("o status da conexão foi de {0} para {1}", e.OriginalState, e.CurrentState);
        }
    }
}
