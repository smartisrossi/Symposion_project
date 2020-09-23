using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Progetto_Symposion;

namespace SymposionGestoreSicurezzaLib
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class GestoreSicurezzaService : IGestoreSicurezza
    {
        private LogController _logController = new LogController();
        public List<string> GetEntryAccessi(DateTime dateTime)
        {
            return _logController.GetEntryAccessi(dateTime);
        }

        public List<string> GetEntryAccessiInterval(DateTime dateTimeStart, DateTime dateTimeStop)
        {
            return _logController.GetEntryAccessiInterval(dateTimeStart, dateTimeStop);
        }

        public List<string> GetEntryOperazioni(DateTime dateTime)
        {
            return _logController.GetEntryOperazioni(dateTime);
        }

        public List<string> GetEntryOperazioniInterval(DateTime dateTimeStart, DateTime dateTimeStop)
        {
            return _logController.GetEntryOperazioniInterval(dateTimeStart, dateTimeStop);
        }

        public void PrintLogAccessi(Entry[] entries)
        {
            _logController.PrintLogAccessi(entries);
        }

        public void PrintLogOperazioni(EntryOperazione[] entries)
        {
            _logController.PrintLogOperazioni(entries);
        }
    }
}
