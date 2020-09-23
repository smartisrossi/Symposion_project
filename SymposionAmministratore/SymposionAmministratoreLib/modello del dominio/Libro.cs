using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Symposion
{
    [Serializable]
    public enum genere
    {
        Avventura,
        Classici,
        Fantascienza,
        Fantasy,
        Giallo,
        Horror,
        Personale,
        Romanzo,
        Thriller,
        Umorismo,
    }

    [DataContract]
    [Serializable]
    public class Libro : IComparable
    {
        private string _titolo;
        private string _autore;
        private int _anno;
        private genere _gen;
        private string _filePath;

        public Libro()
        {

        }
        public Libro(string titolo, string autore, int? anno, string gen, string filePath)
        {
            DateTime dateNow = new DateTime();
            if (String.IsNullOrEmpty(titolo))
                throw new ArgumentException("Titolo nullo");
            if (String.IsNullOrEmpty(autore))
                throw new ArgumentException("Autore nullo");
            if (String.IsNullOrEmpty(gen))
                throw new ArgumentException("Genere nullo");
            if (String.IsNullOrEmpty(filePath))
                throw new ArgumentException("File nullo");
            if (anno == null)
                throw new ArgumentException("Anno nullo");
            if (anno <= 0 && anno >= dateNow.Year)
                throw new ArgumentException("Anno non possibile");

            if (Enum.TryParse(gen, out _gen))
                if (!Enum.IsDefined(typeof(genere), _gen))
                    throw new ArgumentException("Genere non valido");

            Titolo = titolo;
            Autore = autore;
            Anno = (int) anno;
            FilePath = filePath;
        }

        public Libro(string titolo, string autore, int? anno, string gen)
        {
            DateTime dateNow = new DateTime();
            if (String.IsNullOrEmpty(titolo))
                throw new ArgumentException("Titolo nullo");
            if (String.IsNullOrEmpty(autore))
                throw new ArgumentException("Autore nullo");
            if (String.IsNullOrEmpty(gen))
                throw new ArgumentException("Genere nullo");
            if (anno == null)
                throw new ArgumentException("Anno nullo");
            if (anno <= 0 && anno >= dateNow.Year)
                throw new ArgumentException("Anno non possibile");

            if (Enum.TryParse(gen, out _gen))
                if (!Enum.IsDefined(typeof(genere), _gen))
                    throw new ArgumentException("Genere non valido");

            Titolo = titolo;
            Autore = autore;
            Anno = (int)anno;
            FilePath = null;
        }

        [DataMember]
        public virtual string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        [DataMember]
        public virtual string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

        [DataMember]
        public virtual int Anno
        {
            get { return _anno; }
            set { _anno = value; }
        }

        [DataMember]
        public virtual genere Gen
        {
            get { return _gen; }
            set { _gen = value; }
        }

        [DataMember]
        public virtual string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public override string ToString()
        {
            return "Libro: " + _titolo + ", autore: " + _autore + ", genere: " + _gen + ", anno: " + _anno;
        }

        public virtual int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            if (obj.GetType() != GetType()) 
                throw new ArgumentException();
            Libro l = (Libro)obj;
            if (l.Titolo == Titolo && l.Autore == Autore && l.Gen == Gen && l.Anno == Anno)
                return 0;
            else
                return Titolo.CompareTo(l.Titolo);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;
            Libro l = (Libro)obj;
            if (l.Titolo == Titolo && l.Autore == Autore && l.Gen == Gen && l.Anno == Anno)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
