using Libreria.ServiceReferenceBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Iscrizione
    {
        public string RegistraUtente(string username, string password, string mail, string role)
        {
            string addr = null;
            BrokerClient client = new BrokerClient();
            try
            {
                addr = client.GestisciIscrizione(username, password, mail, role);
            }
            catch (Exception e)
            {

            }
            client.Close();
            return addr;
        }
    }
}
