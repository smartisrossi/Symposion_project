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
    class ListeSalvateController : IListeSalvate
    {
        private GestisciUtente _gestisciUtente;

        public ListeSalvateController(GestisciUtente gestisciUtente)
        {
            _gestisciUtente = gestisciUtente;
        }
        public void RimuoviLista(Lista lista, string username)
        {
            try
            {
                ListePreferite listePrefe = null;
                ISession sessione = _gestisciUtente.OpenConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<ListePreferite>();
                listePrefe = (ListePreferite)criteria.Add(Expression.Like("Username", username)).UniqueResult();
                List<Lista> listeSalvateNew = new List<Lista>();
                foreach (Lista l in listePrefe.ListeSalvate)
                    if (l.Id != lista.Id)
                        listeSalvateNew.Add(l);
                listePrefe.ListeSalvate = listeSalvateNew;
                sessione.Update(listePrefe);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                _gestisciUtente.RegisterOperazione("rimozione lista personale", username);
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public void SalvaLista(Lista lista, string username)
        {
            try
            {
                ListePreferite listePrefe = null;
                ISession sessione = _gestisciUtente.OpenConnection();
                sessione.BeginTransaction();
                ICriteria criteria = sessione.CreateCriteria<ListePreferite>();
                listePrefe = (ListePreferite)criteria.Add(Expression.Like("Username", username)).UniqueResult();
                Lista trovata = null;
                ICriteria criteria2 = sessione.CreateCriteria<Lista>();
                trovata = (Lista)criteria2.Add(Expression.Like("Id", lista.Id)).UniqueResult();
                if(trovata != null)
                    listePrefe.ListeSalvate.Add(trovata);
                sessione.Update(listePrefe);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                _gestisciUtente.RegisterOperazione("salvataggio lista personale", username);
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }
    }
}
