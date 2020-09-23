using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Symposion
{
    [Serializable]
    public class EntryOperazione : Entry
    {
        private string _tipoOperazione;

        public EntryOperazione(string luogo, string username, string tipoOperazione) : base(luogo, username)
        {
            if (String.IsNullOrEmpty(tipoOperazione))
                throw new ArgumentException("Tipo Operazione nullo");
            _tipoOperazione = tipoOperazione;
        }

        public string TipoOperazione
        {
            get{ return _tipoOperazione; }
            set { _tipoOperazione = value; }
        }


        public override string GetEntry()
        {
            //formato: DataOra Luogo Username Operazione
            return base.GetEntry() + " " + TipoOperazione;
        }
    }
}
