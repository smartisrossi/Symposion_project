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

namespace Libreria
{
    public partial class RecensioneView : Form
    {
        private string _addr;
        private string _username;

        private Libro _libro;
        private SchedaRecensione _schedaRecensione;
        private Recensione _r;

        public RecensioneView(string addr, string username, Recensione r)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;
            _libro = r.Libro;

            _schedaRecensione = new SchedaRecensione(addr, username);
            _r = r;

            textBoxLibro.Text = r.Libro.Titolo;
            textBoxPunteggio.Text = r.Punteggio.ToString();
            textBoxCommento.Text = r.Commento;
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new SchedaLibroView(_addr, _username, _libro).Show();
            this.Hide();
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            _schedaRecensione.SalvaRecensione(_r);

            System.Windows.Forms.MessageBox.Show("Recensione salvata!");

            new SchedaLibroView(_addr, _username, _libro).Show();
            this.Hide();
        }

        private void buttonSegnala_Click(object sender, EventArgs e)
        {
            _schedaRecensione.SegnalaRecensione(_r);

            System.Windows.Forms.MessageBox.Show("Recensione segnalata!");

            new SchedaLibroView(_addr, _username, _libro).Show();
            this.Hide();
        }
    }
}
