using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class RecensioniSalvate
    {
        private string _username;
        private List<Recensione> _recensioniPreferite;
        private string _addr;

        public RecensioniSalvate(string username, string addr)
        {
            _recensioniPreferite = new List<Recensione>();
            _username = username;
            _addr = addr;
        }

        public void SalvaRecensione(Recensione r)
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                client.SalvaRecensione(r, _username);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }

        public void RimuoviRecensione(Recensione r)
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                client.RimuoviRecensione(r, _username);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }
    }
}
