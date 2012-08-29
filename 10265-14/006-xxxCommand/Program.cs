using System;
using System.Data.SqlClient;

namespace _006_xxxCommand
{
    class Program
    {
        static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection { ConnectionString = cs })
            {
                const String cmd = "select getdate()";

                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    Console.WriteLine("a data do servidor SQL é {0}", k.ExecuteScalar());

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
