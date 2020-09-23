using System;
using System.Collections.Generic;
using System.ServiceModel;
using NHibernate;
using NHibernate.Criterion;
using Progetto_Symposion;

namespace SymposionUtenteLib
{
    public class RecensioniSalvateController : IRecensioniSalvate
    {
        private GestisciUtente _gestisciUtente;

        public RecensioniSalvateController (GestisciUtente gestisciUtente)
        {
            _gestisciUtente = gestisciUtente;
        }

        public void RimuoviRecensione(Recensione recensione, string username)
        {
            try
            {
                RecensioniPreferite recPrefe = null;
                ISession sessione = _gestisciUtente.OpenConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<RecensioniPreferite>();
                recPrefe = (RecensioniPreferite)criteria.Add(Expression.Like("Username", username)).UniqueResult();
                List<Recensione> recSalvateNew = new List<Recensione>();
                foreach (Recensione rec in recPrefe.RecensioniSalvate)
                    if (rec.Id != recensione.Id)
                        recSalvateNew.Add(rec);
                recPrefe.RecensioniSalvate = recSalvateNew;
                sessione.Update(recPrefe);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                _gestisciUtente.RegisterOperazione("Rimozione recensione salvata", username);
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public void SalvaRecensione(Recensione recensione, string username)
        {
            try
            {
                RecensioniPreferite recPrefe = null;
                ISession sessione = _gestisciUtente.OpenConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<RecensioniPreferite>();
                recPrefe = (RecensioniPreferite)criteria.Add(Expression.Like("Username", username)).UniqueResult();
                Recensione trovata;
                ICriteria criteria2 = sessione.CreateCriteria<Recensione>();
                trovata = (Recensione)criteria2.Add(Expression.Like("Id", recensione.Id)).UniqueResult();
                if(trovata != null)
                    recPrefe.RecensioniSalvate.Add(trovata);
                sessione.Update(recPrefe);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                _gestisciUtente.RegisterOperazione("Salvataggio recensione", username);
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }
    }
}
