using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Symposion
{
    [DataContract]
    [Serializable]
    public class SegnalazioneRecensione
    {
        private string _username;
        private Recensione _review;
        private int _id;

        ////////////

        public SegnalazioneRecensione()
        {

        }
        public SegnalazioneRecensione(string username, Recensione recensione)
        {
            if (username == null)
                throw new ArgumentException("Utente nullo");
            if (recensione == null)
                throw new ArgumentException("Recensione nulla");

            Username = username;
            Recensione = recensione;
            Id = 1;
        }

        ////////////

        [DataMember]
        public virtual string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        [DataMember]
        public virtual Recensione Recensione
        {
            get
            {
                return _review;
            }
            set
            {
                _review = value;
            }
        }

        [DataMember]
        public virtual int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        ////////////

        public override string ToString()
        {
            return Username + "\n" + this.Recensione.ToString();
            
        }
    }
}
