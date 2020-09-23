using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.ServiceModel;
using System.Text;
using NHibernate;
using NHibernate.Criterion;
using Progetto_Symposion;


namespace SymposionAmministratoreLib
{
    class SegnalazioneRecensioneController : ISegnalazioneRecensione
    {
        private SegnalazioniController _segnalazioniController;

        public SegnalazioneRecensioneController(SegnalazioniController segnalazioniController)
        {
            _segnalazioniController = segnalazioniController;
        }

        public void EliminaRecensione(Recensione recensione)
        {
            try
            {
                ISession sessione = _segnalazioniController.OpenConnection();
                sessione.BeginTransaction();
                int id = recensione.Id;
                List<Recensione> res = null;
                ICriteria criteria = sessione.CreateCriteria<Recensione>();
                res = (List<Recensione>)criteria.Add(Expression.Like("Id", id)).List<Recensione>();
                if (res.Count == 1)
                {
                    res[0].Punteggio = -1;
                    res[0].Username = "";
                    res[0].Commento = "";
                    res[0].Libro = null;
                    sessione.Update(res[0]);
                }
                sessione.Transaction.Commit();
                sessione.Flush();
                sessione.Transaction.Dispose();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public Recensione GetRecensione(int id)
        {
            Recensione recensione = null;
            try
            {
                ISession sessione = _segnalazioniController.OpenConnection();
                sessione.BeginTransaction();
                Recensione res = null;
                ICriteria criteria = sessione.CreateCriteria<Recensione>();
                res = (Recensione)criteria.Add(Expression.Like("Id", id)).UniqueResult();
                sessione.Transaction.Commit();
                sessione.Flush();
                sessione.Transaction.Dispose();
                Libro libro = new Libro
                {
                    Titolo = res.Libro.Titolo,
                    Autore = res.Libro.Autore,
                    Anno = res.Libro.Anno,
                    Gen = res.Libro.Gen,
                    FilePath = res.Libro.FilePath
                };
                recensione = new Recensione()
                {
                    Libro = libro,
                    Punteggio = res.Punteggio,
                    Commento = res.Commento,
                    Username = res.Username,
                    Id = res.Id
                };

                return recensione;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public void InviaNotificaUtente(string username)
        {
            string mailUtente = "";
            try
            {
                ISession sessione = _segnalazioniController.OpenConnection();
                sessione.BeginTransaction();
                List<Iscritto> res = null;
                ICriteria criteria = sessione.CreateCriteria<Iscritto>();
                res = (List<Iscritto>)criteria.Add(Expression.Like("Username", username)).List<Iscritto>();
                if (res.Count == 1)
                {
                    mailUtente = res[0].Email;
                }
                sessione.Transaction.Commit();
                sessione.Flush();
                sessione.Transaction.Dispose();

                var fromAddress = new MailAddress("symposionlibrary@gmail.com", "Symposion Library");
                var toAddress = new MailAddress(mailUtente, username);
                const string fromPassword = "Symposion1234";
                const string subject = "Correzione recensione scorretta";
                const string body = "Hai scritto una recensione offensiva, hai 48h per correggerla";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
                //probabilmente aggiungere anche il lancio dell'eccezione della mail
            }
        }
    }
}
