using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.IO;
using Progetto_Symposion;
using NHibernate;
using NHibernate.Cfg;

namespace SymposionBrokerLib
{
    public class Controller
    {
        private ISession _dbConnection;
        private StreamWriter _printOperazioni;
        private StreamWriter _printAccessi;
        protected readonly string _fileLogOperazioni = "C:\\Users\\mmart\\Desktop\\Log\\operazioni.txt";
        protected readonly string _fileLogAccessi = "C:\\Users\\mmart\\Desktop\\Log\\accessi.txt";

        //non ho messo il costruttore perchè è quello nullo di default, in C# si può omettere

        public StreamWriter OpenLogAccessi(string logAccessiFile)
        {
            if (String.IsNullOrEmpty(logAccessiFile))
                throw new ArgumentException("File log accessi nullo");
            try
            {
                _printAccessi = File.AppendText(logAccessiFile);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Nome del file log accessi non valido " + e.InnerException.ToString());
            }
            return _printAccessi;
        }

        public StreamWriter OpenLogOperazioni(string logOperazioniFile)
        {
            if (String.IsNullOrEmpty(logOperazioniFile))
                throw new ArgumentException("File log operazioni nullo");
            try
            {
                _printOperazioni = File.AppendText(logOperazioniFile);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Nome del file log operazioni non valido " + e.InnerException.ToString());
            }

            return _printOperazioni;
        }

        public ISession OpenConnection()
        {
            try
            {
                Configuration configuration = new Configuration();
                configuration.Configure();
                ISessionFactory sessionFactory = configuration.BuildSessionFactory();
                _dbConnection = sessionFactory.OpenSession();
            }
            catch (Exception e)
            {
                throw new ArgumentException("Impossibile aprire la connessione con il db " + e.InnerException.ToString());
            }

            return _dbConnection;
        }
 
        protected void PrintOperazione(string operazione, string username)
        {
            if (_printOperazioni == null)
                OpenLogOperazioni(_fileLogOperazioni);
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            EntryOperazione entry = new EntryOperazione(watcher.Position.Location.ToString(), username, operazione);
            _printOperazioni.WriteLine(entry.GetEntry());
            _printOperazioni.Close();
        }

        protected void PrintAccesso(string accesso, string username)
        {
            if (_printAccessi == null)
                OpenLogAccessi(_fileLogAccessi);
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            Entry entry = new Entry(watcher.Position.Location.ToString(), username);
            _printAccessi.WriteLine(entry.GetEntry());
            _printAccessi.Close();
        }

        protected ISession GetConnection()
        {
            return OpenConnection();
        }
    }
}
