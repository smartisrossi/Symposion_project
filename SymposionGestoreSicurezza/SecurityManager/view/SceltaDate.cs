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
    public partial class SceltaDate : Form
    {
        private LogAccessi _logAccessi;
        private LogOperazioni _logOperazioni;

        private string _addr;
        private string _type;

        private DateTime _dt;

        public SceltaDate(string addr, string type)
        {
            InitializeComponent();

            _addr = addr;
            _type = type;

            _logAccessi = new LogAccessi(_addr);
            _logOperazioni = new LogOperazioni(_addr);

            dateTimePickerSceltaData.MaxDate = DateTime.Today;
        }

        private void buttonVisualizzaLog_Click(object sender, EventArgs e)
        {
            if (String.Equals(_type, "accesso"))
            {
                _dt = dateTimePickerSceltaData.Value;
                string[] logAccessi = _logAccessi.GetEntryAccessi(_dt);
                new LogAccessiView(_addr, logAccessi).Show();
                this.Hide();
            }
            else
            {
                _dt = dateTimePickerSceltaData.Value;
                string[] logOperazioni = _logOperazioni.GetEntryOperazioni(_dt);
                new LogOperazioniView(_addr, logOperazioni).Show();
                this.Hide();
            }

        }

        //solo per vedere se funziona, non serve
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
