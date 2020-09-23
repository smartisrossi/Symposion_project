using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amministratore
{ 
    public partial class GestioneConfigurazioniView : Form
    {
        private string _addr;

        private Configurazioni _config;

        public GestioneConfigurazioniView(string addr)
        {
            InitializeComponent();

            _addr = addr;
            _config = new Configurazioni();
        }

        private void buttonStatoSistema_Click(object sender, EventArgs e)
        {
            
            new StatoSistemaView(_addr, _config.GetStato()).Show();
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

        private void buttonSO_Click(object sender, EventArgs e)
        {
            new SistemaOperativoView(_addr, _config.GetVersionSO()).Show();
            this.Hide();
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new HomeAmministratoreView(_addr).Show();
            this.Hide();
        }
    }
}
