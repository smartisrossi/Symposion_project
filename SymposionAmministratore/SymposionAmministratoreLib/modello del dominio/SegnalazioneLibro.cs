using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Progetto_Symposion
{
    [DataContract]
    [Serializable]
    public class SegnalazioneLibro
    {
        private Libro _libro;
        private string _username;
        private int _id;

        public SegnalazioneLibro()
        {

        }

        public SegnalazioneLibro(string username, Libro libro)
        {
            if (username == null)
                throw new ArgumentException("Utente nullo");
            if (libro == null)
                throw new ArgumentException("Libro nullo");

            Username = username;
            Libro = libro;
            Id = 1;
        }

        [DataMember]
        public virtual Libro Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }

        [DataMember]
        public virtual string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        [DataMember]
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string ToString()
        {
            return "Utente: " + Username + ".Dettagli del libro segnalato\n" + Libro.ToString() + "\n";
        }
    }
}
