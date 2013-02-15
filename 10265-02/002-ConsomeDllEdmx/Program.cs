using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _001_DllEdmx;

namespace _002_ConsomeDllEdmx
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Contact { FirstName = "Agnaldo", MiddleName = "D. dos", LastName = "Santos" };

            Console.WriteLine("{0} {1} {2}", c.FirstName, c.MiddleName, c.LastName);

            using (var e = new AdventureWorksEntities())
            {
                var contato = e.Contact.FirstOrDefault<Contact>();

                Console.WriteLine("{0} {1} {2}", contato.FirstName, contato.MiddleName, contato.LastName);

                foreach (var item in contato.SalesOrderHeader)
                {
                    Console.WriteLine("\t{0} - US$ {1:n}", item.OrderDate, item.SubTotal);
                }
            }

            Console.ReadKey();
        }
    }
}
