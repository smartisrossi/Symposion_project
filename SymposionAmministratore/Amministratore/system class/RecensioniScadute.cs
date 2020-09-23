using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Amministratore
{
    public class RecensioniScadute
    {
        private string _addr;
        private static string _pathRecensioniScadute = "C:\\Users\\mmart\\Desktop\\scadenza\\recensioni.dat";

        public RecensioniScadute(string addr)
        {
            _addr = addr;
        }

        public Dictionary<DateTime, int> GetListaRecensioni()
        {
            Dictionary<DateTime, int> recensioniScadute = new Dictionary<DateTime, int>();
            if (File.Exists(_pathRecensioniScadute))
            {
                Dictionary<DateTime, int> recensioniEstratte = Deserialize();
                DateTime now = DateTime.Now;
                TimeSpan twoDays = new TimeSpan(2, 0, 0, 0);
                DateTime targetDate = now.Subtract(twoDays);
                Dictionary<DateTime, int> recensioniInAttesa = new Dictionary<DateTime, int>();
                if (recensioniEstratte != null)
                {
                    foreach (DateTime date in recensioniEstratte.Keys)
                    {
                        /*if (DateTime.Compare(date, targetDate) <= 0)
                        {
                            recensioniScadute.Add(date, recensioniEstratte[date]);
                        }
                        else
                        {
                            recensioniInAttesa.Add(date, recensioniEstratte[date]);
                        }*/
                        recensioniScadute.Add(date, recensioniEstratte[date]);
                    }
                    Serialize(recensioniInAttesa);
                }
            }
            return recensioniScadute;
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
