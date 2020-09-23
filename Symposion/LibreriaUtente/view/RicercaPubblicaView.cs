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
    public partial class RicercaPubblicaView : Form
    {
        private string _addr;
        private string _username;

        private RicercaPubblica _ricerca;

        public RicercaPubblicaView(string addr, string username)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            _ricerca = new RicercaPubblica(_addr, _username);

        }

        //Cerca utente ----------------------------------------------------------------
        private void buttonUtente_Click(object sender, EventArgs e)
        {
            string username = textBoxCercaUtente.text;

            string utente = _ricerca.CercaUtente(username);

            new UtenteView(_addr, _username, utente).Show();
            this.Hide();
        }

        //Cerca genere ----------------------------------------------------------------
        private void buttonGenere_Click(object sender, EventArgs e)
        {
            string genereString = textBoxCercaGenere.text;
            genere genProva;
            if (Enum.TryParse<genere>(genereString, out genProva))
            {
                List<Libro> libriTrovati = _ricerca.CercaGenere(genereString);

                new ElencoLibri(_addr, _username, libriTrovati).Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Genere non valido! Generi possibili:\nAvventura\nClassici\nFantascienza\nFantasy\nGiallo\nHorror\nPersonale\nRomanzo\nThriller\nUmorismo ");
            }
        }

        //Cerca lista -----------------------------------------------------------------
        private void buttonLista_Click(object sender, EventArgs e)
        {
            string nome = textBoxCercaLista.text;

            List<Lista> listeTrovate = _ricerca.CercaLista(nome);
            
            new ElencoListe(_addr, _username, listeTrovate).Show();
            this.Hide();
        }

        //Cerca libro -----------------------------------------------------------------
        private void buttonLibro_Click(object sender, EventArgs e)
        {
            string titolo = textBoxCercaLibro.text;

            List<Libro> libriTrovati = _ricerca.CercaLibro(titolo);
             
            new ElencoLibri(_addr, _username, libriTrovati).Show();
            this.Hide();
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }
    }
}
