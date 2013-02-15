using System;
using System.Data.Objects;
using System.Linq;

namespace _001_ObterDadosUsandoLinqToEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                e.ObjectMaterialized += EObjectMaterialized;

                var contatos = from c in e.Contatos
                               where c.ContactID <= 15
                               select c;

                Console.WriteLine(contatos);

                foreach (var contato in contatos/*.ToList()*/)
                {
                    Console.WriteLine("{0} {1}", contato.Nome, contato.Sobrenome);
                }

                //Console.WriteLine(((ObjectQuery<Contato>)contatos).ToTraceString());
            }

            Console.ReadKey();
        }

        static void EObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var t = e.Entity.GetType();

            //var p = t.GetProperty("Nome");

            //Console.WriteLine("   >>> materializei {0}", p.GetValue(e.Entity, null));

            foreach (var item in t.GetProperties())
            {
                if (item.CanRead)
                {
                    Console.WriteLine(item.GetValue(e.Entity, null));
                }

                Console.WriteLine();
            }
        }
    }
}
