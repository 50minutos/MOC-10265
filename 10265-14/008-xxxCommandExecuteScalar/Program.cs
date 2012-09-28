using System;
using System.Data.SqlClient;

namespace _008_xxxCommandExecuteScalar
{
    class Program
    {
        static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection { ConnectionString = cs })
            {
                //const String cmd = "SELECT GETDATE()";

                //const String cmd = "SELECT COUNT(*) FROM Person.Contact";

                const String cmd = "SELECT * FROM Person.Contact";

                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    //var d = Convert.ToDateTime(k.ExecuteScalar());
                    //Console.WriteLine("a data do servidor SQL é {0}", d);

                    //var qtdContatos = Convert.ToInt32(k.ExecuteScalar());
                    //Console.WriteLine("existem {0} contatos na tabela", qtdContatos);

                    Console.WriteLine("primeiro campo do primeiro registro da tabela: {0}", k.ExecuteScalar());

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
