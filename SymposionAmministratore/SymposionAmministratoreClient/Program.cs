using Progetto_Symposion;
using SymposionAmministratoreClient.ServiceReferenceBroker;
using SymposionAmministratoreLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;

namespace SymposionAmministratoreClient
{
    class Program
    {
        static void Main(string[] args)
        {

            /*BrokerClient client = new BrokerClient();
            string host = null;


            try
            {
                Console.WriteLine("Richiesta inviata");
                host = client.GestisciLogin("marti", "marti", "amministratore");
                if (host == null)
                    Console.WriteLine("login scorretto");
                else
                    Console.WriteLine(host);
            }
            catch (FaultException<AccessFault> e)
            {
                Console.WriteLine(e.Detail.Message);
            }

            Console.ReadLine();

            client.Close();

            try
            {
                if (host != null)
                {
                    BasicHttpBinding myBinding = new BasicHttpBinding();

                    EndpointAddress myEndpoint = new EndpointAddress(host);

                    ChannelFactory<IAmministratore> myChannelFactory = new ChannelFactory<IAmministratore>(myBinding, myEndpoint);

                    // Create a channel.
                    IAmministratore clientAmministratore = myChannelFactory.CreateChannel();
                    genere gen = genere.Fantasy;
                    Libro libro = new Libro();
                    libro.Titolo = "Harry Potter";
                    libro.Autore = "J. K. Rowling";
                    libro.Anno = 2000;
                    libro.Gen = gen;
            
                    Utente user = new Utente();
                    user.Username = "marti";
                    user.ListeCreate = new Lista[1];
                    user.ListePreferite = new ListePreferite();
                    user.RecensioniPreferite = new RecensioniPreferite();
                    user.RecensioniScritte = new Recensione[1];

                    Recensione recOld = new Recensione();
                    recOld.Libro = libro;
                    recOld.Punteggio = 4;
                    recOld.Utente = user;
                    recOld.Commento = "bello";

                    SegnalazioneRecensione segnalazione = new SegnalazioneRecensione();
                    segnalazione.Review = recOld;
                    segnalazione.User = user;
                   
                    try
                    {
                        clientAmministratore.EliminaRecensione(recOld);
                        Console.WriteLine("Recensione eliminata");
                    }
                    catch (FaultException<BookFault> e)
                    {
                        Console.WriteLine(e.Detail.Message);
                    }
                    ((IClientChannel)clientAmministratore).Close();
                    Console.ReadLine();
                }
            }
            catch (FaultException<BookFault> e)
            {
                Console.WriteLine(e.Detail.Message);
            }
            */
            /*
            Recensione rec1 = new Recensione();
            genere gen = genere.Fantasy;
            Libro libro1 = new Libro();
            libro1.Titolo = "Harry Potter";
            libro1.Autore = "J. K. Rowling";
            libro1.Anno = 2000;
            libro1.Gen = gen;

            Utente user = new Utente();
            user.Username = "marti";
            user.ListeCreate = new Lista[1];
            user.ListePreferite = new ListePreferite();
            user.RecensioniPreferite = new RecensioniPreferite();
            user.RecensioniScritte = new Recensione[1];

            rec1.Libro = libro1;
            rec1.Punteggio = 4;
            rec1.Utente = user;
            rec1.Commento = "bello";

            Libro libro2 = new Libro();
            libro2.Titolo = "Il codice Da Vinci";
            libro2.Autore = "Dan Brown";
            libro2.Anno = 2000;
            libro2.Gen = gen;

            Recensione rec2 = new Recensione();
            rec2.Libro = libro2;
            rec2.Punteggio = 3;
            rec2.Utente = user;
            rec2.Commento = "intrigante";

            genere gen1 = genere.Romanzo;
            Libro libro3 = new Libro();
            libro3.Titolo = "Ascolta il mio cuore";
            libro3.Autore = "Bianca Pitzorno";
            libro3.Anno = 1998;
            libro3.Gen = gen1;

            Recensione rec3 = new Recensione();
            rec3.Libro = libro3;
            rec3.Punteggio = 5;
            rec3.Utente = user;
            rec3.Commento = "lo amo";

            DateTime d1 = new DateTime(2018, 6, 18);
            DateTime d2 = new DateTime(2018, 6, 19);
            DateTime d3 = new DateTime(2018, 6, 20);

            Dictionary<DateTime, LocalType.Recensione> recensioniSegnalate = new Dictionary<DateTime, LocalType.Recensione>();
            recensioniSegnalate.Add(d1, new LocalType.Recensione(rec1.Punteggio, new LocalType.Libro(rec1.Libro.Titolo, rec1.Libro.Autore, rec1.Libro.Anno, rec1.Libro.Gen.ToString()), rec1.Commento, new LocalType.Utente(rec1.Utente.Username)));
            recensioniSegnalate.Add(d2, new LocalType.Recensione(rec2.Punteggio, new LocalType.Libro(rec2.Libro.Titolo, rec2.Libro.Autore, rec2.Libro.Anno, rec2.Libro.Gen.ToString()), rec2.Commento, new LocalType.Utente(rec2.Utente.Username)));
            recensioniSegnalate.Add(d3, new LocalType.Recensione(rec3.Punteggio, new LocalType.Libro(rec3.Libro.Titolo, rec3.Libro.Autore, rec3.Libro.Anno, rec3.Libro.Gen.ToString()), rec3.Commento, new LocalType.Utente(rec3.Utente.Username)));
            //Serialize(recensioniSegnalate);

            Dictionary<DateTime, LocalType.Recensione> recensioniEstratte = Deserialize();
            DateTime now = DateTime.Now;
            TimeSpan twoDays = new TimeSpan(2, 0, 0, 0);
            DateTime targetDate = now.Subtract(twoDays);
            Dictionary<DateTime, LocalType.Recensione> recensioniInAttesa = new Dictionary<DateTime, LocalType.Recensione>();
            if (recensioniEstratte != null)
            {
                foreach(DateTime date in recensioniEstratte.Keys)
                {
                    if (DateTime.Compare(date, targetDate) <= 0)
                    {
                        Console.WriteLine("Da controllare: " + date.ToString() + " " + recensioniEstratte[date].ToString());
                    }
                    else{
                        recensioniInAttesa.Add(date, recensioniEstratte[date]);
                    }
                }
                Serialize(recensioniInAttesa);
            }*/
            try
            {
                string host = "http://localhost:8003/SymposionAmministratore/AmministratoreService/";
                if (host != null)
                {
                    BasicHttpBinding myBinding = new BasicHttpBinding();
                    myBinding.MaxReceivedMessageSize = 2147483647;
                    myBinding.MaxBufferSize = 2147483647;
                    TimeSpan time = new TimeSpan(0, 10, 0);
                    myBinding.ReceiveTimeout = time;
                    myBinding.SendTimeout = time;


                    EndpointAddress myEndpoint = new EndpointAddress(host);

                    ChannelFactory<IAmministratore> myChannelFactory = new ChannelFactory<IAmministratore>(myBinding, myEndpoint);

                    // Create a channel.
                    IAmministratore clientAmministratore = myChannelFactory.CreateChannel();

                    try
                    {
                        Libro libroOld = new Libro
                        {
                            Titolo = "Hobbit",
                            Autore = "Tolkien",
                            Anno = 1971,
                            Gen = genere.Fantasy
                        };

                        Libro libroNew = new Libro
                        {
                            Titolo = "Hobbit",
                            Autore = "Tolkien",
                            Anno = 1970,
                            Gen = genere.Fantasy
                        };

                        SegnalazioneRecensione rec = clientAmministratore.GetSegnalazioneRecensione();
                        Console.WriteLine(rec.Recensione.Libro.Titolo);
                        //Libro libro = clientAmministratore.GetLibro("Hobbit", "Tolkien");
                        //Console.WriteLine(libro.Titolo);
                        //Recensione rec = clientAmministratore.GetRecensione(1);
                        //Console.WriteLine(rec.Libro.Titolo);
                    }
                    catch (FaultException<BookFault> e)
                    {
                        Console.WriteLine(e.Detail.Message);
                    }
                    ((IClientChannel)clientAmministratore).Close();
                    Console.ReadLine();
                }
            }
            catch (FaultException<BookFault> e)
            {
                Console.WriteLine(e.Detail.Message);
            }
            Console.ReadLine();
        }

        /*
        private static void Serialize(Dictionary<DateTime, LocalType.Recensione> target)
        {
            FileStream fs = new FileStream("C:\\Users\\mmart\\Desktop\\scadenza\\recensioni.dat", FileMode.Create);

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


        private static Dictionary<DateTime, LocalType.Recensione> Deserialize()
        {
            // Declare the dictionary reference.
            Dictionary<DateTime, LocalType.Recensione> recensioni = null;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream("C:\\Users\\mmart\\Desktop\\scadenza\\recensioni.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and 
                // assign the reference to the local variable.
                recensioni = (Dictionary<DateTime, LocalType.Recensione>)formatter.Deserialize(fs);
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
        }*/
    }
}
