using System;
using _001_AW;

namespace _004_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                //var c = Contato.CreateContato(0,
                //    true,
                //    "Adão",
                //    "da Silva",
                //    0,
                //    "abc",
                //    "xyz",
                //    Guid.NewGuid(),
                //    DateTime.Now);

                var c = new Contato
                {
                    Nome = "Adão",
                    Sobrenome = "da Silva",
                    PasswordHash = "abc",
                    PasswordSalt = "xyz",
                    rowguid = Guid.NewGuid(),
                    ModifiedDate = DateTime.Now
                };

                e.AddToContatos(c);

                Console.WriteLine("{0} {1}", c.Nome, c.Sobrenome);

                e.SaveChanges();

                Console.WriteLine("ContactID = {0}", c.ContactID);
            }

            Console.ReadKey();
        }
    }
}
