using System;
using System.Data;
using System.Data.SqlClient;

namespace _004_xxxConnectionTryCatch
{
    internal class Program
    {
        private static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=false;Connection Timeout=3;";

            //const String cs = @"Data Source=.\SQLEQUISPRESS;Initial Catalog=AdventureWorks;Integrated Security=true;Connection Timeout=3;";
            
            //const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=false;Connection Timeout=3;";

            SqlConnection c = null;

            try
            {
                c = new SqlConnection(cs);

                c.StateChange += CStateChange;
                
                c.Open();
                //c.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Tipo:\n   {0}\n", ex.GetType().Name);
                Console.WriteLine("Mensagem:\n   {0}\n", ex.Message);
                Console.WriteLine("Origem:\n   {0}\n", ex.Source);
            }
            finally
            {
                if (c != null && c.State != ConnectionState.Closed)
                    c.Close();

                Console.ReadKey();
            }
        }

        static void CStateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("o status da conexão foi de {0} para {1}", e.OriginalState, e.CurrentState);
        }
    }
}