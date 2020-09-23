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
    public partial class RecensioneSegnalataView : Form
    {
        private string _addr;
        private Recensione _review;

        private GestioneSegnalazioneRecensione _gestioneSegnalazioneRecensione;

        public RecensioneSegnalataView(string addr, Recensione review)
        {
            InitializeComponent();

            _addr = addr;
            _review = review;

            _gestioneSegnalazioneRecensione = new GestioneSegnalazioneRecensione(_addr);

            textBoxIDRecensione.Text = _review.Id.ToString();
            textBoxLibro.Text = _review.Libro.Titolo + ", " + _review.Libro.Autore + 
                " (" + _review.Libro.Anno + ") " + _review.Libro.Gen;
            textBoxPunteggio.Text = _review.Punteggio.ToString();
            textBoxCommento.Text = _review.Commento;
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new HomeAmministratoreView(_addr).Show();
            this.Hide();
        }

        private void buttonNotifica_Click(object sender, EventArgs e)
        {
            _gestioneSegnalazioneRecensione.InviaNotifica(_review.Username, _review.Id);

            new HomeAmministratoreView(_addr).Show();
            this.Hide();
        }
    }
}
