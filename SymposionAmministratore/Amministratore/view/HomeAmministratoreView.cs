using Progetto_Symposion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amministratore
{
    public partial class HomeAmministratoreView : Form
    {
        private string _addr;

        private GestioneSegnalazioneLibro _segnalazioneLibro;
        private GestioneSegnalazioneRecensione _segnalazioneRecensione;
        private RecensioniScadute _recensioniScadute;
        private HomeAmministratore _homeAmministratore;


        public HomeAmministratoreView(string addr)
        {
            InitializeComponent();

            _addr = addr;

            _segnalazioneLibro = new GestioneSegnalazioneLibro(_addr);
            _segnalazioneRecensione = new GestioneSegnalazioneRecensione(_addr);
            _recensioniScadute = new RecensioniScadute(_addr);
            _homeAmministratore = new HomeAmministratore(_addr);
        }

        /*private void bunifuImageButtonConfigurazioni_MouseHover(object sender, EventArgs e)
        {

            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.bunifuImageButtonConfigurazioni, "Gestione Configurazioni");
        }*/

        private void bunifuImageButtonConfigurazioni_Click(object sender, EventArgs e)
        {
            new GestioneConfigurazioniView(_addr).Show();
            this.Hide();
        }

        private void buttonSegnalazioneRecensioni_Click(object sender, EventArgs e)
        {
            SegnalazioneRecensione sr = _homeAmministratore.GetSegnalazioneRecensione();
            if (sr != null)
            {
                new RecensioneSegnalataView(_addr, sr.Recensione).Show();
                this.Hide();
            }
            else
                System.Windows.Forms.MessageBox.Show("Non ci sono segnalazioni di recensioni");
        }

        private void buttonSegnalazioniLibri_Click(object sender, EventArgs e)
        {
            SegnalazioneLibro sl = _homeAmministratore.GetSegnalazioneLibro();
            if (sl != null)
            {
                new SegnalazioniLibriView(_addr, sl.Libro).Show();
                this.Hide();
            }
            else
                System.Windows.Forms.MessageBox.Show("Non ci sono segnalazioni di libri");
        }

        private void bunifuImageButtonLogout_Click(object sender, EventArgs e)
        {
            new HomeView().Show();
            this.Hide();
        }

        private void bunifuImageButtonRecensioniScadute_Click(object sender, EventArgs e)
        {
            Dictionary<DateTime, int> dt = _recensioniScadute.GetListaRecensioni();
            if (dt.Count > 0)
            {
                var first = dt.First();
                DateTime key = first.Key;
                int id = dt[key];
                dt.Remove(key);
                Recensione r = _segnalazioneRecensione.GetRecensione(id);

                new RecensioneDaEliminareView(_addr, r, dt).Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Non ci sono recensioni scadute");
            }
        }

    }
}
