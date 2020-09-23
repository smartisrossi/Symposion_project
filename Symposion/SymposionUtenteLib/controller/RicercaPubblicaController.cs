
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Criterion;
using Progetto_Symposion;

namespace SymposionUtenteLib
{
    public class RicercaPubblicaController : Controller, IRicercaPubblica
    {
        public List<Libro> CercaLibro(string titolo)
        {
            List<Libro> libri = null;
            try
            {
                if (titolo == null)
                    throw new ArgumentException("Titolo nullo");
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<Libro>();
                libri = (List<Libro>)criteria.Add(Expression.Like("Titolo", titolo)).List<Libro>();
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }

            return libri; 
        }

        public List<Lista> CercaLista(string nome)
        {
            List<Lista> liste = null;
            
            try
            {
                if (nome == null)
                    throw new ArgumentException("Nome lista nullo");
                ISession sessione = GetConnection();
                List<Lista> listeReceived = null;
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<Lista>();
                listeReceived = (List<Lista>)criteria.Add(Expression.Like("Nome", nome)).Add(Expression.Like("IsVisibile", true)).List<Lista>();
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
                    foreach(Libro lib in l.ListaLibri)
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

            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }

            return liste;
        }

        public List<Lista> CercaListaUtente(string username)
        {
            List<Lista> liste = null;

            try
            {
                if (username == null)
                    throw new ArgumentException("Nome lista nullo");
                ISession sessione = GetConnection();
                List<Lista> listeReceived = null;
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<Lista>();
                listeReceived = (List<Lista>)criteria.Add(Expression.Like("Username", username)).Add(Expression.Like("IsVisibile", true)).List<Lista>();
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

            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }

            return liste;
        }

        public List<Libro> CercaGenere(string genereString)
        {
            List<Libro> libriPerGenere = null;
            
            try
            {
                if (genereString == null)
                    throw new ArgumentException("Genere nullo");
                genere gen;
                if (Enum.TryParse(genereString, out gen))
                {
                    ISession sessione = GetConnection();
                    sessione.BeginTransaction();
                    ICriteria criteria = sessione.CreateCriteria<Libro>();
                    libriPerGenere = (List<Libro>)criteria.Add(Expression.Like("Gen", gen)).List<Libro>();
                    sessione.Transaction.Commit();
                    sessione.Transaction.Dispose();
                }
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }

            return libriPerGenere;
        }

        public string CercaUtente(string username)
        {
            string result = null;
            try
            {
                if (username == null)
                    throw new ArgumentException("Username nullo");
                Iscritto iscritto = null;
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<Iscritto>();
                iscritto = (Iscritto)criteria.Add(Expression.Like("Username", username)).UniqueResult();
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                if(iscritto != null)
                    result = iscritto.Username;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }

            return result;
        }

        public List<Recensione> CercaRecensioniLibro(Libro libro)
        {
            List<Recensione> recensioni = null;

            try
            {
                if (libro == null)
                    throw new ArgumentException("Libro non esistente");
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                List<Recensione> recensioniRicevute = null;
                ICriteria criteria = sessione.CreateCriteria<Recensione>();
                recensioniRicevute = (List<Recensione>)criteria.Add(Expression.Like("Libro", libro)).List<Recensione>();
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
                return recensioni;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
            
        }

        public List<Recensione> CercaRecensioniUtente(string usernameUtente)
        {
            List<Recensione> recensioni = null;

            try
            {
                if (usernameUtente == null)
                    throw new ArgumentException("username non esistente");
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                List<Recensione> recensioniRicevute = null;
                ICriteria criteria = sessione.CreateCriteria<Recensione>();
                recensioniRicevute = (List<Recensione>)criteria.Add(Expression.Like("Username", usernameUtente)).List<Recensione>();
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
                return recensioni;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }

        }

        public List<Lista> CercaListaPersonaleUtente(string username)
        {
            List<Lista> liste = null;

            try
            {
                if (username == null)
                    throw new ArgumentException("Nome lista nullo");
                ISession sessione = GetConnection();
                List<Lista> listeReceived = null;
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

            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }

            return liste;
        }
    }
}
