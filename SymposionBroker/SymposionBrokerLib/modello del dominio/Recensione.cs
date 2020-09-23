using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Symposion
{
    [DataContract]
    [Serializable]
    public class Recensione
    {
        private Libro _libro;
        private int _punteggio;
        private string _commento;
        private string _username;
        private int _id;

        public Recensione()
        {

        }

        public Recensione(int? punteggio, Libro libro, string username)
        {
            if (punteggio == null)
                throw new ArgumentException("Punteggio nullo");
            if (libro == null)
                throw new ArgumentException("Libro nullo");
            if (username == null)
                throw new ArgumentException("Utente nullo");
            Username = username;
            Punteggio = (int)punteggio;
            Commento = null;
            Libro = libro;
            Id = 1;
        }

        public Recensione(int? punteggio, Libro libro, string commento, string username)
        {
            if (punteggio == null)
                throw new ArgumentException("Punteggio nullo");
            if (libro == null)
                throw new ArgumentException("Libro nullo");
            if (String.IsNullOrEmpty(commento))
                 throw new ArgumentException("Commento nullo");
            if (username == null)
                throw new ArgumentException("Utente nullo");
            Username = _username;
            Punteggio =(int)punteggio;
            Libro = libro;
            Commento = commento;
            Id = 1;
        }

        [DataMember]
        public virtual int Punteggio
        {
            get { return _punteggio; }
            set { _punteggio = value; }
        }

        [DataMember]
        public virtual string Commento
        {
            get { return _commento; }
            set { _commento = value; }
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
            get{ return _username; }
            set { _username = value; }
        }

        [DataMember]
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual void ModificaRecensione(int? punteggio, string commento)
        {
            if (punteggio != null)
                _punteggio = (int) punteggio;
            if (commento != null)
                _commento = commento;
        }

       
        public override string ToString()
        {
            return  "Libro recensito: " + Libro + "\n" +
                    "Punteggio attribuito alla recensione: " + Punteggio + "\n" +
                    "Commento: " + Commento + "\n";
        }

        public virtual int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            if (obj.GetType() != GetType())
                throw new ArgumentException();
            Recensione recensione = (Recensione)obj;

            if (recensione.Libro.Equals(_libro) &&
                recensione.Punteggio == _punteggio &&
                recensione.Commento.Equals(_commento))
                return 0;
            else
                return (_punteggio.CompareTo(recensione.Punteggio));
        }

        public class Comparer : IComparer
        {
            private readonly bool _up;

            public Comparer(bool up = true)
            {
                _up = up;
            }

            public virtual int Compare(object obj1, object obj2)
            {
                if (obj1 != null && !(obj1 is Recensione))
                    throw new ArgumentException();
                if (obj2 != null && !(obj2 is Recensione))
                    throw new ArgumentException();
                int retCode;
                if (obj1 == obj2)
                    retCode = 0;
                else if (obj1 == null)
                    retCode = -1;
                else if (obj2 == null)
                    retCode = 1;
                else
                    retCode = ((Recensione)obj1).CompareTo(obj2);
                return (_up ? retCode : -retCode);
            }
        }
    }
}
