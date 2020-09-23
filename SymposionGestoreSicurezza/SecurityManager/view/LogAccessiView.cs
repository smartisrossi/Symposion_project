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
    public partial class LogAccessiView : Form
    {
        private string _addr;
        private string[] _log;
        private string _type = "accesso";

        public LogAccessiView(string addr, string[] log)
        {
            InitializeComponent();
            _addr = addr;
            _log = log;

            listViewLogAccessi.View = View.Details;
            listViewLogAccessi.GridLines = true;
            listViewLogAccessi.FullRowSelect = true;

            //listViewLogAccessi.Items.Add("Log esempio"); // solo per esempio

            if (_log != null && _log.Length != 0)
            {
                foreach (string op in _log)
                    listViewLogAccessi.Items.Add(op);
            }
               
        }

        private void buttonChiudi_Click(object sender, EventArgs e)
        {
            new HomeLogView(_addr).Show();
            this.Hide();
        }

        private void buttonScegliIntervallo_Click(object sender, EventArgs e)
        {
            new SceltaIntervallo(_addr, _type).Show();
            this.Hide();
        }

        private void buttonScegliData_Click(object sender, EventArgs e)
        {
            new SceltaDate(_addr, _type).Show();
            this.Hide();
        }
    }
}
