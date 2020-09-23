using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityManager
{
    public partial class SceltaIntervallo : Form
    {
        private string _addr;

        private string _type = null;

        private DateTime _inizio;
        private DateTime _fine;

        private LogAccessi _logAccessi;
        private LogOperazioni _logOperazioni;

        public SceltaIntervallo(string addr, string type)
        {
            InitializeComponent();

            _addr = addr;
            _type = type;
            _logAccessi = new LogAccessi(_addr);
            _logOperazioni = new LogOperazioni(_addr);
            dateTimePickerSceltaInizio.MaxDate = DateTime.Today;
            dateTimePickerSceltaFine.MaxDate= DateTime.Today;
            
        }

        private void buttonVisualizzaLog_Click(object sender, EventArgs e)
        {
            if (String.Equals(_type, "accesso"))
            {
                _inizio = dateTimePickerSceltaInizio.Value;
                _fine = dateTimePickerSceltaFine.Value;
                string[] logAccessi = _logAccessi.GetEntryAccessiInterval(_inizio, _fine);
                new LogAccessiView(_addr, logAccessi).Show();
                this.Hide();
            }
            else
            {
                _inizio = dateTimePickerSceltaInizio.Value;
                _fine = dateTimePickerSceltaFine.Value;
                string[] logOperazioni = _logOperazioni.GetEntryOperazioniInterval(_inizio, _fine);
                new LogOperazioniView(_addr, logOperazioni).Show();
                this.Hide();
            }

        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            if (String.Equals(_type, "accesso"))
            {
                new LogAccessiView(_addr, null).Show();
                this.Hide();
            }
            else
            {

                new LogOperazioniView(_addr, null).Show();
                this.Hide();
            }
        }
    }
}
