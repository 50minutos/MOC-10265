using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using _001_AW;

namespace _005_Update
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                var c = e.Contatos.First();

                c.Nome += "#";

                Console.WriteLine(e.Contatos.First().Nome);

                e.SaveChanges();

                Console.WriteLine(e.Contatos.First().Nome);

                e.Detach(c);

                c.Nome += "@";

                var key = e.CreateEntityKey("Contatos", c);

                object o;

                if (e.TryGetObjectByKey(key, out o))
                {
                    e.ApplyCurrentValues(key.EntitySetName, c);
                }

                e.SaveChanges();

                Console.WriteLine(e.Contatos.First().Nome);
            }

            Console.ReadKey();
        }
    }
}
