using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ServiceModel;

namespace SymposionUtenteLib
{
    [ServiceContract]
    public interface IInserimentoLibro
    {
        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void InserisciLibroCover(string titolo, string autore, int? anno, string gen, string cover, string username);

        [OperationContract]
        [FaultContract(typeof(BookFault))]
        void InserisciLibro(string titolo, string autore, int? anno, string gen, string username);

    }
}
