using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class SchedaUtente
    {
        private string _username;
        private string _addr;

        public SchedaUtente(string username, string addr)
        {
            _username = username;
            _addr = addr;
        }

        public List<Recensione> getRecensioni(string usernameUtente)
        {
            List<Recensione> recensioni = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                recensioni = client.CercaRecensioniUtente(usernameUtente).ToList<Recensione>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return recensioni; 
        }

        public List<Lista> getListe(string usernameUtente)
        {
            List<Lista> recensioni = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                recensioni = client.CercaListaUtente(usernameUtente).ToList<Lista>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return recensioni; 
        }

    }
}
