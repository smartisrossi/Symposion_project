using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymposionBrokerLib
{
    interface IIscrizione
    {
        void RegistraDati(string username, string password, string email);
    }
}
