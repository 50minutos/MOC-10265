using System;

namespace _020_DataReaderToList
{
    public class Contact
    {
        public int ContactID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        //todos os outros campos aqui

        public override string ToString()
        {
            return String.Format("{0} - {1} {2}", ContactID, FirstName, LastName);
        }
    }
}
