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
    public class Lista
    {
        private string _nome;
        private genere _gen;
        private bool _isVisibile;
        private IList<Libro> _listaLibri;
        private string _username;
        private int _id;

        public Lista()
        {

        }

        public Lista(string nome, string gen, string username)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome nullo");
            if (String.IsNullOrEmpty(gen))
                throw new ArgumentException("Genere nullo");
            if (String.IsNullOrEmpty(username))
                throw new ArgumentException("Utente nullo");

            Nome = nome;

            if (Enum.TryParse(gen, out _gen))
                if (!Enum.IsDefined(typeof(genere), _gen))
                    throw new ArgumentException("Genere non valido");

            IsVisibile = false;
            ListaLibri = new List<Libro>();
            Username = username;
            Id = 1;
        }

        //////////////////////

        [DataMember]
        public virtual string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        [DataMember]
        public virtual genere Gen
        {
            get
            {
                return _gen;
            }
            set
            {
                _gen = value;
            }
        }

        [DataMember]
        public virtual bool IsVisibile
        {
            get
            {
                return _isVisibile;
            }
            set
            {
                _isVisibile = value;
            }
        }

        [DataMember]
        public virtual IList<Libro> ListaLibri
        {
            get
            {
                return _listaLibri;
            } 
            set
            {
                _listaLibri = value;
            }
        }

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
        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //////////////////////

        public virtual void PubblicazioneLista()
        {
            if (!this.IsVisibile)
                this.IsVisibile = true;
        }

        public virtual void ModificaListaPersonale(string newNome, string newGenere, List<Libro> newListaLibri)
        {
            if (String.IsNullOrEmpty(newNome)) { }
            else
                this.Nome = newNome;

            if (String.IsNullOrEmpty(newGenere)) { }
            else
                if (Enum.TryParse(newGenere, out _gen))
                {
                    if (!Enum.IsDefined(typeof(genere), _gen))
                        throw new ArgumentException("Genere non valido");
                }

            if (!newListaLibri.Any()) { }
            else
                this.ListaLibri = newListaLibri;
        }

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append(this.Nome + " (" + this.Gen.ToString() + ")\n");
            foreach (Libro libro in this.ListaLibri)
                sb.Append(libro.ToString() + "\n");

            return sb.ToString();
        }
    }
}
