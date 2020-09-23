using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amministratore
{
    public class Configurazioni
    {
        public string GetVersionSO()
        {
            return "Symposion/v. 1.0";
        }

        public string GetStato()
        {
            return "Active";
        }

        public List<string> GetElencoAggiornamenti()
        {
            return null;
        }

        public void InstallaAggiornamento()
        {

        }
    }
}
