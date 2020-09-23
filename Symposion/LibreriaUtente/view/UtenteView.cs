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
    public partial class UtenteView : Form
    {
        private string _addr;
        private string _username;
        private string _searching;
        private SchedaUtente _schedaUtente;

        public UtenteView(string addr, string localUser, string searching)
        {
            InitializeComponent();

            _addr = addr;
            _username = localUser;
            _schedaUtente = new SchedaUtente(_username, addr);
            _searching = searching;

            textBoxUsername.Text = searching;

        }

        private void recensioniUtente_Click(object sender, EventArgs e)
        {
            List<Recensione> recensioniTrovate = _schedaUtente.getRecensioni(_searching);

            new ElencoRecensioniUtente(_addr, _username, recensioniTrovate).Show();
            this.Hide();
        }

        private void listeUtente_Click(object sender, EventArgs e)
        {
            List<Lista> listeTrovate = _schedaUtente.getListe(_searching);

            new ElencoListe(_addr, _username, listeTrovate).Show();
            this.Hide();
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }
    }
}
