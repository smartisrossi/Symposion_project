using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Progetto_Symposion;

namespace SymposionGestoreSicurezzaLib
{
    public class LogController : Controller, ILog
    {
        public List<string> GetEntryAccessi(DateTime dateTime)
        {
            List<string> entries = new List<string>();
            try
            {
                StreamReader streamReader = new StreamReader(_fileLogAccessi);
                string dateStringTarget = dateTime.Date.ToString().Split(' ')[0];
                while (streamReader.Peek() >= 0)
                {
                    string line = streamReader.ReadLine();
                    string[] words = line.Split(' ');
                    string dateString = words[0];
                    if (dateString.Equals(dateStringTarget))
                        entries.Add(line);
                }
                streamReader.Close();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
            return entries;
        }

        public List<string> GetEntryAccessiInterval(DateTime dateTimeStart, DateTime dateTimeStop)
        {
            List<string> entries = new List<string>();
            try
            {
                StreamReader streamReader = new StreamReader(_fileLogAccessi);
                while (streamReader.Peek() >= 0)
                {
                    string line = streamReader.ReadLine();
                    string[] words = line.Split(' ');
                    string dateString = words[0] + " " + words[1];
                    DateTime date = DateTime.Parse(dateString);
                    if (date.CompareTo(dateTimeStart) >= 0 && date.CompareTo(dateTimeStop) <= 0)
                        entries.Add(line);
                }
                streamReader.Close();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
            return entries;
        }

        public List<string> GetEntryOperazioni(DateTime dateTime)
        {
            List<string> entries = new List<string>();
            try
            {
                StreamReader streamReader = new StreamReader(_fileLogOperazioni);
                string dateStringTarget = dateTime.Date.ToString().Split(' ')[0];
                while (streamReader.Peek() >= 0)
                {
                    string line = streamReader.ReadLine();
                    string[] words = line.Split(' ');
                    string dateString = words[0];
                    if (dateString.Equals(dateStringTarget))
                        entries.Add(line);
                }
                streamReader.Close();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
            return entries;
        }

        public List<string> GetEntryOperazioniInterval(DateTime dateTimeStart, DateTime dateTimeStop)
        {
            List<string> entries = new List<string>();
            try
            {
                StreamReader streamReader = new StreamReader(_fileLogOperazioni);
                while (streamReader.Peek() >= 0)
                {
                    string line = streamReader.ReadLine();
                    string[] words = line.Split(' ');
                    string dateString = words[0] + " " + words[1];
                    DateTime date = DateTime.Parse(dateString);
                    Console.WriteLine("Target: "+date.ToString());
                    Console.WriteLine("Start: " + dateTimeStart.ToString());
                    Console.WriteLine("Stop: " + dateTimeStop.ToString());
                    if (DateTime.Compare(date, dateTimeStart) >= 0 && DateTime.Compare(date, dateTimeStop) <= 0)
                        entries.Add(line);
                }
                streamReader.Close();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
            return entries;
        }

        public void PrintLogAccessi(Entry[] entries)
        {
            try
            {
                StreamWriter streamWriter = OpenLogAccessi(_fileLogAccessi);
                foreach (Entry e in entries)
                    streamWriter.WriteLine(e.GetEntry());
                streamWriter.Close();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }

        public void PrintLogOperazioni(EntryOperazione[] entries)
        {
            try
            {
                StreamWriter streamWriter = OpenLogAccessi(_fileLogOperazioni);
                foreach (Entry e in entries)
                    streamWriter.WriteLine(e.GetEntry());
                streamWriter.Close();
            }
            catch (Exception e)
            {
                throw new FaultException<BookFault>(new BookFault(e.Message));
            }
        }
    }
}
