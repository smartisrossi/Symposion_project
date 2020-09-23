using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Symposion
{
    [DataContract]
    [Serializable]
    public class Utente
    {
        private string _username;
        private List<Lista> _listeCreate;
        private List<Recensione> _recensioniScritte;
        private ListePreferite _listePreferite;
        private RecensioniPreferite _recPreferite;

        public Utente()
        {

        }

        public Utente(string username)
        {
            if (String.IsNullOrEmpty(username))
                throw new ArgumentException("Username nullo");
            Username = username;
            ListeCreate = new List<Lista> { };
            ListePreferite = new ListePreferite(username);
            RecensioniScritte = new List<Recensione> { };
            RecensioniPreferite = new RecensioniPreferite(username);
        }

        [DataMember]
        public virtual string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        [DataMember]
        public virtual List<Lista> ListeCreate
        {
            get { return _listeCreate;  }
            set { _listeCreate = value;  }
        }

        [DataMember]
        public virtual ListePreferite ListePreferite
        {
            get { return _listePreferite; }
            set { _listePreferite = value; }
        }

        [DataMember]
        public virtual List<Recensione> RecensioniScritte
        {
            get { return _recensioniScritte; }
            set { _recensioniScritte = value; }
        }

        [DataMember]
        public virtual RecensioniPreferite RecensioniPreferite
        {
            get { return _recPreferite; }
            set { _recPreferite = value; }
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Username: " + _username);
            sb.Append("Liste create: \n");
            foreach (Lista l in _listeCreate)
                sb.Append(l.ToString() + "\n");
            sb.Append("Liste salvate: \n");
            sb.Append(_listePreferite.ToString());
            sb.Append("Recesioni scritte: \n");
            foreach (Recensione r in _recensioniScritte)
                sb.Append(r.ToString() + "\n");
            sb.Append(_recPreferite.ToString());
            return sb.ToString();
        }
    }
}
