using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class ListeSalvate
    {
        private string _username;
        private List<Lista> _listePreferite;
        private string _addr;

        public ListeSalvate(string username, string addr)
        {
            _listePreferite = new List<Lista>();
            _username = username;
            _addr = addr;
        }

        public void SalvaLista(Lista lista)
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
                client.SalvaLista(lista, _username);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }

        public void RimuoviLista(Lista lista)
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
                client.RimuoviLista(lista, _username);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }
    }
}
