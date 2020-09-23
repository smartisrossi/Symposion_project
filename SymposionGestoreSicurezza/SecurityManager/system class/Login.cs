using SecurityManager.ServiceReferenceBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManager
{
    public class Login
    {
        public string VerificaCredenziali(string username, string password, string role) 
        {
            string addr = null;
            BrokerClient client = new BrokerClient();
            addr = client.GestisciLogin(username, password, role);
            client.Close();
            return addr;
        }
    }
}
