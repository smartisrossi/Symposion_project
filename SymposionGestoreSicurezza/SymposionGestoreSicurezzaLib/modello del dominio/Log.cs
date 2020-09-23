using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Progetto_Symposion
{
    public class Log
    {
        private List<Entry> _entries;

        public Log() { }

        public List<Entry> Entries
        {
            get { return _entries; }
        }

        public void AddEntry(Entry e)
        {
            if( e == null)
                throw new ArgumentException("Entry nulla");
            _entries.Add(e);

        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("Entry del log: ");
            foreach (Entry entry in Entries)
                builder.AppendLine(entry.GetEntry());
            return builder.ToString();
        }
    }
}
