using System;
using System.Data.SqlClient;

namespace _007_xxxCommandParameters
{
    class Program
    {
        static void Main()
        {
            /*
            aplicação vulnerável ao sql injection

            var nomePessoa = "Adão";
            
            o usuário digita na tela de cadastro: 
                Adão');drop table pessoa;--
            
            var cmd = "INSERT INTO PESSOA VALUES ('" + nomePessoa + "')";
            
            o resultado é um conjunto de dois comandos e um comentário: 
                INSERT INTO PESSOA VALUES ('Adão');
                drop table pessoa;
                --')
            */

            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection { ConnectionString = cs })
            {
                const String cmd = "SELECT FirstName FROM Person.Contact WHERE ContactID = @ContactID";

                using (var k = new SqlCommand(cmd, c))
                {
                    k.Parameters.AddWithValue("@ContactID", 1);

                    c.Open();

                    Console.WriteLine("o nome do contato é {0}", k.ExecuteScalar());

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
