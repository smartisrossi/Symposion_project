using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using Progetto_Symposion;

namespace SymposionGestoreSicurezzaLib
{
    [ServiceContract]
    public interface ILog
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<string> GetEntryOperazioni(DateTime dateTime);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<string> GetEntryOperazioniInterval(DateTime dateTimeStart, DateTime dateTimeStop);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<string> GetEntryAccessi(DateTime dateTime);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<string> GetEntryAccessiInterval(DateTime dateTimeStart, DateTime dateTimeStop);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void PrintLogAccessi(Entry[] entries);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void PrintLogOperazioni(EntryOperazione[] entries);
    }
}
