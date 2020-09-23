using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Symposion
{
    [Serializable]
    public class Classifica
    {
        private string _nome;
        private List<Libro> _libri;

        public Classifica(string nome)
        {
            if (String.IsNullOrEmpty(nome))
                throw new ArgumentException("Nome nullo");
            _nome = nome;
            _libri = new List<Libro>();
        }

        public List<Libro> Libri
        {
            get { return _libri; }
            set { _libri = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


    }
}
