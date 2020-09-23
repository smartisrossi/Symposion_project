using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Amministratore
{
    public class HomeAmministratore
    {
        private string _addr;

        public HomeAmministratore(string addr)
        {
            _addr = addr;
        }

        public SegnalazioneRecensione GetSegnalazioneRecensione()
        {
            SegnalazioneRecensione segn = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IAmministratore> myChannelFactory = new ChannelFactory<IAmministratore>(myBinding, myEndpoint);
                // Create a channel.
                IAmministratore clientAmministratore = myChannelFactory.CreateChannel();
                segn = clientAmministratore.GetSegnalazioneRecensione();
                ((IClientChannel)clientAmministratore).Close();
                myChannelFactory.Close();
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                //doNothing
            }
            return segn;
        }

        public SegnalazioneLibro GetSegnalazioneLibro()
        {
            SegnalazioneLibro segn = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IAmministratore> myChannelFactory = new ChannelFactory<IAmministratore>(myBinding, myEndpoint);
                // Create a channel.
                IAmministratore clientAmministratore = myChannelFactory.CreateChannel();
                segn = clientAmministratore.GetSegnalazioneLibro();
                ((IClientChannel)clientAmministratore).Close();
                myChannelFactory.Close();
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                //doNothing
            }
            return segn;
        }
    }
}
