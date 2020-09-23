using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SymposionBrokerLib
{
   
    [ServiceContract]
    public interface IBroker
    {
        [OperationContract]
        [FaultContract(typeof(AccessFault))]
        string GestisciLogin(string username, string passwd, string role);

        [OperationContract]
        [FaultContract(typeof(AccessFault))]
        string GestisciIscrizione(string username, string passwd, string mail, string role);

    }

    [DataContract]
    public class AccessFault
    {
        private string report;

        public AccessFault(string message)
        {
            this.report = message;
        }

        [DataMember]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }
    }
}
