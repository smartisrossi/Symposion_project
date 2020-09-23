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
    public partial class ElencoLibri : Form
    {
        private string _addr;
        private string _username;

        public ElencoLibri(string addr, string username, List<Libro> libri)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            dataGridViewLibri.ColumnHeadersVisible = true;
            dataGridViewLibri.AllowUserToAddRows = false;

            dataGridViewLibri.Columns[0].HeaderText = "Titolo";
            dataGridViewLibri.Columns[1].HeaderText = "Autore";
            dataGridViewLibri.Columns[2].HeaderText = "Anno Pubblicazione";
            dataGridViewLibri.Columns[3].HeaderText = "Genere";

            dataGridViewLibri.Columns[4].Visible = false;

            if (libri != null)
            {
                foreach (Libro libro in libri)
                {
                    string titolo = libro.Titolo;
                    string autore = libro.Autore;
                    string anno = libro.Anno.ToString();
                    string genere = libro.Gen.ToString();
                    string filePath = libro.FilePath;


                    DataGridViewButtonCell b = new DataGridViewButtonCell();
                    int rowIndex = dataGridViewLibri.Rows.Add(b);

                    dataGridViewLibri.Rows[rowIndex].Cells[0].Value = titolo;
                    dataGridViewLibri.Rows[rowIndex].Cells[1].Value = autore;
                    dataGridViewLibri.Rows[rowIndex].Cells[2].Value = anno;
                    dataGridViewLibri.Rows[rowIndex].Cells[3].Value = genere;
                    dataGridViewLibri.Rows[rowIndex].Cells[4].Value = filePath;

                }
            }
        }

        private void dataGridViewLibri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridViewLibri.CurrentCell != null && dataGridViewLibri.CurrentCell.Value != null)
                {
                    string titolo = (string)dataGridViewLibri.Rows[e.RowIndex].Cells[0].Value;
                    string autore = (string)dataGridViewLibri.Rows[e.RowIndex].Cells[1].Value;
                    string anno = (string)dataGridViewLibri.Rows[e.RowIndex].Cells[2].Value;
                    string genere = (string)dataGridViewLibri.Rows[e.RowIndex].Cells[3].Value;
                    string filePath = (string)dataGridViewLibri.Rows[e.RowIndex].Cells[4].Value;

                    Libro libro;
                    genere gen;
                    Enum.TryParse<genere>(genere, out gen);

                    if (filePath == null)
                    {
                        libro = new Libro()
                        {
                            Titolo = titolo,
                            Autore = autore,
                            Anno = Int32.Parse(anno),
                            Gen = gen
                        };
                    }
                    else
                    {
                        libro = new Libro()
                        {
                            Titolo = titolo,
                            Autore = autore,
                            Anno = Int32.Parse(anno),
                            Gen = gen,
                            FilePath = filePath
                        };
                    }


                    new SchedaLibroView(_addr, _username, libro).Show();
                    this.Hide();
                }
            }
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }
    }
}