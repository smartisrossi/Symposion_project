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
    public partial class ModificaRecensione : Form
    {
        private string _addr;
        private string _username;
        private Recensione _r;
        private LeMieRecensioni _leMieRecensioni;


        public ModificaRecensione(string addr, string username, Recensione r, LeMieRecensioni leMieRecensioni)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            _r = r;

            textBoxPunteggio.Text = _r.Punteggio.ToString();
            textBoxCommento.Text = _r.Commento;

            
            _leMieRecensioni = leMieRecensioni;
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new LaMiaLibreriaView(_addr, _username).Show();
            this.Hide();
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            string punteggioString = textBoxPunteggio.Text;
            string commento = textBoxCommento.Text;

            int punteggio;

            if (Int32.TryParse(punteggioString, out punteggio))
            {
                if (punteggio < 0 || punteggio > 5)
                    System.Windows.Forms.MessageBox.Show("Inserire un punteggio (0-5)");
                else
                {
                    _r.Punteggio = punteggio;
                    _r.Commento = commento;
                    _leMieRecensioni.ModificaRecensione(_r);

                    System.Windows.Forms.MessageBox.Show("Recensione modificata!");

                    new LaMiaLibreriaView(_addr, _username).Show();
                    this.Hide();
                }
            }
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            _r.Punteggio = -1;
            _r.Commento = null;
            _leMieRecensioni.ModificaRecensione(_r);

            System.Windows.Forms.MessageBox.Show("Recensione eliminata!");

            new LaMiaLibreriaView(_addr, _username).Show();
            this.Hide();
        }
    }
}
