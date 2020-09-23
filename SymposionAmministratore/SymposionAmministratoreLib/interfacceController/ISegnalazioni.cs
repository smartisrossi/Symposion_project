using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Progetto_Symposion;

namespace SymposionAmministratoreLib
{
    
    [ServiceContract]
    public interface ISegnalazioni
    {
        void AddSegnalazioneLibro(SegnalazioneLibro segnalazioneLibro);

        void AddSegnalazioneRecensione(SegnalazioneRecensione segnalazioneRecensione);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        [ServiceKnownType(typeof(SegnalazioneLibro))]
        [ServiceKnownType(typeof(Libro))]
        SegnalazioneLibro GetSegnalazioneLibro();

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        [ServiceKnownType(typeof(SegnalazioneRecensione))]
        [ServiceKnownType(typeof(Recensione))]
        [ServiceKnownType(typeof(Libro))]
        SegnalazioneRecensione GetSegnalazioneRecensione();
    }
}
