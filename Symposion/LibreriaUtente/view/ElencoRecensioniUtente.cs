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
    public partial class ElencoRecensioniUtente : Form
    {
        private string _addr;
        private string _username;
        private List<Recensione> _recensioni;
        public ElencoRecensioniUtente(string addr, string username, List<Recensione> recensioni)
        {
            InitializeComponent();
            _addr = addr;
            _username = username;
            _recensioni = recensioni;

            dataGridViewRecensioniUtente.ColumnHeadersVisible = true;
            dataGridViewRecensioniUtente.AllowUserToAddRows = false;

            dataGridViewRecensioniUtente.Columns[0].HeaderText = "Punteggio";
            dataGridViewRecensioniUtente.Columns[1].HeaderText = "Commento";

            dataGridViewRecensioniUtente.Columns[2].Visible = false;

            string commento = "";
            if (recensioni != null)
            {
                foreach (Recensione rec in recensioni)
                {
                    int punteggio = rec.Punteggio;
                    commento = rec.Commento;

                    Libro libro = rec.Libro;


                    DataGridViewButtonCell b = new DataGridViewButtonCell();
                    int rowIndex = dataGridViewRecensioniUtente.Rows.Add(b);

                    dataGridViewRecensioniUtente.Rows[rowIndex].Cells[0].Value = punteggio;
                    dataGridViewRecensioniUtente.Rows[rowIndex].Cells[1].Value = commento;
                    dataGridViewRecensioniUtente.Rows[rowIndex].Cells[2].Value = libro;
                    dataGridViewRecensioniUtente.Rows[rowIndex].Cells[3].Value = rec;

                }
            }
        }

        private void dataGridViewRecensioni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridViewRecensioniUtente.CurrentCell != null && dataGridViewRecensioniUtente.CurrentCell.Value != null)
                {
                    int punteggio = (int)dataGridViewRecensioniUtente.Rows[e.RowIndex].Cells[0].Value;
                    string commento = (string)dataGridViewRecensioniUtente.Rows[e.RowIndex].Cells[1].Value;

                    Libro libro = (Libro)dataGridViewRecensioniUtente.Rows[e.RowIndex].Cells[2].Value;
                    Recensione r = (Recensione)dataGridViewRecensioniUtente.Rows[e.RowIndex].Cells[3].Value;

                    new RecensioneView(_addr, _username, r).Show();
                    this.Hide();
                }
            }
        }
    }
}
