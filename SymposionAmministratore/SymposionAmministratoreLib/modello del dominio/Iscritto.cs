using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Symposion
{
    [Serializable]
    public class Iscritto
    {
        private string _username;
        private string _email;
        private string _password;
        private string _ruolo;

        public virtual string Username { get => _username; set => _username = value; }
        public virtual string Email { get => _email; set => _email = value; }
        public virtual string Password { get => _password; set => _password = value; }
        public virtual string Ruolo { get => _ruolo; set => _ruolo = value; }
    }
}
