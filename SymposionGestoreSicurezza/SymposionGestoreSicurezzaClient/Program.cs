using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progetto_Symposion;
using SymposionGestoreSicurezzaClient.ServiceReferenceBroker;
using SymposionGestoreSicurezzaLib;

namespace SymposionGestoreSicurezzaClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BrokerClient client = new BrokerClient();
            string host = null;


            try
            {
                Console.WriteLine("Richiesta inviata");
                host = client.GestisciLogin("gestoreMarco", "gestoreMarco", "gestoreSicurezza");
                Console.WriteLine(host);
            }
            catch(FaultException<AccessFault> e)
            {
                Console.WriteLine(e.Detail.Message);
            }

            Console.ReadLine();

            client.Close();


            EntryOperazione e1 = new EntryOperazione
            {
                DataOra = DateTime.Now,
                Username = "Fede",
                Luogo = "Bologna",
                TipoOperazione = "salvataggio lista personale"
            };
            EntryOperazione e2 = new EntryOperazione
            {
                DataOra = DateTime.Now,
                Username = "Maria",
                Luogo = "Bologna",
                TipoOperazione = "creazione lista personale"
            };
            EntryOperazione[] entries = new EntryOperazione[2];
            entries[0] = e1;
            entries[1] = e2;
            
            try
            {
                if (host != null)
                {
                   
                    DateTime dateTimeStart = new DateTime(2018, 6, 17);
                    DateTime dateTimeStop = new DateTime(2018, 6, 18);

                    BasicHttpBinding myBinding = new BasicHttpBinding();

                    EndpointAddress myEndpoint = new EndpointAddress(host);

                    ChannelFactory<IGestoreSicurezza> myChannelFactory = new ChannelFactory<IGestoreSicurezza>(myBinding, myEndpoint);

                    // Create a channel.
                    IGestoreSicurezza clientGestoreSicurezza = myChannelFactory.CreateChannel();

                    //clientGestoreSicurezza.PrintLogOperazioni(entries);
                    //Console.WriteLine("scrittura log avvenuta con successo!");

                    List<string> operazioni = clientGestoreSicurezza.GetEntryOperazioni(dateTimeStart).OfType<string>().ToList();
                    foreach (string op in operazioni)
                        Console.WriteLine(op);

                    ((IClientChannel)clientGestoreSicurezza).Close();
                    Console.ReadLine();
                }
            }
            catch (FaultException<BookFault> e)
            {
                Console.WriteLine(e.Detail.Message);
            }
        }
    }
}
