using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Progetto_Symposion
{
    [DataContract]
    [Serializable]
    public class RecensioniPreferite
    {
        private IList<Recensione> _recensioniSalvate;
        private string _username;

        public RecensioniPreferite()
        {

        }

        public RecensioniPreferite(string username)
        {
            if (username == null)
                throw new ArgumentException("Utente nullo");
            Username = username;
            RecensioniSalvate = new List<Recensione> { };
        }

        [DataMember]
        public virtual string Username
        {
            get{ return _username; }
            set { _username = value; }
        }

        [DataMember]
        public virtual IList<Recensione> RecensioniSalvate
        {
            get{return _recensioniSalvate;}
            set { _recensioniSalvate = value; }
        }

        public virtual void AggiungiRecensione(Recensione rec)
        {
            _recensioniSalvate.Add(rec);
        }

        public virtual void RimuoviRecensione(Recensione rec)
        {
            _recensioniSalvate.Remove(rec);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Recensioni salvate: \n");
            foreach (Recensione recensione in _recensioniSalvate)
                builder.AppendLine(recensione.ToString());
            return builder.ToString();
        }
    }
}
