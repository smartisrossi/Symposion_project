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
    public class ListePreferite
    {
        private IList<Lista> _listeSalvate;
        private string _username;

        public ListePreferite()
        {

        }
        public ListePreferite(string username)
        {
            if (username == null)
                throw new ArgumentException("Utente nullo");
            Username = username;
            ListeSalvate = new List<Lista>();
        }

        [DataMember]
        public virtual IList<Lista> ListeSalvate
        {
            get {return _listeSalvate;}
            set { _listeSalvate = value; }
        }

        [DataMember]
        public virtual string Username
        {
            get{ return _username; }
            set { _username = value; }
        }


        public virtual void AggiungiLista(Lista list)
        {
            _listeSalvate.Add(list);
        }

        public virtual void RimuoviLista(Lista list)
        {
            _listeSalvate.Remove(list);
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach(Lista lista in this.ListeSalvate)
            {
                sb.Append(lista.ToString());
            }
            return sb.ToString();
        }
    }
}
