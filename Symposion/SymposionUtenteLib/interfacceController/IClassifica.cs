using System;
using System.Collections.Generic;
using System.ServiceModel;
using Progetto_Symposion;

namespace SymposionUtenteLib
{
    [ServiceContract]
    [ServiceKnownType(typeof(Libro))]
    public interface IClassifica
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Libro> GetClassificaGenere(string gen);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Libro> GetClassificaAnno(int date);
    }
}
