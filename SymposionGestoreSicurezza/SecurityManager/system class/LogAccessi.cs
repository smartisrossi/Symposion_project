using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SecurityManager
{
    public class LogAccessi
    {
        private string _addr;
        
        public LogAccessi(string addr)
        {
            _addr = addr;
        }

        public string[] GetEntryAccessi(DateTime dt)
        {
            string[] entries = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IGestoreSicurezza> myChannelFactory = new ChannelFactory<IGestoreSicurezza>(myBinding, myEndpoint);
                // Create a channel.
                IGestoreSicurezza clientGestoreSicurezza = myChannelFactory.CreateChannel();
                entries = clientGestoreSicurezza.GetEntryAccessi(dt);
                ((IClientChannel)clientGestoreSicurezza).Close();
                myChannelFactory.Close();
                //System.Windows.Forms.MessageBox.Show(dt.ToString() + " " + entries.Length.ToString());
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                //doNothing
            }
            return entries;
        }

        public string[] GetEntryAccessiInterval(DateTime dt1, DateTime dt2)
        {
            string[] entries = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IGestoreSicurezza> myChannelFactory = new ChannelFactory<IGestoreSicurezza>(myBinding, myEndpoint);
                // Create a channel.
                IGestoreSicurezza clientGestoreSicurezza = myChannelFactory.CreateChannel();
                DateTime fine = new DateTime(dt2.Year, dt2.Month, dt2.Day, 23, 59, 59);
                entries = clientGestoreSicurezza.GetEntryAccessiInterval(dt1, fine);
                ((IClientChannel)clientGestoreSicurezza).Close();
                myChannelFactory.Close();
                //System.Windows.Forms.MessageBox.Show(dt.ToString() + " " + entries.Length.ToString());
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                //doNothing
            }
            return entries;
        }
    }
}
