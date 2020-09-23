using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class SchedaRecensione
    {
        private string _addr;
        private string _username;

        public SchedaRecensione(string addr, string username)
        {
            _addr = addr;
            _username = username;
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

        public void SegnalaRecensione(Recensione r)
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
                SegnalazioneRecensione segn = new SegnalazioneRecensione()
                {
                    Recensione = r,
                    Username = _username
                };
                client.AddSegnalazioneRecensione(segn);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }
    }
}
