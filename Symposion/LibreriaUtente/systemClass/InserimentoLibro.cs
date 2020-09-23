using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class InserimentoLibro
    {
        private string _addr;
        private string _username;

        public InserimentoLibro(string addr, string username)
        {
            _addr = addr;
            _username = username;
        }

        public void InserisciLibro(string titolo, string autore, int? anno, string genereString, string filePath)
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
                string[] elements = filePath.Split('\\');
                string fileName = elements[elements.Length - 1];
                client.InserisciLibroCover(titolo, autore, anno, genereString, fileName, _username);

                //try
                //{
                //    //UPLOAD FILE
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

                    RemoteFileInfo uploadRequestInfo = new RemoteFileInfo();

                    using (System.IO.FileStream stream =
                           new System.IO.FileStream(filePath,
                           System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        uploadRequestInfo.FileName = fileName;
                        uploadRequestInfo.Length = fileInfo.Length;
                        uploadRequestInfo.FileByteStream = stream;
                    }
                    client.UploadFile(uploadRequestInfo);
                //}
                //catch (Exception)
                //{

                //}
                    ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
        }

        public void InserisciLibro(string titolo, string autore, int? anno, string genereString)
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
                client.InserisciLibro(titolo, autore, anno, genereString, _username);

                ((IClientChannel)client).Close();
            }
            catch (Exception)
            {
                //doNothing
            }
            
        }
    }
}
