using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _001_AW
{
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        Contact GetContactById(int contactID);

        [OperationContract]
        int InsertContact(Contact c);
        
        [OperationContract]
        void UpdateContact(Contact c);
        
        [OperationContract]
        void DeleteContact(Contact c);
    }
}
