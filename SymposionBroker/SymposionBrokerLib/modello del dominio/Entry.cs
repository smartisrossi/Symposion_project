using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Symposion
{
    [Serializable]
    public class Entry
    {
        private DateTime _dataOra;
        private string _luogo;
        private string _username;

        public Entry(string luogo, string username)
        {
            if (String.IsNullOrEmpty(luogo))
                throw new ArgumentException("Luogo nullo");
            if (String.IsNullOrEmpty(username))
                throw new ArgumentException("Username nullo");
            _dataOra = DateTime.Now;
            _luogo = luogo;
            _username = username;
        }

        //////////

        public DateTime DataOra
        {
            get
            {
                return _dataOra;
            }
            set
            {
                _dataOra = value;
            }
        }

        public string Luogo
        {
            get
            {
                return _luogo;
            }
            set
            {
                _luogo = value;
            }
        }

        public string Username
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

        public virtual string GetEntry()
        {
            // formato: DataOra Luogo Username
            return DataOra.ToString() + " " + Luogo + " " + Username;
        }

    }
}
