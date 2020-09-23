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
    public partial class ModificaLista : Form
    {
        private string _addr;
        private string _username;
        private LeMieListe _leMieListe;
        private Lista _lista;
        private List<Libro> _libriDaEliminare = new List<Libro>();

        public ModificaLista(string addr, string username, LeMieListe leMieListe, Lista lista)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;
            _leMieListe = leMieListe;
            _lista = lista;

            textBoxNome.Text = _lista.Nome;
            comboBoxGeneri.SelectedIndex = comboBoxGeneri.FindString(_lista.Gen.ToString());

            dataGridViewLibri.ColumnHeadersVisible = false;
            dataGridViewLibri.AllowUserToAddRows = false;

            dataGridViewLibri.Columns[0].HeaderText = "Titolo";
            dataGridViewLibri.Columns[1].HeaderText = "Autore";
            dataGridViewLibri.Columns[2].HeaderText = "Anno Pubblicazione";
            dataGridViewLibri.Columns[3].HeaderText = "Genere";

            dataGridViewLibri.Columns[4].Visible = false;

            if (_lista.ListaLibri != null)
            {
                foreach (Libro libro in _lista.ListaLibri)
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

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new LaMiaLibreriaView(_addr, _username).Show();
            this.Hide();
        }

        private void buttonSalva_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string genereString = comboBoxGeneri.Text;
            

            if (nome == null)
                System.Windows.Forms.MessageBox.Show("Il nome non può essere nullo");
            else if (genereString == null)
                System.Windows.Forms.MessageBox.Show("Selezionare un genere");
            else
            {
                genere gen;
                Enum.TryParse<genere>(genereString, out gen);
                Lista listaNew = new Lista
                {
                    Nome = nome,
                    Gen = gen,
                    IsVisibile = _lista.IsVisibile,
                    Username = _lista.Username,
                    Id = _lista.Id
                };
                List<Libro> listaLibriNew = new List<Libro>();
                foreach (Libro l in _lista.ListaLibri)
                    foreach(Libro daEliminare in _libriDaEliminare)
                        if (!l.Titolo.Equals(daEliminare.Titolo) && !l.Autore.Equals(daEliminare.Autore))
                        {
                            listaLibriNew.Add(l);
                        }
                listaNew.ListaLibri = listaLibriNew.ToArray();
                _leMieListe.ModificaListaPersonale(listaNew);

                new LaMiaLibreriaView(_addr, _username).Show();
                this.Hide();
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
                    _libriDaEliminare.Add(libro);

                    System.Windows.Forms.MessageBox.Show("Libro eliminato dalla lista");

                }
            }
        }

        private void buttonElimina_Click(object sender, EventArgs e)
        {
            Lista listaNew = new Lista
            {
                Nome = null,
                Gen = _lista.Gen,
                IsVisibile = _lista.IsVisibile,
                Username = _lista.Username,
                Id = _lista.Id
            };
            _leMieListe.ModificaListaPersonale(listaNew);

            new LaMiaLibreriaView(_addr, _username).Show();
            this.Hide();
        }
    }
}
