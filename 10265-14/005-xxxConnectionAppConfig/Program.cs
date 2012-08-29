using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace _005_xxxConnectionAppConfig
{
    class Program
    {
        static void Main()
        {
            var cs = ConfigurationManager.ConnectionStrings[ConfigurationManager.AppSettings["sql"]].ConnectionString;

            using (var c = new SqlConnection { ConnectionString = cs })
            {
                c.StateChange += CStateChange;
                c.Disposed += CDisposed;

                c.Open();

                Thread.Sleep(2000);

                c.Close();
            }

            Console.ReadKey();
        }

        static void CDisposed(object sender, EventArgs e)
        {
            Console.WriteLine("o objeto de conexão foi descartado da memória");
        }

        static void CStateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            Console.WriteLine("o status da conexão foi de {0} para {1}", e.OriginalState, e.CurrentState);
        }
    }
}
