using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progetto_Symposion;

namespace Amministratore
{
    public class GestioneSegnalazioneLibro
    {
        private string _addr;

        public GestioneSegnalazioneLibro(string addr)
        {
            _addr = addr;
        }

        public void AggiornaLibro(Libro libro)
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IAmministratore> myChannelFactory = new ChannelFactory<IAmministratore>(myBinding, myEndpoint);
                // Create a channel.
                IAmministratore clientAmministratore = myChannelFactory.CreateChannel();
                clientAmministratore.AggiornaLibro(libro);
                ((IClientChannel)clientAmministratore).Close();
                myChannelFactory.Close();
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                //doNothing
            }
        }

    }
}
