using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace _020_DataReaderToList
{
    static class Program
    {

        static void Main()
        {
            var lista = new List<Contact>();

            const String cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=AdventureWorks;Integrated Security=true";

            using (var c = new SqlConnection { ConnectionString = cs })
            {
                const String cmd = "SELECT TOP 3 ContactID, FirstName, LastName FROM Person.Contact";

                using (var k = new SqlCommand(cmd, c))
                {
                    c.Open();

                    using (var dr = k.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Contact(){ ContactID = Convert.ToInt32(dr[0]), FirstName = dr[1].ToString(), LastName = dr[2].ToString() });
                        }
                    }

                    c.Close();
                }
            }

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey(); 
        }
    }
}
