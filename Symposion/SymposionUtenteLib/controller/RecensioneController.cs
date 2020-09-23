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
    public class RecensioneController : IRecensione
    {
        private GestisciUtente _gestisciUtente;

        public RecensioneController(GestisciUtente gestisciUtente)
        {
            _gestisciUtente = gestisciUtente;
        }

        public void ModificaRecensione(Recensione recensione)
        {
            try
            {
                if (recensione != null)
                {
                    ISession sessione = _gestisciUtente.OpenConnection();
                    sessione.BeginTransaction();
                    if (recensione.Punteggio != -1)
                    {
                        int id = recensione.Id;
                        Recensione res = null;
                        ICriteria criteria = sessione.CreateCriteria<Recensione>();
                        res = (Recensione)criteria.Add(Expression.Like("Id", id)).UniqueResult();
                        if (res != null)
                        {
                            res.Punteggio = recensione.Punteggio;
                            res.Commento = recensione.Commento;
                            sessione.Update(res);
                        }
                        _gestisciUtente.RegisterOperazione("modifica recensione personale", recensione.Username);
                    }
                    else
                    {
                        int id = recensione.Id;
                        Recensione res = null;
                        ICriteria criteria = sessione.CreateCriteria<Recensione>();
                        res = (Recensione)criteria.Add(Expression.Like("Id", id)).UniqueResult();
                        if (res != null)
                        {
                            res.Punteggio = -1;
                            res.Username = "";
                            res.Commento = "";
                            res.Libro = null;
                            sessione.Update(res);
                        }
                        _gestisciUtente.RegisterOperazione("cancellazione recensione personale", recensione.Username);
                    }
                    sessione.Transaction.Commit();
                    sessione.Transaction.Dispose();
                }
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message), new FaultReason(e.Message));
            }

        }


        public void PubblicaRecensione(int? punteggio, string commento, Libro libro, string username)
        {
            try
            {
                ISession sessione = _gestisciUtente.OpenConnection();
                sessione.BeginTransaction();
                Recensione rec = new Recensione(punteggio, libro, commento, username);
                rec.Username = username;
                sessione.Save(rec);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                _gestisciUtente.RegisterOperazione("pubblicazione recensione personale", username);
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message), new FaultReason(e.Message));
            }
        }
    }
}
