using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class RicercaPubblica
    {
        private string _addr;
        private string _username;

        public RicercaPubblica(string addr, string username)
        {
            _addr = addr;
            _username = username;
        }

        public List<Recensione> CercaRecensioniLibro(Libro libro)
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
                recensioni = client.CercaRecensioniLibro(libro).ToList<Recensione>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return recensioni;
        }

        public List<Libro> CercaLibro(string titolo)
        {
            List<Libro> libri = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                libri = client.CercaLibro(titolo).ToList<Libro>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return libri;
        }

        public List<Lista> CercaLista(string nome)
        {
            List<Lista> liste = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                liste = client.CercaLista(nome).ToList<Lista>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return liste;
        }

        public List<Libro> CercaGenere(string genereString)
        {
            List<Libro> libri = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                libri = client.CercaGenere(genereString).ToList<Libro>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return libri;
        }
      
        public string CercaUtente(string username)
        {
            string userTrovato = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                userTrovato = client.CercaUtente(username);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return userTrovato;
        }
    }
}
