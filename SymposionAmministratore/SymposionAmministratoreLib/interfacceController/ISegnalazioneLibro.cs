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
    [ServiceKnownType(typeof(Libro))]
    [ServiceContract]
    public interface ISegnalazioneLibro
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        Libro GetLibro(string titolo, string autore);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void AggiornaLibro(Libro libro);
    }
}
