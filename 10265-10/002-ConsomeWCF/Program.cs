using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _002_ConsomeWCF.ProxyServico;

namespace _002_ConsomeWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Insert();
            //Update();
            //Delete();
            
            Console.ReadKey();
        }

        private static void Insert()
        {
            using (var p = new ServicoClient())
            {
                Contact c = new Contact
                {
                    FirstName = "NOVO",
                    LastName = "CONTATO DA SILVA",
                    PasswordHash = "jahgdja",
                    PasswordSalt = "491a",
                    rowguid = Guid.NewGuid(),
                    ModifiedDate = DateTime.Now
                };

                var contactID = p.InsertContact(c);

                Console.WriteLine(contactID);

                Console.WriteLine("pronto");
            }
        }

        private static void Update()
        {
            using (var p = new ServicoClient())
            {
                Contact c = p.GetContactById(19982);

                if (c == null) return;

                c.FirstName += "*";

                p.UpdateContact(c);

                Console.WriteLine("pronto");
            }
        }

        private static void Delete()
        {
            using (var p = new ServicoClient())
            {
                Contact c = p.GetContactById(19982);

                p.DeleteContact(c);

                Console.WriteLine("pronto");
            }
        }
    }
}
