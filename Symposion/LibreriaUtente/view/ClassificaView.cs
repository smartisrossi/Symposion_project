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
    public partial class ClassificaView : Form
    {
        private string _addr;
        private string _username;

        public ClassificaView(string addr, string username, Libro[] classifica)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            dataGridViewClassifica.ColumnHeadersVisible = false;

            dataGridViewClassifica.Columns[0].HeaderText = "Titolo";
            dataGridViewClassifica.Columns[1].HeaderText = "Autore";
            dataGridViewClassifica.Columns[2].HeaderText = "Anno Pubblicazione";
            dataGridViewClassifica.Columns[3].HeaderText = "Genere";         

            foreach (Libro libro in classifica)
            {
                string titolo = libro.Titolo;
                string autore = libro.Autore;
                string anno = libro.Anno.ToString();
                string genere = libro.Gen.ToString();

                DataGridViewTextBoxCell c = new DataGridViewTextBoxCell();
                int rowIndex = dataGridViewClassifica.Rows.Add(c);
                /*DataGridViewButtonCell b = new DataGridViewButtonCell();
                int rowIndex = dataGridViewClassifica.Rows.Add(b);
                */

                dataGridViewClassifica.Rows[rowIndex].Cells[0].Value = titolo;
                dataGridViewClassifica.Rows[rowIndex].Cells[1].Value = autore;
                dataGridViewClassifica.Rows[rowIndex].Cells[2].Value = anno;
                dataGridViewClassifica.Rows[rowIndex].Cells[3].Value = genere;
            }
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }
    }
}
