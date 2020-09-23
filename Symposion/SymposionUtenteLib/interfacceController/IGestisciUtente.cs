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
    [ServiceKnownType(typeof(Recensione))]
    [ServiceKnownType(typeof(Lista))]
    public interface IGestisciUtente
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Recensione> GetRecensioniScritte(string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Lista> GetListePersonali(string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Recensione> GetRecensioniSalvate(string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Lista> GetListeSalvate(string username);

        void RegisterOperazione(string operazione, string username);
    }
}
