using System;
using System.Collections.Generic;
using System.ServiceModel;
using NHibernate;
using NHibernate.Criterion;
using Progetto_Symposion;

namespace SymposionAmministratoreLib
{
    class SegnalazioneLibroController : ISegnalazioneLibro
    {

        private SegnalazioniController _segnalazioniController;

        public SegnalazioneLibroController(SegnalazioniController segnalazioniController)
        {
            _segnalazioniController = segnalazioniController;
        }

        public void AggiornaLibro(Libro libro)
        {
            try
            {
                ISession sessione = _segnalazioniController.OpenConnection();
                sessione.BeginTransaction();
                sessione.Update(libro);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public Libro GetLibro(string titolo, string autore)
        {
            Libro libro = null;
            try
            {
                ISession sessione = _segnalazioniController.OpenConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<Libro>();
                libro = (Libro)criteria.Add(Expression.Like("Titolo", titolo)).Add(Expression.Like("Autore", autore)).UniqueResult();
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                return libro;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }
    }
}
