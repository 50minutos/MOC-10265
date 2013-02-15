using System.Collections.Generic;
using System.ServiceModel;

namespace _004_WCF
{
    [ServiceContract]
    public interface IContact
    {
        [OperationContract(Name = "GetFirst10")]
        Contact[] Get();

        [OperationContract(Name = "GetByContactId")]
        Contact Get(int contactID);
    }
}
