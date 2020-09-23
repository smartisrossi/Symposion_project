using NHibernate;
using NHibernate.Criterion;
using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymposionBrokerLib
{
    public class LoginController : Controller, ILogin
    {
        public string VerificaCredenziali(string username, string password)
        {
            string ruolo = null;

            if (String.IsNullOrEmpty(username))
                throw new ArgumentException("Username nullo");
            if (String.IsNullOrEmpty(password))
                throw new ArgumentException("Password nulla");

            if (username.Length < 3)
                throw new ArgumentException("Lunghezza minima username: 3 caratteri");
            if (password.Length < 10)
                throw new ArgumentException("Lunghezza minima password: 10 caratteri");


            try
            {
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                List<Iscritto> res = null;
                ICriteria criteria = sessione.CreateCriteria<Iscritto>();
                res = (List<Iscritto>)criteria.Add(Expression.Like("Username", username)).Add(Expression.Like("Password", password)).List<Iscritto>();
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                if (res.Count == 1)
                    ruolo = res[0].Ruolo;
                PrintAccesso("login", username);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Credenziali non valide: " + e.ToString());
            }

            return ruolo;
        }
    }
}
