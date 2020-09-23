using System;
using System.Collections.Generic;
using System.Linq;
using Progetto_Symposion;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SymposionUtenteLib
{
    [ServiceContract]
    [ServiceKnownType(typeof(Recensione))]
    [ServiceKnownType(typeof(Libro))]
    public interface IRecensione
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void PubblicaRecensione(int? punteggio, string commento, Libro libro, string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void ModificaRecensione(Recensione recensione);
    }
}
