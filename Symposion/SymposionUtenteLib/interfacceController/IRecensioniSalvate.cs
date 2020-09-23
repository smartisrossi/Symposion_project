using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Progetto_Symposion;

namespace SymposionUtenteLib
{
    [ServiceContract]
    [ServiceKnownType(typeof(Recensione))]
    public interface IRecensioniSalvate
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void SalvaRecensione(Recensione recensione, string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void RimuoviRecensione(Recensione recensione, string username);
    }
}
