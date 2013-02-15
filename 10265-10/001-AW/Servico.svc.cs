using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _001_AW
{
    public class Servico : IServico
    {
        public Contact GetContactById(int contactID)
        {
            using (var e = new AdventureWorksEntities())
            {
                return e.Contacts.FirstOrDefault(c => c.ContactID == contactID);
            }
        }

        public int InsertContact(Contact c)
        {
            var retorno = 0;

            using (var e = new AdventureWorksEntities())
            {
                e.AddObject("Contacts", c);
                e.SaveChanges();

                retorno = c.ContactID;
            }

            return retorno;
        }

        public void UpdateContact(Contact c)
        {
            using (var e = new AdventureWorksEntities())
            {
                e.Attach(e.Contacts.Single(x => x.ContactID == c.ContactID));
                e.ApplyCurrentValues("Contacts", c);
                e.SaveChanges();
            }
        }

        public void DeleteContact(Contact c)
        {
            if (c == null) return;

            using (var e = new AdventureWorksEntities())
            {
                e.Attach(c);
                e.DeleteObject(c);
                e.SaveChanges();
            }
        }
    }
}
