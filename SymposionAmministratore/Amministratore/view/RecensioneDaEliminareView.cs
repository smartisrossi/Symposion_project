using Progetto_Symposion;
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
    public partial class RecensioneDaEliminareView : Form
    {
        private string _addr;
        private Recensione _review;
        private Dictionary<DateTime, int> _dt;

        private GestioneSegnalazioneRecensione _segnalazioneRecensione;


        public RecensioneDaEliminareView(string addr, Recensione rec, Dictionary<DateTime, int> dt)
        {
            InitializeComponent();

            _addr = addr;
            _review = rec;
            _dt = dt;

            textBoxIDRecensione.Text = _review.Id.ToString();
            textBoxLibro.Text = _review.Libro.Titolo + ", " + _review.Libro.Autore +
                " (" + _review.Libro.Anno + ") " + _review.Libro.Gen;
            textBoxPunteggio.Text = _review.Punteggio.ToString();
            textBoxCommento.Text = _review.Commento;

            _segnalazioneRecensione = new GestioneSegnalazioneRecensione(_addr);
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new HomeAmministratoreView(_addr).Show();
            this.Hide();
        }

        private void buttonProssimaRecensione_Click(object sender, EventArgs e)
        {
            if (_dt.Count > 0)
            {
                var first = _dt.First();
                DateTime key = first.Key;
                int id = _dt[key];
                _dt.Remove(key);
                Recensione r = _segnalazioneRecensione.GetRecensione(id);

                new RecensioneDaEliminareView(_addr, r, _dt).Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Non ci sono recensioni scadute");
            }
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            _segnalazioneRecensione.EliminaRecensione(_review);
            if (_dt.Count > 0)
            {
                var first = _dt.First();
                DateTime key = first.Key;
                int id = _dt[key];
                _dt.Remove(key);
                Recensione r = _segnalazioneRecensione.GetRecensione(id);

                System.Windows.Forms.MessageBox.Show("Recensione eliminata");
                new RecensioneDaEliminareView(_addr, r, _dt).Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Recensione eliminata");
                System.Windows.Forms.MessageBox.Show("Non ci sono altre recensioni");
            }
        }
    }
}
