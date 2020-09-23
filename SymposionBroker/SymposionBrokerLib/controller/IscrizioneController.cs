using NHibernate;
using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymposionBrokerLib
{
    public class IscrizioneController : Controller, IIscrizione
    {
        public void RegistraDati(string username, string password, string email)
        {
            if (String.IsNullOrEmpty(username))
                throw new ArgumentException("Username nullo");
            if (String.IsNullOrEmpty(password))
                throw new ArgumentException("Password nulla");
            if (String.IsNullOrEmpty(email))
                throw new ArgumentException("Email nulla");

            if (username.Length < 3)
                throw new ArgumentException("Lunghezza minima username: 3 caratteri");
            if (password.Length < 10)
                throw new ArgumentException("Lunghezza minima password: 10 caratteri");

            try
            {
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                Iscritto iscritto = new Iscritto
                {
                    Username = username,
                    Email = email,
                    Password = password,
                    Ruolo = "utente"
                };
                sessione.Save(iscritto);
                RecensioniPreferite recensioniPreferite = new RecensioniPreferite(username);
                sessione.Save(recensioniPreferite);
                ListePreferite listePreferite = new ListePreferite(username);
                sessione.Save(listePreferite);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                PrintAccesso("login", username);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Credenziali non valide: " + e.ToString());
            }

        }
    }
}
