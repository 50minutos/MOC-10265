using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _003_ConsomeWCFDataService.Proxy;

namespace _003_ConsomeWCFDataService
{
    class Program
    {
        static void Main(string[] args)
        {
            //MostrarInsert();
            //MostrarUpdate();
            MostrarDelete();

            Console.ReadKey();
        }

        private static void MostrarDelete()
        {
            var awe = new AdventureWorksEntities(new Uri("http://localhost:20708/AWDataService.svc/"));

            if (awe.Contatos == null) return;

            var contato = awe.Contatos
                .AddQueryOption("$filter", "ContactID eq 20006")
                .FirstOrDefault();

            if (contato == null) return;

            awe.DeleteObject(contato);

            awe.SaveChanges();

            Console.WriteLine("pronto");
        }

        private static void MostrarUpdate()
        {
            var awe = new AdventureWorksEntities(new Uri("http://localhost:20708/AWDataService.svc/"));

            if (awe.Contatos == null) return;

            var contatos = awe.Contatos.Execute();

            if (contatos == null) return;

            var contato = contatos.FirstOrDefault(c => c.ContactID == 20007);

            if (contato == null) return;

            contato.Nome += "*";

            awe.UpdateObject(contato);

            awe.SaveChanges();

            Console.WriteLine("pronto");
        }

        private static void MostrarInsert()
        {
            var awe = new AdventureWorksEntities(new Uri("http://localhost:20708/AWDataService.svc/"));

            var c = new Contato
            {
                Nome = "Chico",
                Sobrenome = "Medonho",
                rowguid = Guid.NewGuid(),
                PasswordHash = "dg13423423",
                PasswordSalt = "azfvsrd",
                ModifiedDate = DateTime.Now
            };

            awe.AddObject("Contatos", c);
            awe.SaveChanges();

            Console.WriteLine("código: {0}", c.ContactID);
        }
    }
}
