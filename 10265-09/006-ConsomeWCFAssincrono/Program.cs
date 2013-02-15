using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using _006_ConsomeWCFAssincrono.ProxyContact;

namespace _006_ConsomeWCFAssincrono
{
    class Program
    {
        static ContactClient c = null;

        static void Main(string[] args)
        {
            c = new ContactClient();
            
            c.BeginGetFirst10(new AsyncCallback(GetFirst10Completed), null);

            c.BeginGetByContactId(1, new AsyncCallback(GetByContactIdCompleted), null);
            c.BeginGetByContactId(10, new AsyncCallback(GetByContactIdCompleted), null);
            c.BeginGetByContactId(100, new AsyncCallback(GetByContactIdCompleted), null);
            c.BeginGetByContactId(1000, new AsyncCallback(GetByContactIdCompleted), null);
            c.BeginGetByContactId(10000, new AsyncCallback(GetByContactIdCompleted), null);

            Console.ReadKey();
        }

        private static void GetByContactIdCompleted(IAsyncResult iar)
        {
            var contato = c.EndGetByContactId(iar);
            
            if (contato == null) return;
            
            Console.WriteLine("-> {0} {1}", contato.ContactID, contato.FirstName);
        }

        private static void GetFirst10Completed(IAsyncResult iar)
        {
            var contatos = c.EndGetFirst10(iar);

            if (contatos == null || contatos.Length == 0) return;

            foreach (var contato in contatos)
            {
                Console.WriteLine(contato.FirstName);
            }
        }
    }
}
