using System;
using System.Data.SqlClient;

namespace _009_xxxCommandExecuteReader
{
    internal class Program
    {
        private static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection {ConnectionString = cs})
            {
                const String cmd = "SELECT TOP 3 ContactID, FirstName, LastName FROM Person.Contact";

                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    using (var dr = k.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Console.WriteLine("{0} -> {1} {2}", dr[0], dr[1], dr[2]);
                            //Console.WriteLine("{0} -> {1} {2}", dr["ContactID"], dr["FirstName"], dr["LastName"]);
                            Console.WriteLine("{0} -> {1} {2}", dr.GetInt32(0), dr.GetString(1), dr.GetString(2));
                            
                        }
                    }

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}