using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progetto_Symposion;

namespace SymposionUtenteLib
{
    [ServiceContract]
    [ServiceKnownType(typeof(Recensione))]
    [ServiceKnownType(typeof(Libro))]
    [ServiceKnownType(typeof(Lista))]
    public interface IRicercaPubblica
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Recensione> CercaRecensioniLibro(Libro libro);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Libro> CercaLibro(string titolo);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Lista> CercaLista(string nome);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Libro> CercaGenere(string genere);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        string CercaUtente(string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Lista> CercaListaUtente(string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Recensione> CercaRecensioniUtente(string usernameUtente);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        List<Lista> CercaListaPersonaleUtente(string username);
    }
}
