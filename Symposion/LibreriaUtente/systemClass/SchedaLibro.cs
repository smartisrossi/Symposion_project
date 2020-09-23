using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class SchedaLibro
    {
        private Libro _libro;
        private string _addr;
        private string _username;

        public SchedaLibro(Libro libro, string addr, string username)
        {
            _libro = libro;
            _addr = addr;
            _username = username;
        }

        public Libro Libro
        {
            get
            {
                return _libro;
            }
            set
            {
                _libro = value;
            }
        }

        public List<Recensione> GetRecensioni()
        {
            List<Recensione> listaRecensioni = null;
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                listaRecensioni = client.CercaRecensioniLibro(_libro).ToList<Recensione>();
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }

            return listaRecensioni;
        }

        public void PubblicaRecensione(int punteggio, string commento)
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                client.PubblicaRecensione(punteggio, commento, _libro, _username);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }
        public void PubblicaRecensione(int punteggio)
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                client.PubblicaRecensione(punteggio, null, _libro, _username);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }

        public void SegnalaLibro(Libro libro)
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                SegnalazioneLibro segn = new SegnalazioneLibro()
                {
                    Username = _username,
                    Libro = _libro,
                    Id = 1
                };
                client.AddSegnalazioneLibro(segn);
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }

        public void DownloadCopertina()
        {
            try
            {
                BasicHttpBinding myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 2147483647;
                myBinding.MaxBufferSize = 2147483647;
                EndpointAddress myEndpoint = new EndpointAddress(_addr);
                ChannelFactory<IUtente> myChannelFactory = new ChannelFactory<IUtente>(myBinding, myEndpoint);
                // Create a channel.
                IUtente client = myChannelFactory.CreateChannel();
                DownloadRequest requestData = new DownloadRequest();

                RemoteFileInfo fileInfo = new RemoteFileInfo();
                requestData.FileName = _libro.FilePath;

                try
                {
                    fileInfo = client.DownloadFile(requestData);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();

                string pathNew = @"C:\Users\mmart\Desktop\Download\" + _libro.FilePath;
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
                using (FileStream fsNew = new FileStream(pathNew, FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(bytes, 0, numBytesToRead);
                }
                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }
    }
}
