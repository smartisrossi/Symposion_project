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
    public partial class HomeLogView : Form
    {        
        private string _addr;

        public HomeLogView(string addr)
        {
            InitializeComponent();

            _addr = addr;
        }

        private void buttonLogAccessi_Click(object sender, EventArgs e)
        {
            string[] logAccessi = null;

            new LogAccessiView(_addr, logAccessi).Show();
            this.Hide();
        }

        private void buttonLogOperazioni_Click(object sender, EventArgs e)
        {
            string[] logOperazioni = null;
            new LogOperazioniView(_addr, logOperazioni).Show();
            this.Hide();
        }

        private void bunifuImageButtonConfigurazioni_Click(object sender, EventArgs e)
        {
            new GestioneConfigurazioniView(_addr).Show();
            this.Hide();
        }

        private void bunifuImageButtonLogout_Click(object sender, EventArgs e)
        {
            new HomeView().Show();
            this.Hide();
        }
    }
}
