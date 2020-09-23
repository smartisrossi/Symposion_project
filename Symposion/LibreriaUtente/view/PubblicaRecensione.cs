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
    public partial class PubblicaRecensione : Form
    {
        private string _addr;
        private string _username;
        private SchedaLibro _schedaLibro;

        public PubblicaRecensione(string addr, string username, SchedaLibro schedaLibro)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;
            _schedaLibro = schedaLibro;
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new SchedaLibroView(_addr, _username, _schedaLibro.Libro).Show();
            this.Hide();
        }

        private void buttonPubblica_Click(object sender, EventArgs e)
        {
            Libro libro = _schedaLibro.Libro;

            int punteggio = -1;

            if (Int32.TryParse(textBoxPunteggio.Text, out punteggio) )
            {
                if (punteggio < 0 || punteggio > 5)
                    System.Windows.Forms.MessageBox.Show("Inserire un punteggio (0-5)");
                else
                {
                    string commento = textBoxCommento.Text;

                    if (commento == null) { _schedaLibro.PubblicaRecensione(punteggio); }
                    else { _schedaLibro.PubblicaRecensione(punteggio, commento); }

                    System.Windows.Forms.MessageBox.Show("Recensione pubblicata!");

                    new SchedaLibroView(_addr, _username, _schedaLibro.Libro).Show();
                    this.Hide();
                }
            }
            else { System.Windows.Forms.MessageBox.Show("Inserire un punteggio (0-5)"); }
            
        }
    }
}
