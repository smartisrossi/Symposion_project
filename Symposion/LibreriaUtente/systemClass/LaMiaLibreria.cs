using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class LaMiaLibreria
    {
        private string _username;
        private string _addr;
        private List<Lista> _leMieListe = new List<Lista>();
        private List<Lista> _listeSalvate = new List<Lista>();
        private List<Recensione> _leMieRecensioni = new List<Recensione>();
        private List<Recensione> _recensioniSalvate = new List<Recensione>();

        public LaMiaLibreria(string username, string addr)
        {
            _username = username;
            _addr = addr;
        }

        public List<Lista> LeMieListe
        {
            get
            {
                return _leMieListe;
            }
        }
        public List<Lista> ListeSalvate
        {
            get
            {
                return _listeSalvate;
            }
        }
        public List<Recensione> LeMieRecensioni
        {
            get
            {
                return _leMieRecensioni;
            }
        }
        public List<Recensione> RecensioniSalvate
        {
            get
            {
                return _recensioniSalvate;
            }
        }



        public List<Lista> GetLeMieListe()
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
                _leMieListe = client.GetListePersonali(_username).ToList<Lista>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return _leMieListe;
        }

        public List<Lista> GetListePreferite()
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
                _listeSalvate = client.GetListeSalvate(_username).ToList<Lista>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return _listeSalvate;
        }

        public List<Recensione> GetLeMieRecensioni()
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
                _leMieRecensioni = client.GetRecensioniScritte(_username).ToList<Recensione>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return _leMieRecensioni;
        }

        public List<Recensione> GetRecensioniPreferite()
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
                _recensioniSalvate = client.GetRecensioniSalvate(_username).ToList<Recensione>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return _recensioniSalvate;
        }
    }
}
