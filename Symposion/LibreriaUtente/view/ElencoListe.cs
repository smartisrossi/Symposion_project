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
    public partial class ElencoListe : Form
    {
        private string _addr;
        private string _username;

        public ElencoListe(string addr, string username, List<Lista> liste)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            dataGridViewListe.ColumnHeadersVisible = false;
            dataGridViewListe.AllowUserToAddRows = false;

            dataGridViewListe.Columns[2].Visible = false;
            dataGridViewListe.Columns[3].Visible = false;

            if (liste != null)
            {
                foreach (Lista lista in liste)
                {
                    string nome = lista.Nome;
                    string genere = lista.Gen.ToString();

                    List<Libro> libri = lista.ListaLibri.ToList<Libro>();


                    DataGridViewButtonCell b = new DataGridViewButtonCell();
                    int rowIndex = dataGridViewListe.Rows.Add(b);

                    dataGridViewListe.Rows[rowIndex].Cells[0].Value = nome;
                    dataGridViewListe.Rows[rowIndex].Cells[1].Value = genere;
                    dataGridViewListe.Rows[rowIndex].Cells[2].Value = libri;
                    dataGridViewListe.Rows[rowIndex].Cells[3].Value = lista;
                }
            }
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }

        private void dataGridViewListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridViewListe.CurrentCell != null && dataGridViewListe.CurrentCell.Value != null)
                {
                    Lista lista = (Lista)dataGridViewListe.Rows[e.RowIndex].Cells[3].Value;

                    new ListaPubblicaView(_addr, _username, lista).Show();
                    this.Hide();
                }
            }
        }
    }
}
