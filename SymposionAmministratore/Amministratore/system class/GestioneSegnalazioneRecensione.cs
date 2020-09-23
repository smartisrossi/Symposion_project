using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progetto_Symposion;

namespace Amministratore
{
    public class GestioneSegnalazioneRecensione
    {
        private string _addr;
        private static string _pathRecensioniScadute = "C:\\Users\\mmart\\Desktop\\scadenza\\recensioni.dat";

        public GestioneSegnalazioneRecensione(string addr)
        {
            _addr = addr;
        }

        public Recensione GetRecensione(int id)
        {
            Recensione rec = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IAmministratore> myChannelFactory = new ChannelFactory<IAmministratore>(myBinding, myEndpoint);
                // Create a channel.
                IAmministratore clientAmministratore = myChannelFactory.CreateChannel();
                rec = clientAmministratore.GetRecensione(id);
                ((IClientChannel)clientAmministratore).Close();
                myChannelFactory.Close();
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                //doNothing
            }
            return rec;
        } 
        public void InviaNotifica(string username, int id)
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IAmministratore> myChannelFactory = new ChannelFactory<IAmministratore>(myBinding, myEndpoint);
                // Create a channel.
                IAmministratore clientAmministratore = myChannelFactory.CreateChannel();
                clientAmministratore.InviaNotificaUtente(username);
                ((IClientChannel)clientAmministratore).Close();
                myChannelFactory.Close();
                DateTime now = DateTime.Now;
                Dictionary<DateTime, int> recensioniEstratte;
                if (File.Exists(_pathRecensioniScadute))
                    recensioniEstratte = Deserialize();
                else
                    recensioniEstratte = new Dictionary<DateTime, int>();
                recensioniEstratte.Add(now, id);
                Serialize(recensioniEstratte);
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                //doNothing
            }
        }

        public void EliminaRecensione(Recensione recensione)
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IAmministratore> myChannelFactory = new ChannelFactory<IAmministratore>(myBinding, myEndpoint);
                // Create a channel.
                IAmministratore clientAmministratore = myChannelFactory.CreateChannel();
                clientAmministratore.EliminaRecensione(recensione);
                ((IClientChannel)clientAmministratore).Close();
                myChannelFactory.Close();
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.Message);
                //doNothing
            }
        }

        private static void Serialize(Dictionary<DateTime, int> target)
        {
            FileStream fs = new FileStream(_pathRecensioniScadute, FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, target);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        private static Dictionary<DateTime, int> Deserialize()
        {
            // Declare the dictionary reference.
            Dictionary<DateTime, int> recensioni = null;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream("C:\\Users\\mmart\\Desktop\\scadenza\\recensioni.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and 
                // assign the reference to the local variable.
                recensioni = (Dictionary<DateTime, int>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            return recensioni;
        }
    }
}
