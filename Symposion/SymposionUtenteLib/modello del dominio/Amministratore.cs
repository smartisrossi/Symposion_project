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
    public class Amministratore
    {
        private string _username;
        private CodaSegnalazioneRecensione _codaSegnalazioneRecensione;
        private CodaSegnalazioneLibro _codaSegnalazioneLibro;

        public Amministratore(string username)
        {
            if (String.IsNullOrEmpty(username))
                throw new ArgumentException("Username nullo");
            _username = username;
            _codaSegnalazioneLibro = new CodaSegnalazioneLibro();
            _codaSegnalazioneRecensione = new CodaSegnalazioneRecensione();
        }

        [DataMember]
        public string Username
        {
            get; set;
        }

        [DataMember]
        public CodaSegnalazioneRecensione CodaSegnalazioneRecensione
        {
            get { return _codaSegnalazioneRecensione; }
            set { _codaSegnalazioneRecensione = value; }
        }

        [DataMember]
        public CodaSegnalazioneLibro CodaSegnalazioneLibro
        {
            get { return _codaSegnalazioneLibro; }
            set { _codaSegnalazioneLibro = value; }
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Username: " + _username);

            return sb.ToString();
        }
    }
}
