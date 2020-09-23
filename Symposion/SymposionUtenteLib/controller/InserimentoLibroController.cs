using NHibernate;
using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SymposionUtenteLib
{

    public class InserimentoLibroController : Controller, IInserimentoLibro
    {
        public void InserisciLibroCover(string titolo, string autore, int? anno, string gen, string cover, string username) 
        {
            try
            {
                if (titolo == null)
                    throw new ArgumentException("Titolo nullo");
                if (autore == null)
                    throw new ArgumentException("Autore nullo");
                if (anno == null)
                    throw new ArgumentException("Anno nullo");
                if ( gen == null)
                    throw new ArgumentException("Genere nullo");
                if (cover == null)
                    throw new ArgumentException("Cover nulla");
                
                Libro libro = new Libro(titolo, autore, anno, gen, cover);
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                sessione.Save(libro);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                PrintOperazione("inserimento libro", username);
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public void InserisciLibro(string titolo, string autore, int? anno, string gen, string username)
        {
            try
            {
                if (titolo == null)
                    throw new ArgumentException("Titolo nullo");
                if (autore == null)
                    throw new ArgumentException("Autore nullo");
                if (anno == null)
                    throw new ArgumentException("Anno nullo");
                if (gen == null)
                    throw new ArgumentException("Genere nullo");

                Libro libro = new Libro(titolo, autore, anno, gen);
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                sessione.Save(libro);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                PrintOperazione("inserimento libro", username);
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }
    }
}
