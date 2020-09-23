using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Progetto_Symposion;

namespace SymposionUtenteLib
{
    [ServiceContract]
    [ServiceKnownType(typeof(SegnalazioneLibro))]
    [ServiceKnownType(typeof(SegnalazioneRecensione))]
    public interface ISegnalazioni
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void AddSegnalazioneLibro(SegnalazioneLibro segnalazioneLibro);


        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void AddSegnalazioneRecensione(SegnalazioneRecensione segnalazioneRecensione);

        
        SegnalazioneLibro GetSegnalazioneLibro();

        
        SegnalazioneRecensione GetSegnalazioneRecensione();
    }
}
