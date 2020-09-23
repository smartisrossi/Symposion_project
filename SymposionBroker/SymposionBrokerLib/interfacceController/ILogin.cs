using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymposionBrokerLib
{
    interface ILogin
    {
        string VerificaCredenziali(string username, string password);
    }
}
