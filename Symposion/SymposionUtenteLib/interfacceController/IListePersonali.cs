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
    public interface IListePersonali
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void CreaListaPersonale(string nome, string genere, string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void PubblicaListaPersonale(Lista lista);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void ModificaListaPersonale(Lista lista);

    }
}
