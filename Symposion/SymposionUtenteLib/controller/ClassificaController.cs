using System;
using System.Collections.Generic;
using System.ServiceModel;
using NHibernate;
using NHibernate.Criterion;
using Progetto_Symposion;

namespace SymposionUtenteLib

{
    public class ClassificaController : Controller, IClassifica
    {
        public List<Libro> GetClassificaAnno(int date)
        {
            List<Libro> libriDellAnno = null;
            try
            {
                ISession sessione = GetConnection();
                sessione.BeginTransaction();
                string classificaAnno = "SELECT L.[Titolo] AS Titolo, L.[Autore] AS Autore, AVG(R.[Punteggio]) AS media " +
                                        "FROM[dbo].[Libri] L JOIN[dbo].[Recensioni] R ON(L.Titolo = R.Titolo AND L.Autore = R.Autore) " +
                                        "WHERE L.[Anno] = " + date.ToString() + " " +
                                        "GROUP BY L.[Titolo], L.[Autore] " +
                                        "ORDER BY media DESC";
                List<Object[]> result1 = (List<Object[]>)sessione.CreateSQLQuery(classificaAnno).List<Object[]>();
                libriDellAnno = new List<Libro>();
                int count = 0;
                foreach (Object[] row in result1)
                {
                    if (count < 10)
                    {
                        string titolo = (string)row[0];
                        string autore = (string)row[1];
                        int media = (int)row[2];
                        ICriteria criteria = sessione.CreateCriteria<Libro>();
                        Libro libro = (Libro)criteria.Add(Expression.Like("Titolo", titolo)).Add(Expression.Like("Autore", autore)).UniqueResult();
                        libriDellAnno.Add(libro);
                        count++;
                    }
                    else
                        break;
                }
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                return libriDellAnno;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public List<Libro> GetClassificaGenere(string gen)
        {
            List<Libro> libriDiGenere = null;
            try
            {
                if (gen == null)
                    throw new ArgumentException("Genere nullo");
                genere genType;
                if (Enum.TryParse(gen, out genType))
                {
                    int genNum = (int)genType;
                    ISession sessione = GetConnection();
                    sessione.BeginTransaction();
                    string classificaGenere = "SELECT L.[Titolo] AS Titolo, L.[Autore] AS Autore, AVG(R.[Punteggio]) AS media " +
                                              "FROM[dbo].[Libri] L JOIN[dbo].[Recensioni] R ON(L.Titolo = R.Titolo AND L.Autore = R.Autore) " +
                                              "WHERE L.[Gen] = " + genNum.ToString() + " " +
                                              "GROUP BY L.[Titolo], L.[Autore] " +
                                              "ORDER BY media DESC";
                    List<Object[]> result = (List<Object[]>)sessione.CreateSQLQuery(classificaGenere).List<Object[]>();
                    libriDiGenere = new List<Libro>();
                    int count = 0;
                    string titolo;
                    string autore;
                    int media;
                    foreach (Object[] row in result)
                    {
                        if (count < 10)
                        {
                            titolo = (string)row[0];
                            autore = (string)row[1];
                            media = (int)row[2];
                            ICriteria criteria = sessione.CreateCriteria<Libro>();
                            Libro libro = (Libro)criteria.Add(Expression.Like("Titolo", titolo)).Add(Expression.Like("Autore", autore)).UniqueResult();
                            libriDiGenere.Add(libro);
                            count++;
                        }
                        else
                            break;
                    }
                    sessione.Transaction.Commit();
                    sessione.Transaction.Dispose();
                }
                return libriDiGenere;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }
    }
}
