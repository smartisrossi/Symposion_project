using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SymposionGestoreSicurezzaLib
{
    
    [ServiceContract]
    public interface IGestoreSicurezza: ILog
    {
        
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
}
