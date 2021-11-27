using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace LoginAndCreate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string createUser(string username, string password, string type);

        [OperationContract]
        string userLogin(string username, string password, string type);

        [OperationContract]
        string AuthUser(string authString, string type);

    }

}
