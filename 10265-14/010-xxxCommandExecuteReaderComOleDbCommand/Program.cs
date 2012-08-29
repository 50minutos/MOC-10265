using System;
using System.Data.OleDb;

namespace _010_xxxCommandExecuteReaderComOleDbCommand
{
    class Program
    {
        static void Main()
        {
            const String cs = @"Provider=SQLNCLI10;Server=.\SQLEXPRESS;Database=AdventureWorks;Trusted_Connection=yes;";

            using (var c = new OleDbConnection { ConnectionString = cs })
            {
                const String cmd = "SELECT TOP 3 ContactID, FirstName, LastName FROM Person.Contact";

                using (var k = new OleDbCommand(cmd, c))
                {
                    c.Open();

                    using (var dr = k.ExecuteReader())
                    {
                        if (dr == null) return;

                        while (dr.Read())
                        {
                            Console.WriteLine("{0} -> {1} {2}", dr["ContactID"], dr["FirstName"], dr["LastName"]);
                        }
                    }

                    c.Close();
                }
            }


            Console.ReadKey();

        }
    }
}
