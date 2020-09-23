using Progetto_Symposion;
using SymposionClient.ServiceReferenceBroker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SymposionClient 
{
    class Program
    {
        static void Main(string[] args)
        {
            BrokerClient client = new BrokerClient();

            client.GestisciIscrizione("ale", "alessandro", "alessandrornielli@gmail.com", "utente");
            Console.ReadLine();

            client.Close();

            //    //try
            //    //{
            //    BasicHttpBinding myBinding = new BasicHttpBinding();
            //        myBinding.MaxReceivedMessageSize = 2147483647;
            //        myBinding.MaxBufferSize = 2147483647;
            //        EndpointAddress myEndpoint = new EndpointAddress("http://localhost:8000/SymposionUtente/UtenteService/");


            //        ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);

            //        // Create a channel.
            //        IUtente client = myChannelFactory.CreateChannel();


            /*DownloadRequest requestData = new DownloadRequest();

            RemoteFileInfo fileInfo = new RemoteFileInfo();
            requestData.FileName = "PC-Wallpaper-Hello-Spring.jpg";

            try
            {
                fileInfo = client.DownloadFile(requestData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

            string pathNew = @"C:\Users\mmart\Desktop\Download\PC-Wallpaper-Hello-Spring.jpg";
            int numBytesToRead = (int)fileInfo.Length;
            byte[] bytes = new byte[numBytesToRead + 1];
            int bytesRead = 0;

            while (numBytesToRead > 0)
            {
                // Read may return anything from 0 to numBytesToRead.
                int n = fileInfo.FileByteStream.Read(bytes, bytesRead, bytes.Length);

                // Break when the end of the file is reached.
                if (n == 0)
                    break;

                bytesRead += n;
                numBytesToRead -= n;
            }
            numBytesToRead = bytes.Length;

            // Write the byte array to the other FileStream.
            using (FileStream fsNew = new FileStream(pathNew,
                FileMode.Create, FileAccess.Write))
            {
                fsNew.Write(bytes, 0, numBytesToRead);
            }*/

            //    //    genere gen = genere.Fantasy;
            //    //    Libro libro = new Libro
            //    //    {
            //    //        Titolo = "Hobbit",
            //    //        Autore = "Tolkien",
            //    //        Anno = 1970,
            //    //        Gen = gen
            //    //    };

            //    //    Recensione recOld = new Recensione();
            //    //    recOld.Libro = libro;
            //    //    recOld.Punteggio = 4;
            //    //    recOld.Username = "marti";
            //    //    recOld.Commento = "bello";
            //    //    recOld.Id = 2;

            //    //    SegnalazioneLibro segnalazione = new SegnalazioneLibro();
            //    //    segnalazione.Libro = libro;
            //    //    segnalazione.Username = "gio";


            //    //    //Lista[] rec = client.CercaLista("estate");
            //    //    //foreach (Lista l in rec)
            //    //    //{
            //    //    //    Console.WriteLine(l.Username + " " + l.Gen.ToString());
            //    //    //    foreach (Libro lib in l.ListaLibri)
            //    //    //        Console.WriteLine(lib.Titolo + " " + lib.Autore);
            //    //    //}
            //    //    //Libro[] listaLibri = client.CercaGenere("Romanzo");
            //    //    //foreach (Libro lib in listaLibri)
            //    //    //    Console.WriteLine(lib.Titolo + " " + lib.Autore);
            //    //    //string username = client.CercaUtente("andre");
            //    //    //if (username == null)
            //    //    //    Console.WriteLine("Utente non esistente");
            //    //    //else
            //    //    //    Console.WriteLine(username);
            //    //    Libro libro3 = new Libro(){
            //    //        Titolo = "Orgoglio e Pregiudizio",
            //    //        Autore = "Jane Austen",
            //    //        Anno = 1813,
            //    //        Gen = genere.Romanzo
            //    //    };

            //    //    Libro libro2 = new Libro(){
            //    //        Titolo = "Blart",
            //    //        Autore = "Barker",
            //    //        Anno = 2002,
            //    //        Gen = genere.Fantasy
            //    //    };

            //    //    Recensione rec3 = new Recensione(){
            //    //        Punteggio = 5,
            //    //        Libro = libro3,
            //    //        Commento = "Amo questo libro, da leggere assolutamente!",
            //    //        Username = "marti"
            //    //    };
            //    //    rec3.Username = "marti";
            //    //    rec3.Id = 4;
            //    //    Lista lista2 = new Lista(){
            //    //        Nome = "estate al mare",
            //    //        Gen = genere.Avventura,
            //    //        IsVisibile = false,
            //    //        Username = "leti",
            //    //        ListaLibri = new Libro[3]
            //    //    };
            //    //    lista2.ListaLibri[0] = libro;
            //    //    lista2.ListaLibri[1] = libro3;
            //    //    lista2.ListaLibri[2] = libro2;



            //    //    //client.InserisciLibroCover("Harry Potter e la pietra filosofale", "J. K. Rowling", 1998, "Fantasy", "Harry-potter-e-la-pietra-filosofale-copertina-originale.jpg", "marti");




            //    ////UPLOAD FILE
            //    //System.IO.FileInfo fileInfo = new System.IO.FileInfo("C:\\Users\\mmart\\Desktop\\Harry-potter-e-la-pietra-filosofale-copertina-originale.jpg");

            //    //RemoteFileInfo uploadRequestInfo = new RemoteFileInfo();

            //    //using (System.IO.FileStream stream =
            //    //       new System.IO.FileStream("C:\\Users\\mmart\\Desktop\\Harry-potter-e-la-pietra-filosofale-copertina-originale.jpg",
            //    //       System.IO.FileMode.Open, System.IO.FileAccess.Read))
            //    //{
            //    //    uploadRequestInfo.FileName = "Harry-potter-e-la-pietra-filosofale-copertina-originale.jpg";
            //    //    uploadRequestInfo.Length = fileInfo.Length;
            //    //    uploadRequestInfo.FileByteStream = stream;
            //    //    client.UploadFile(uploadRequestInfo);
            //    //    //clientUpload.UploadFile(stream);
            //    //}

            //    //    //Lista[] listeCreate = client.GetListeSalvate("marti");
            //    //    //foreach (Lista l in listeCreate) {
            //    //    //    Console.WriteLine(l.Nome + " " + l.Gen.ToString());
            //    //    //    foreach (Libro lib in l.ListaLibri)
            //    //    //        Console.WriteLine(lib.Titolo + " " + lib.Autore);
            //    //    //}

            //    //    Recensione[] recensioniScritte = client.GetRecensioniSalvate("marti");
            //    //    foreach (Recensione l in recensioniScritte)
            //    //    {
            //    //        Console.WriteLine(l.Libro.Titolo+ " " + l.Libro.Autore +" " + l.Punteggio + " " + l.Commento +" " +l.Username);
            //    //    }

            //    Libro[] libri = client.GetClassificaGenere("Fantasy");
            //        foreach (Libro l in libri)
            //            Console.WriteLine(l.Titolo + " " + l.Autore);

            //        Console.WriteLine("Fine!");
            //        ((IClientChannel)client).Close();
            //        Console.ReadLine();
            ////}
            ////    catch (Exception ex)
            ////    {
            ////        Console.WriteLine(ex.InnerException);

            ////    }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
    
}
