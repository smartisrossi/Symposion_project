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
    public partial class SegnalazioniLibriView : Form
    {
        private string _addr;
        private Libro _libro;
        private GestioneSegnalazioneLibro _gestioneSegnalazioneLibro;

        public SegnalazioniLibriView(string addr, Libro libro)
        {
            InitializeComponent();

            _addr = addr;
            _libro = libro;
            _gestioneSegnalazioneLibro = new GestioneSegnalazioneLibro(_addr);            
        }

        private void buttonVediLibro_Click(object sender, EventArgs e)
        {
            new SchedaLibroView(_addr, _libro).Show();
            this.Hide();
        }

        private void buttonAggiornaLibro_Click(object sender, EventArgs e)
        {
            new ModificaLibroView(_addr, _libro).Show();
            this.Hide();
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new HomeAmministratoreView(_addr).Show();
            this.Hide();
        }
    }
}
