using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SymposionUtenteLib
{
    [ServiceContract]
    [ServiceKnownType(typeof(DownloadRequest))]
    [ServiceKnownType(typeof(RemoteFileInfo))]
    public interface IUtente : IGestisciUtente, IRecensione, IListePersonali, IListeSalvate, IRecensioniSalvate, ISegnalazioni, IInserimentoLibro, IRicercaPubblica, IClassifica
    {
        [OperationContract]
        RemoteFileInfo DownloadFile(DownloadRequest request);

        [OperationContract]
        void UploadFile(RemoteFileInfo request);
    }

    [DataContract]
    public class BookFault
    {
        private string report;

        public BookFault(string message)
        {
            this.report = message;
        }

        [DataMember]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }
    }

    [MessageContract]
    public class DownloadRequest
    {
        [MessageBodyMember]
        public string FileName;
    }

    [MessageContract]
    public class RemoteFileInfo : IDisposable
    {
        [MessageHeader(MustUnderstand = true)]
        public string FileName;

        [MessageHeader(MustUnderstand = true)]
        public long Length;

        [MessageBodyMember(Order = 1)]
        public System.IO.Stream FileByteStream;

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }
    }
}
