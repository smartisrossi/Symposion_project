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
    public partial class CreazioneLista : Form
    {
        private string _addr;
        private string _username;
        private LeMieListe _leMieListe;

        public CreazioneLista(string addr, string username, LeMieListe leMieListe)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;
            _leMieListe = leMieListe;
        }

        private void buttonCrea_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string genere = comboBoxGeneri.Text;
            if (nome == null)
                System.Windows.Forms.MessageBox.Show("Il nome non può essere nullo");
            else if (genere == null)
                System.Windows.Forms.MessageBox.Show("Selezionare un genere");
            else
            {
                _leMieListe.CreaListaPersonale(nome, genere);
                System.Windows.Forms.MessageBox.Show("Lista creata con successo");

                new LaMiaLibreriaView(_addr, _username).Show();
                this.Hide();
            }
        }
        
        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new LaMiaLibreriaView(_addr, _username).Show();
            this.Hide();
        }
    }
}
