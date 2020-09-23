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
    public partial class ElencoRecensioni : Form
    {
        private string _addr;
        private string _username;
        private List<Recensione> _recensioni;
        private RicercaPubblica _ricerca;
        private Libro _schedaLibro;

        public ElencoRecensioni(string addr, string username, List<Recensione> recensioni, Libro schedaLibro)
        {
            InitializeComponent();

            //Timer
            timer.Interval = 60000;
            timer.Start();
            timer.Tick += timer_Tick;

            _addr = addr;
            _username = username;
            _ricerca = new RicercaPubblica(addr, username);
            _schedaLibro = schedaLibro;

            dataGridViewRecensioni.ColumnHeadersVisible = true;
            dataGridViewRecensioni.AllowUserToAddRows = false;

            dataGridViewRecensioni.Columns[0].HeaderText = "Punteggio";
            dataGridViewRecensioni.Columns[1].HeaderText = "Commento";

            dataGridViewRecensioni.Columns[2].Visible = false;

            string commento = "";
            if (recensioni != null)
            {
                foreach (Recensione rec in recensioni)
                {
                    int punteggio = rec.Punteggio;
                    commento = rec.Commento;

                    Libro libro = rec.Libro;


                    DataGridViewButtonCell b = new DataGridViewButtonCell();
                    int rowIndex = dataGridViewRecensioni.Rows.Add(b);

                    dataGridViewRecensioni.Rows[rowIndex].Cells[0].Value = punteggio;
                    dataGridViewRecensioni.Rows[rowIndex].Cells[1].Value = commento;
                    dataGridViewRecensioni.Rows[rowIndex].Cells[2].Value = libro;
                    dataGridViewRecensioni.Rows[rowIndex].Cells[3].Value = rec;

                }
            }
        }

        private void dataGridViewRecensioni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridViewRecensioni.CurrentCell != null && dataGridViewRecensioni.CurrentCell.Value != null)
                {
                    int punteggio = (int)dataGridViewRecensioni.Rows[e.RowIndex].Cells[0].Value;
                    string commento = (string)dataGridViewRecensioni.Rows[e.RowIndex].Cells[1].Value;
                    Libro libro = (Libro)dataGridViewRecensioni.Rows[e.RowIndex].Cells[2].Value;
                    Recensione r = (Recensione)dataGridViewRecensioni.Rows[e.RowIndex].Cells[3].Value;

                    new RecensioneView(_addr, _username, r).Show();
                    this.Hide();
                }
            }
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new SchedaLibroView(_addr, _username, _schedaLibro).Show();
            this.Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            List<Recensione> recensioni = _ricerca.CercaRecensioniLibro(_schedaLibro);
            new ElencoRecensioni(_addr, _username, _recensioni, _schedaLibro).Show();
            this.Hide();
        }
    }
}
