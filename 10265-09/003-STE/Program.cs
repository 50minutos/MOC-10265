using System;
using System.Linq;

namespace _003_STE
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var e = new AdventureWorksEntities())
            {
                var c = e.Contact.FirstOrDefault();

                if (c == null) return;

                c.ChangeTracker.ChangeTrackingEnabled = true;

                c.ContactID += 1;
                c.FirstName += "■";

                Console.WriteLine("{0} -> {1}", c.ContactID, c.FirstName);

                Console.ReadKey();
            }
        }
    }
}
