using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using NHibernate;
using NHibernate.Criterion;
using Progetto_Symposion;

namespace SymposionAmministratoreLib
{
    class SegnalazioniController : Controller, ISegnalazioni
    {
        private CodaSegnalazioneLibro _codaSegnalazioneLibro = null;
        private CodaSegnalazioneRecensione _codaSegnalazioneRecensione = null;
        private static readonly string _fileCodaSenalazioneLibro = "C:\\Users\\mmart\\Desktop\\codaAmministratore\\libro.txt";
        private static readonly string _fileCodaSegnalazioneRecensione = "C:\\Users\\mmart\\Desktop\\codaAmministratore\\recensione.txt";
        private SegnalazioneLibroController _segnalazioneLibroController = null;
        private SegnalazioneRecensioneController _segnalazioneRecensioneController = null;

        public SegnalazioniController()
        {
            _segnalazioneLibroController = new SegnalazioneLibroController(this);
            _segnalazioneRecensioneController = new SegnalazioneRecensioneController(this);
        }

        public void AddSegnalazioneLibro(SegnalazioneLibro segnalazioneLibro)
        {
            //questo metodo non e' accessibile dall'amministratore
        }

        public void AddSegnalazioneRecensione(SegnalazioneRecensione segnalazioneRecensione)
        {
            //questo metodo non e' accessibile dall'amministratore
        }

        public SegnalazioneLibro GetSegnalazioneLibro()
        {
            SegnalazioneLibro segn = null;
            try
            {
                if (File.Exists(_fileCodaSenalazioneLibro))
                {
                    StreamReader streamReader = new StreamReader(_fileCodaSenalazioneLibro);
                    List<string> lines = new List<string>();
                    while (streamReader.Peek() >= 0)
                    {
                       lines.Add(streamReader.ReadLine());
                    }
                    streamReader.Close();
                    if (lines.Count > 0)
                    {
                        string firstLine = lines[0];
                        lines.Remove(firstLine);
                        StreamWriter writer = new StreamWriter(_fileCodaSenalazioneLibro);
                        foreach (string l in lines)
                            writer.WriteLine(l);
                        writer.Close();
                        string[] elements = firstLine.Split('/');
                        if (elements.Length == 3) {
                            Libro libro = _segnalazioneLibroController.GetLibro(elements[0], elements[1]);
                            if(libro == null)
                                throw new Exception("impossibile trovare il libro");
                            segn = new SegnalazioneLibro(elements[2], libro);
                            ISession sessione = OpenConnection();
                            sessione.BeginTransaction();
                            List<SegnalazioneLibro> segnReceived = null;
                            ICriteria criteria = sessione.CreateCriteria<SegnalazioneLibro>();
                            segnReceived = (List<SegnalazioneLibro>)criteria.Add(Expression.Like("Libro", libro)).List<SegnalazioneLibro>();
                            foreach (SegnalazioneLibro s in segnReceived)
                                sessione.Delete(s);
                            sessione.Transaction.Commit();
                            sessione.Transaction.Dispose();
                        }
                        else
                        {
                            throw new Exception("segnalazione scorretta");
                        }
                    }
                }
                return segn;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public SegnalazioneRecensione GetSegnalazioneRecensione()
        {
            SegnalazioneRecensione segn = null;
            try
            {
                if (File.Exists(_fileCodaSegnalazioneRecensione))
                {
                    StreamReader streamReader = new StreamReader(_fileCodaSegnalazioneRecensione);
                    List<string> lines = new List<string>();
                    while (streamReader.Peek() >= 0)
                    {
                        lines.Add(streamReader.ReadLine());
                    }
                    streamReader.Close();
                    if (lines.Count > 0)
                    {
                        string firstLine = lines[0];
                        lines.Remove(firstLine);
                        StreamWriter writer = new StreamWriter(_fileCodaSegnalazioneRecensione);
                        foreach (string l in lines)
                            writer.WriteLine(l);
                        writer.Close();
                        string[] elements = firstLine.Split('/');
                        if (elements.Length == 2)
                        {
                            Recensione recensione = _segnalazioneRecensioneController.GetRecensione(Int32.Parse(elements[0]));
                            if (recensione == null)
                                throw new Exception("impossibile trovare la recensione");
                            segn = new SegnalazioneRecensione(elements[1], recensione);
                            ISession sessione = OpenConnection();
                            sessione.BeginTransaction();
                            List<SegnalazioneRecensione> segnReceived = null;
                            ICriteria criteria = sessione.CreateCriteria<SegnalazioneRecensione>();
                            segnReceived = (List<SegnalazioneRecensione>)criteria.Add(Expression.Like("Recensione", recensione)).List<SegnalazioneRecensione>();
                            foreach(SegnalazioneRecensione s in segnReceived)
                                sessione.Delete(s);
                            sessione.Transaction.Commit();
                            sessione.Transaction.Dispose();
                        }
                        else
                        {
                            throw new Exception("segnalazione scorretta");
                        }
                    }
                }
                return segn;
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault("problemi remoti"));
            }
        }
        
    }
}

