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
    public partial class ListaVisualizzazione : Form
    {
        private string _addr;
        private string _username;

        public ListaVisualizzazione(string addr, string username, string nomeLista, string genereLista, List<Libro> libri)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            dataGridViewLibriLista.ColumnHeadersVisible = true;
            dataGridViewLibriLista.AllowUserToAddRows = false;

            dataGridViewLibriLista.Columns[0].HeaderText = "Titolo";
            dataGridViewLibriLista.Columns[1].HeaderText = "Autore";
            dataGridViewLibriLista.Columns[2].HeaderText = "Anno Pubblicazione";
            dataGridViewLibriLista.Columns[3].HeaderText = "Genere";

            //caricamento liste -> controller: get 

            textBoxNomeLista.Text = nomeLista;
            textBoxGenereLista.Text = genereLista;

            foreach (Libro libro in libri)
            {
                string titolo = libro.Titolo;
                string autore = libro.Autore;
                string anno = libro.Anno.ToString();
                string genere = libro.Gen.ToString();


                DataGridViewButtonCell b = new DataGridViewButtonCell();
                int rowIndex = dataGridViewLibriLista.Rows.Add(b);

                dataGridViewLibriLista.Rows[rowIndex].Cells[0].Value = titolo;
                dataGridViewLibriLista.Rows[rowIndex].Cells[1].Value = autore;
                dataGridViewLibriLista.Rows[rowIndex].Cells[2].Value = anno;
                dataGridViewLibriLista.Rows[rowIndex].Cells[3].Value = genere;
            }
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new LaMiaLibreriaView(_addr, _username).Show();
            this.Hide();
        }
    }
}
