using System;
using System.Data.SqlClient;

namespace _011_xxxCommandExecuteXmlReader
{
    class Program
    {
        static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection { ConnectionString = cs })
            {
                const String cmd = "SELECT TOP 3 ContactID, FirstName, LastName FROM Person.Contact FOR XML AUTO";

                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    using (var xml = k.ExecuteXmlReader())
                    {
                        while (xml.Read())
                        {
                            Console.WriteLine("{0} -> {1} {2}", xml["ContactID"], xml["FirstName"], xml["LastName"]);
                        }
                    }

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
