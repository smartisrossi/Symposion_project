using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progetto_Symposion;
using System.ServiceModel;
using NHibernate;
using NHibernate.Criterion;

namespace SymposionUtenteLib
{
    public class GestisciUtente : Controller, IGestisciUtente
    {
        public List<Lista> GetListePersonali(string username)
        {
            List<Lista> liste = null;
            try
            {
                if (username == null)
                    throw new ArgumentException("Username nullo");
                List<Lista> listeReceived = null;
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<Lista>();
                listeReceived = (List<Lista>)criteria.Add(Expression.Like("Username", username)).List<Lista>();
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                liste = new List<Lista>();
                foreach (Lista l in listeReceived)
                {
                    Lista listaTemp = new Lista()
                    {
                        Nome = l.Nome,
                        Gen = l.Gen,
                        IsVisibile = l.IsVisibile,
                        ListaLibri = new List<Libro>(),
                        Username = l.Username,
                        Id = l.Id
                    };
                    foreach (Libro lib in l.ListaLibri)
                    {
                        Libro temp = new Libro
                        {
                            Anno = lib.Anno,
                            Autore = lib.Autore,
                            FilePath = lib.FilePath,
                            Gen = lib.Gen,
                            Titolo = lib.Titolo
                        };
                        listaTemp.ListaLibri.Add(temp);
                    }
                    liste.Add(listaTemp);
                }
                RegisterOperazione("get lista personale", username);
                return liste;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public List<Lista> GetListeSalvate(string username)
        {
            List<Lista> listePrefe = null;
            try
            {
                if (username == null)
                    throw new ArgumentException("Username nullo");
                ListePreferite listeReceived = null;
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<ListePreferite>();
                listeReceived = (ListePreferite)criteria.Add(Expression.Like("Username", username)).UniqueResult();
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                listePrefe = new List<Lista>();
                foreach (Lista l in listeReceived.ListeSalvate)
                {
                    if (l.Username != null)
                    {
                        Lista listaTemp = new Lista()
                        {
                            Nome = l.Nome,
                            Gen = l.Gen,
                            IsVisibile = l.IsVisibile,
                            ListaLibri = new List<Libro>(),
                            Username = l.Username,
                            Id = l.Id
                        };
                        foreach (Libro lib in l.ListaLibri)
                        {
                            Libro temp = new Libro
                            {
                                Anno = lib.Anno,
                                Autore = lib.Autore,
                                FilePath = lib.FilePath,
                                Gen = lib.Gen,
                                Titolo = lib.Titolo
                            };
                            listaTemp.ListaLibri.Add(temp);
                        }
                        listePrefe.Add(listaTemp);
                    }
                }
                RegisterOperazione("get liste salvate", username);
                return listePrefe;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public List<Recensione> GetRecensioniSalvate(string username)
        {
            List<Recensione> recensioni = null;
            try
            {
                if (username == null)
                    throw new ArgumentException("Username nullo");
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                RecensioniPreferite recensioniRicevute = null;
                ICriteria criteria = sessione.CreateCriteria<RecensioniPreferite>();
                recensioniRicevute = (RecensioniPreferite)criteria.Add(Expression.Like("Username", username)).UniqueResult();
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                recensioni = new List<Recensione>();
                foreach (Recensione r in recensioniRicevute.RecensioniSalvate)
                {
                    if (r.Punteggio != -1)
                    {
                        Libro temp = new Libro
                        {
                            Anno = r.Libro.Anno,
                            Autore = r.Libro.Autore,
                            FilePath = r.Libro.FilePath,
                            Gen = r.Libro.Gen,
                            Titolo = r.Libro.Titolo
                        };
                        Recensione recTemp = new Recensione()
                        {
                            Punteggio = r.Punteggio,
                            Libro = temp,
                            Commento = r.Commento,
                            Username = r.Username,
                            Id = r.Id
                        };
                        recensioni.Add(recTemp);
                    }
                }

                RegisterOperazione("get recensioni salvate", username);
                return recensioni;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public List<Recensione> GetRecensioniScritte(string username)
        {
            List<Recensione> recensioni = null;
            try
            {
                if (username == null)
                    throw new ArgumentException("Username nullo");
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                List<Recensione> recensioniRicevute = null;
                ICriteria criteria = sessione.CreateCriteria<Recensione>();
                recensioniRicevute = (List<Recensione>)criteria.Add(Expression.Like("Username", username)).List<Recensione>();
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                recensioni = new List<Recensione>();
                foreach (Recensione r in recensioniRicevute)
                {
                    Libro temp = new Libro
                    {
                        Anno = r.Libro.Anno,
                        Autore = r.Libro.Autore,
                        FilePath = r.Libro.FilePath,
                        Gen = r.Libro.Gen,
                        Titolo = r.Libro.Titolo
                    };
                    Recensione recTemp = new Recensione()
                    {
                        Punteggio = r.Punteggio,
                        Libro = temp,
                        Commento = r.Commento,
                        Username = r.Username,
                        Id = r.Id
                    };
                    recensioni.Add(recTemp);
                }
                RegisterOperazione("get recensioni salvate", username);
                return recensioni;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public void RegisterOperazione(string operazione, string username)
        {
            PrintOperazione(operazione, username);
        }

    }
}
