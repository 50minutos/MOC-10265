using System;

using System.Data.SqlClient;

namespace _001_AplicacaoMonoliticaADONet
{
    class Program
    {
        static void Main(string[] args)
        {
            //tratamento de exceções não implementado para não "poluir" o código

            const String cs = "Data Source=.\\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true;";

            using(var c = new SqlConnection(cs))
            {
                const String cmd = "SELECT TOP 10 FirstName, MiddleName, LastName FROM Person.Contact";

                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    var dr = k.ExecuteReader();

                    while(dr.Read())
                    {
                        var nome = String.Format("{0} {1} {2}", dr[0], dr[1], dr[2]);
                        Console.WriteLine(nome.Replace("  ", " "));
                    }

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
