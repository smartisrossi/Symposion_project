using Amministratore.ServiceReferenceBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amministratore
{
    public class Login
    {
        public string VerificaCredenziali(string username, string password, string role) 
        {
            string addr = null;
            BrokerClient client = new BrokerClient();
            try
            {
                addr = client.GestisciLogin(username, password, role);
            }
            catch(Exception e)
            {

            }
            client.Close();
            return addr;
        }
    }
}
