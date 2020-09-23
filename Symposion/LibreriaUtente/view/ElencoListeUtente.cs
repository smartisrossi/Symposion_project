using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progetto_Symposion;

namespace Libreria
{
    public partial class ElencoListeUtente : Form
    {
        private LeMieListe _leMieListe;
        private string _addr;
        private string _username;
        private Libro _libro;
        private List<Lista> _liste;


        public ElencoListeUtente(string addr, string username, Libro libro, List<Lista> liste)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            _libro = libro;
            _liste = liste;

            dataGridViewListe.ColumnHeadersVisible = false;
            dataGridViewListe.AllowUserToAddRows = false;

            //dataGridViewListe.Columns[0].HeaderText = "Aggiungi";
            //dataGridViewListe.Columns[1].HeaderText = "Nome Lista";
            //dataGridViewListe.Columns[2].HeaderText = "Genere";
            
            dataGridViewListe.Columns[3].Visible = false;


            string nome = "";
            if (_liste != null)
            {
                foreach (Lista lista in _liste)
                {
                    nome = lista.Nome;
                    string genere = lista.Gen.ToString();

                    DataGridViewButtonCell b = new DataGridViewButtonCell();
                    int rowIndex = dataGridViewListe.Rows.Add(b);

                    dataGridViewListe.Rows[rowIndex].Cells[0].Value = "Aggiungi";
                    dataGridViewListe.Rows[rowIndex].Cells[1].Value = nome;
                    dataGridViewListe.Rows[rowIndex].Cells[2].Value = genere;
                    dataGridViewListe.Rows[rowIndex].Cells[3].Value = lista;

                }
            }

            _addr = addr;
            _username = username;
            _libro = libro;

            _leMieListe = new LeMieListe(_username, _addr);
        }

        private void dataGridViewListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListe.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridViewListe.CurrentCell != null && dataGridViewListe.CurrentCell.Value != null)
                {
                    Lista list = (Lista)dataGridViewListe.Rows[e.RowIndex].Cells[3].Value;
                    List<Libro> listaLibri = list.ListaLibri.ToList<Libro>();
                    listaLibri.Add(_libro);
                    list.ListaLibri = listaLibri.ToArray<Libro>();
                    _leMieListe.ModificaListaPersonale(list);

                    System.Windows.Forms.MessageBox.Show("Libro aggiunto alla lista!");

                    new SchedaLibroView(_addr, _username, _libro).Show();
                    this.Hide();
                }
            }

            else { }
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new SchedaLibroView(_addr, _username, _libro).Show();
            this.Hide();
        }
    }
}
