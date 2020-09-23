using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class GestioneConfigurazioniView : Form
    {
        private string _addr;
        private string _username;

        private Configurazioni _config;

        public GestioneConfigurazioniView(string addr, string username)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            _config = new Configurazioni();
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }

        private void buttonSO_Click(object sender, EventArgs e)
        {
            new SistemaOperativoView(_addr, _username, _config.GetVersionSO()).Show();
            this.Hide();
        }

        private void buttonStatoSistema_Click(object sender, EventArgs e)
        {
            new StatoSistemaView(_addr, _username, _config.GetStato()).Show();
            this.Hide();
        }

        private void buttonVerificaAggiornamenti_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Il sistema è aggiornato");
        }

        private void buttonInstallaAggiornamenti_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Non sono presenti nuovi aggiornamenti");
        }
    }
}
