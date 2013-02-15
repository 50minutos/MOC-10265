using System;

using _005_ConsomeWCF.ProxyContact;

namespace _005_ConsomeWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ContactClient();

            var c = proxy.GetByContactId(1);
            if (c != null) Console.WriteLine("{0} -> {1}", c.ContactID, c.FirstName);
            
            c = proxy.GetByContactId(10);
            if (c != null) Console.WriteLine("{0} -> {1}", c.ContactID, c.FirstName);
            
            c = proxy.GetByContactId(100);
            if (c != null) Console.WriteLine("{0} -> {1}", c.ContactID, c.FirstName);

            c = proxy.GetByContactId(1000);
            if (c != null) Console.WriteLine("{0} -> {1}", c.ContactID, c.FirstName);

            c = proxy.GetByContactId(10000);
            if (c != null) Console.WriteLine("{0} -> {1}", c.ContactID, c.FirstName);

            Console.WriteLine();

            var contatos = proxy.GetFirst10();

            foreach (var item in contatos)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadKey();
        }
    }
}
