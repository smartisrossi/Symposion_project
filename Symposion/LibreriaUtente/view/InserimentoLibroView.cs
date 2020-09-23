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

namespace Libreria
{
    public partial class InserimentoLibroView : Form
    {
        private string _addr;
        private string _username;
        private InserimentoLibro _inserimentoLibro;
        private string _fileName = null;

        public InserimentoLibroView(string addr, string username)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            openFileDialogCopertina.ValidateNames = false;
            _inserimentoLibro = new InserimentoLibro(_addr, _username);
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }

        private void buttonScegliFile_Click(object sender, EventArgs e)
        {

            DialogResult result = openFileDialogCopertina.ShowDialog(); // Show the dialog.


            if (result == DialogResult.OK) // Test result.
            {
                _fileName = openFileDialogCopertina.FileName;
            }
        }


        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            string titolo = textBoxTitolo.Text;
            string autore = textBoxAutore.Text;
            string annoString = textBoxAnnoPubblicazione.Text;
            string genere = comboBoxGeneri.Text;

            if (String.IsNullOrEmpty(titolo))
                System.Windows.Forms.MessageBox.Show("Il titolo non può essere nullo");
            else if (String.IsNullOrEmpty(autore))
                System.Windows.Forms.MessageBox.Show("L'autore non può essere nullo");
            else if (String.IsNullOrEmpty(annoString))
                System.Windows.Forms.MessageBox.Show("L'anno di pubblicazione non può essere nullo");
            else if (String.IsNullOrEmpty(genere))
                System.Windows.Forms.MessageBox.Show("Selezionare un genere");
            int anno = 0;
            try
            {
                anno = Int32.Parse(annoString);
                if (_fileName == null) { _inserimentoLibro.InserisciLibro(titolo, autore, anno, genere); }
                else { _inserimentoLibro.InserisciLibro(titolo, autore, anno, genere, _fileName); }

                System.Windows.Forms.MessageBox.Show("Libro inserito con successo!");

                new Salotto(_addr, _username).Show();
                this.Hide();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("L'anno di pubblicazione non un numero");
            }
            
        }

        private void borderLabelCopertina_Click(object sender, EventArgs e)
        {

        }
    }
}
