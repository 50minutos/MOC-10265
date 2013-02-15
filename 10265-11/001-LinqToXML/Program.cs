using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _001_LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Usuario u = new Model.Usuario()
            {
                User = "agnaldo",
                Password = "abc123@"
            };

            BLL.Usuario.Insert(u);

            foreach (var item in BLL.Usuario.GetAll())
            {
                Console.WriteLine("{0} - {1}", item.User, item.Password);
            }

            Console.WriteLine();

            u.Password = "outraSenh@";

            BLL.Usuario.Update(u);

            foreach (var item in BLL.Usuario.GetAll())
            {
                Console.WriteLine("{0} - {1}", item.User, item.Password);
            }

            Console.WriteLine();

            BLL.Usuario.Delete(u);

            foreach (var item in BLL.Usuario.GetAll())
            {
                Console.WriteLine("{0} - {1}", item.User, item.Password);
            }

            Console.ReadKey();
        }
    }
}
