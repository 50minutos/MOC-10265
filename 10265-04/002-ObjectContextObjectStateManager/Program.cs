using System;
using System.Data;
using _001_AW;

namespace _002_ObjectContextObjectStateManager
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                Object o = null;

                var k = new EntityKey("AdventureWorksEntities.Contatos", "ContactID", 1);
                
                if (!e.TryGetObjectByKey(k, out o)) goto fim;

                var c = o as Contato;

                if (c == null) goto fim;

                c.Nome += "*";

                Console.WriteLine("{0} {1}", c.Nome, c.Sobrenome);

                //e.SaveChanges();
            }

        fim: //não usar label... isso é só uma brincadeira...
            Console.ReadKey();
        }
    }
}
