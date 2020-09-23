using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto_Symposion;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SymposionUtenteLib
{
    [ServiceContract]
    [ServiceKnownType(typeof(Lista))]
    public interface IListeSalvate
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void SalvaLista(Lista lista, string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void RimuoviLista(Lista lista, string username);
    }
}
