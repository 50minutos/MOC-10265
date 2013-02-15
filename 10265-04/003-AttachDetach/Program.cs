using System;
using System.Linq;
using _001_AW;

namespace _003_AttachDetach
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                var c = e.Contatos.First();

                Console.WriteLine(c.EntityState);

                e.Attach(c);

                Console.WriteLine(c.EntityState);

                c.Nome = "Gustavo";

                Console.WriteLine(c.EntityState);

                e.Detach(c);

                Console.WriteLine(c.EntityState);
            }

            Console.ReadKey();
        }
    }
}
