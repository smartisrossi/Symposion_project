using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Progetto_Symposion;
using NHibernate;
using NHibernate.Criterion;

namespace SymposionUtenteLib
{
    public class ListePersonaliController : IListePersonali
    {
        private GestisciUtente _gestisciUtente;

        public ListePersonaliController(GestisciUtente gestisciUtente)
        {
            _gestisciUtente = gestisciUtente;
        }
        public void CreaListaPersonale(string nome, string genere, string username)
        {
            try
            {
                ISession sessione = _gestisciUtente.OpenConnection();
                sessione.BeginTransaction();
                Lista lista = new Lista(nome, genere, username);
                lista.Username = username;
                sessione.Save(lista);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
                _gestisciUtente.RegisterOperazione("creazione lista personale", username);
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }

        }

        public void ModificaListaPersonale(Lista lista)
        {
            try
            {
                if (lista != null)
                {
                    ISession sessione = _gestisciUtente.OpenConnection();
                    sessione.BeginTransaction();
                    if (lista.Nome != null)
                    {
                        int id = lista.Id;
                        Lista res = null;
                        ICriteria criteria = sessione.CreateCriteria<Lista>();
                        res = (Lista)criteria.Add(Expression.Like("Id", id)).UniqueResult();
                        if (res != null)
                        {
                            res.Nome = lista.Nome;
                            res.ListaLibri = lista.ListaLibri;
                            res.Gen = lista.Gen;
                            sessione.Update(res);
                        }
                        sessione.Transaction.Commit();
                        sessione.Transaction.Dispose();
                        _gestisciUtente.RegisterOperazione("modifica lista personale", lista.Username);
                    }
                    else
                    {
                        int id = lista.Id;
                        Lista res = null;
                        ICriteria criteria = sessione.CreateCriteria<Lista>();
                        res = (Lista)criteria.Add(Expression.Like("Id", id)).UniqueResult();
                        if (res != null)
                        {
                            res.ListaLibri = null;
                            res.Nome = null;
                            res.Username = null;
                            sessione.Update(res);
                        }
                        sessione.Transaction.Commit();
                        sessione.Transaction.Dispose();
                        _gestisciUtente.RegisterOperazione("cancellazione lista personale", lista.Username);
                    }
                    
                }
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message), new FaultReason(e.Message));
            }

        }

        public void PubblicaListaPersonale(Lista lista)
        {
            try
            {
                ISession sessione = _gestisciUtente.OpenConnection();
                sessione.BeginTransaction();
                if (lista != null)
                {
                    lista.PubblicazioneLista();
                    int id = lista.Id;
                    Lista res = null;
                    ICriteria criteria = sessione.CreateCriteria<Lista>();
                    res = (Lista)criteria.Add(Expression.Like("Id", id)).UniqueResult();
                    if (res != null)
                    {
                        res.IsVisibile = true;
                        sessione.Update(res);
                    }
                    _gestisciUtente.RegisterOperazione("pubblicazione lista personale", lista.Username);
                }
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message), new FaultReason(e.Message));
            }

        }
    }
}
