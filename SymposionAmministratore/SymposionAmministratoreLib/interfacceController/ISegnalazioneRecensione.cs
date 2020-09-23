using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Progetto_Symposion;

namespace SymposionAmministratoreLib
{
    [ServiceKnownType(typeof(SegnalazioneLibro))]
    [ServiceKnownType(typeof(SegnalazioneRecensione))]
    [ServiceKnownType(typeof(Recensione))]
    [ServiceKnownType(typeof(Libro))]
    [ServiceContract]
    public interface ISegnalazioneRecensione
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        Recensione GetRecensione(int id);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void InviaNotificaUtente(string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void EliminaRecensione(Recensione recensione);
    }
}
