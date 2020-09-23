using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Classifiche
    {
        private string _addr;
        private string _username;

        public Classifiche(string addr, string username)
        {
            _addr = addr;
            _username = username;
        }

        public Libro[] GetClassificaGenere(string genereString)
        {
            Libro[] libri = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                libri = client.GetClassificaGenere(genereString);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return libri;
        }

        public Libro[] GetClassificaAnno(int anno)
        {
            Libro[] libri = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                libri = client.GetClassificaAnno(anno);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            return libri;
        }


    }
}
