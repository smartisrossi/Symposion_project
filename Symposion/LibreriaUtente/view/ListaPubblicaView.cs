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
    public partial class ListaPubblicaView : Form
    {
        private string _addr;
        private string _username;
        private ListaPubblica _listaPubblica;

        private Lista _lista;

        public ListaPubblicaView(string addr, string username, Lista lista)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;
            _lista = lista;

            _listaPubblica = new ListaPubblica(addr, username);

            dataGridViewLibriLista.ColumnHeadersVisible = true;
            dataGridViewLibriLista.AllowUserToAddRows = false;

            dataGridViewLibriLista.Columns[0].HeaderText = "Titolo";
            dataGridViewLibriLista.Columns[1].HeaderText = "Autore";
            dataGridViewLibriLista.Columns[2].HeaderText = "Anno Pubblicazione";
            dataGridViewLibriLista.Columns[3].HeaderText = "Genere";

            textBoxNomeLista.Text = _lista.Nome;
            textBoxGenereLista.Text = _lista.Gen.ToString();

            foreach (Libro libro in _lista.ListaLibri)
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
            new Salotto(_addr, _username).Show();
            this.Hide();
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            _listaPubblica.SalvaLista(_lista);

            System.Windows.Forms.MessageBox.Show("La lista è stata salvata");

            new Salotto(_addr, _username).Show();
            this.Hide();
        }
    }
}
