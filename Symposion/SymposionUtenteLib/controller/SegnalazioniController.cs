using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using NHibernate;
using Progetto_Symposion;

namespace SymposionUtenteLib
{
    class SegnalazioniController : Controller, ISegnalazioni
    {
        private static readonly string _fileCodaSenalazioneLibro = "C:\\Users\\mmart\\Desktop\\codaAmministratore\\libro.txt";
        private static readonly string _fileCodaSegnalazioneRecensione = "C:\\Users\\mmart\\Desktop\\codaAmministratore\\recensione.txt";

        public void AddSegnalazioneLibro(SegnalazioneLibro segnalazioneLibro)
        {
            try
            {
                WriteSegnalazioneLibro(segnalazioneLibro);
                ISession sessione = OpenConnection();
                sessione.BeginTransaction();
                sessione.Save(segnalazioneLibro);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public void AddSegnalazioneRecensione(SegnalazioneRecensione segnalazioneRecensione)
        {
            try
            {
                WriteSegnalazioneRecensione(segnalazioneRecensione);
                ISession sessione = OpenConnection();
                sessione.BeginTransaction();
                sessione.Save(segnalazioneRecensione);
                sessione.Transaction.Commit();
                sessione.Transaction.Dispose();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public SegnalazioneLibro GetSegnalazioneLibro()
        {
            // questo metodo non e' accessibile dall'utente
            return null;
        }

        public SegnalazioneRecensione GetSegnalazioneRecensione()
        {
            // questo metodo non e' accessibile dall'utente
            return null;
        }

        private static void WriteSegnalazioneLibro(SegnalazioneLibro target)
        {
            try
            {
                StreamWriter writer = File.AppendText(_fileCodaSenalazioneLibro);
                writer.WriteLine(target.Libro.Titolo + "/" + target.Libro.Autore + "/" + target.Username);
                writer.Close();
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
        }

        private static void WriteSegnalazioneRecensione(SegnalazioneRecensione target)
        {
            try
            {
                StreamWriter writer = File.AppendText(_fileCodaSegnalazioneRecensione);
                writer.WriteLine(target.Recensione.Id + "/" + target.Username);
                writer.Close();
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
        }

    }
}
