using System.Collections.Generic;
using System.Linq;

namespace _004_WCF
{
    public class ContactService: IContact
    {
        public Contact[] Get()
        {
            Contact[] retorno = null;

            using (var e = new AdventureWorksEntities())
            {
                retorno = e.Contact.Take(10).ToArray();
            }

            return retorno;
        }

        public Contact Get(int contactID)
        {
            using (var e = new AdventureWorksEntities())
            {
                return e.Contact.FirstOrDefault(c => c.ContactID == contactID);
            }
        }
    }
}
