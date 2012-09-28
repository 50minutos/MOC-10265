using System;
using System.Data;
using System.Data.SqlClient;

namespace _012_xxxCommandStoredProcedure
{
    class Program
    {
        static void Main()
        {
            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection { ConnectionString = cs })
            {
                const String cmd = "uspGetManagerEmployees";

                using (var k = new SqlCommand(cmd, c))
                {
                    k.CommandType = CommandType.StoredProcedure;
                    k.Parameters.AddWithValue("@ManagerID", 16);

                    c.Open();

                    using (var dr = k.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            for (var i = 0; i < dr.FieldCount; i++)
                            {
                                Console.Write("{0}\t", dr[i]);
                            }

                            Console.WriteLine();
                        }
                    }

                    c.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
