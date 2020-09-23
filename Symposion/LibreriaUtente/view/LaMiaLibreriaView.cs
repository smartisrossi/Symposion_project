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
    public partial class LaMiaLibreriaView : Form
    {
        private string _addr;
        private string _username;

        private LaMiaLibreria _laMiaLibreria;

        private LeMieListe _leMieListe;
        private LeMieRecensioni _leMieRecensioni;
        private ListeSalvate _listePreferite;
        private RecensioniSalvate _recensioniPreferite;
        
        public LaMiaLibreriaView(string addr, string username)
        {
            InitializeComponent();

            _laMiaLibreria = new LaMiaLibreria(username, addr);
            Init();

            _addr = addr;
            _username = username;

            _leMieListe = new LeMieListe(_username, addr);
            _leMieRecensioni = new LeMieRecensioni(_username, addr);
            _listePreferite = new ListeSalvate(_username, addr);
            _recensioniPreferite = new RecensioniSalvate(_username, addr);
        }

        //SALOTTO ---------------------------------------------------------------------
        private void buttonSalotto_Click(object sender, EventArgs e)
        {
            new Salotto(_addr, _username).Show();
            this.Hide();
        }

        //LE MIE LISTE ----------------------------------------------------------------
        private void buttonLeMieListe_Click(object sender, EventArgs e)
        {
            bunifuGradientPanelIndiceMiaLibreria.Visible = true;

            bunifuGradientPanelLeMieListe.Visible = true;
            panelListePreferite.Visible = false;
            panelLeMieRecensioni.Visible = false;
            panelRecensioniPreferite.Visible = false;
        }

        private void dataGridViewLeMieListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLeMieListe.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridViewLeMieListe.CurrentCell != null && dataGridViewLeMieListe.CurrentCell.Value != null)
                {
                    Lista lista = (Lista)dataGridViewLeMieListe.Rows[e.RowIndex].Cells[3].Value;
                    _leMieListe.PubblicaListaPersonale(lista);
                    System.Windows.Forms.MessageBox.Show("Lista pubblicata!");
                }
            }

            if (dataGridViewLeMieListe.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dataGridViewLeMieListe.CurrentCell != null && dataGridViewLeMieListe.CurrentCell.Value != null)
                {
                    Lista lista = (Lista)dataGridViewLeMieListe.Rows[e.RowIndex].Cells[3].Value;

                    new ModificaLista(_addr, _username, _leMieListe, lista).Show();
                    this.Hide();
                }
            }

            if (dataGridViewLeMieListe.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if (dataGridViewLeMieListe.CurrentCell != null && dataGridViewLeMieListe.CurrentCell.Value != null)
                {
                    Lista lista = (Lista)dataGridViewLeMieListe.Rows[e.RowIndex].Cells[3].Value;

                    new ListaVisualizzazione(_addr, _username, lista.Nome, lista.Gen.ToString(), lista.ListaLibri.ToList<Libro>()).Show();
                    this.Hide();
                }

            }
            else { }
        }

        private void bunifuImageButtonCreaLista_Click(object sender, EventArgs e)
        {
            new CreazioneLista(_addr, _username, _leMieListe).Show();
            this.Hide();
        }

        //LISTE PREFERITE -------------------------------------------------------------
        private void buttonListePreferite_Click(object sender, EventArgs e)
        {
            bunifuGradientPanelIndiceMiaLibreria.Visible = true;

            bunifuGradientPanelLeMieListe.Visible = false;
            panelListePreferite.Visible = true;
            panelLeMieRecensioni.Visible = false;
            panelRecensioniPreferite.Visible = false;
        }
        private void dataGridViewListePreferite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListePreferite.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridViewListePreferite.CurrentCell != null && dataGridViewListePreferite.CurrentCell.Value != null)
                {
                    Lista list = (Lista)dataGridViewListePreferite.Rows[e.RowIndex].Cells[2].Value;

                    _listePreferite.RimuoviLista(list);
                    new LaMiaLibreriaView(_addr, _username).Show();
                    this.Hide();
                }
            }

            if (dataGridViewListePreferite.CurrentCell.ColumnIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dataGridViewListePreferite.CurrentCell != null && dataGridViewListePreferite.CurrentCell.Value != null)
                {
                    Lista list = (Lista)dataGridViewListePreferite.Rows[e.RowIndex].Cells[2].Value;

                    new ListaVisualizzazione(_addr, _username, list.Nome, list.Gen.ToString(), list.ListaLibri.ToList<Libro>()).Show();
                    this.Hide();

                }
            }
            else { }
        }

        //LE MIE RECENSIONI -----------------------------------------------------------
        private void buttonLeMieRecensioni_Click(object sender, EventArgs e)
        {
            bunifuGradientPanelIndiceMiaLibreria.Visible = true;

            bunifuGradientPanelLeMieListe.Visible = false;
            panelListePreferite.Visible = false;
            panelLeMieRecensioni.Visible = true;
            panelRecensioniPreferite.Visible = false;
        }

        private void dataGridViewLeMieRecensioni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLeMieRecensioni.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridViewLeMieRecensioni.CurrentCell != null && dataGridViewLeMieRecensioni.CurrentCell.Value != null)
                {
                    Recensione r = (Recensione)dataGridViewLeMieRecensioni.Rows[e.RowIndex].Cells[4].Value;

                    new ModificaRecensione(_addr, _username, r, _leMieRecensioni).Show();
                    this.Hide();
                }
            }

            else { }
        }

        //RECENSIONI PREFERITE --------------------------------------------------------
        private void buttonRecensioniPreferite_Click(object sender, EventArgs e)
        {
            bunifuGradientPanelIndiceMiaLibreria.Visible = true;

            bunifuGradientPanelLeMieListe.Visible = false;
            panelListePreferite.Visible = false;
            panelLeMieRecensioni.Visible = false;
            panelRecensioniPreferite.Visible = true;
        }

        private void dataGridViewRecensioniPreferite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRecensioniPreferite.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridViewRecensioniPreferite.CurrentCell != null && dataGridViewRecensioniPreferite.CurrentCell.Value != null)
                {
                    Recensione r = (Recensione)dataGridViewRecensioniPreferite.Rows[e.RowIndex].Cells[4].Value;
                    _recensioniPreferite.RimuoviRecensione(r);

                    new LaMiaLibreriaView(_addr, _username).Show();
                    this.Hide();
                }
            }

            else { }
        }




        //Inizializzazione view 
        private void Init()
        {

            //Le mie liste ------------------------------------------------------------

            dataGridViewLeMieListe.ColumnHeadersVisible = false;
            dataGridViewLeMieListe.AllowUserToAddRows = false;

            dataGridViewLeMieListe.Columns[3].Visible = false;

            List<Lista> leMieListe = _laMiaLibreria.GetLeMieListe();

            string nome = "";

            foreach (Lista lista in leMieListe)
            {
                nome = lista.Nome;

                DataGridViewButtonCell b = new DataGridViewButtonCell();
                int rowIndex = dataGridViewLeMieListe.Rows.Add(b);

                dataGridViewLeMieListe.Rows[rowIndex].Cells[0].Value = "Pubblica";
                dataGridViewLeMieListe.Rows[rowIndex].Cells[1].Value = "Modifica";
                dataGridViewLeMieListe.Rows[rowIndex].Cells[2].Value = nome;
                dataGridViewLeMieListe.Rows[rowIndex].Cells[3].Value = lista;
            }

           

            //Liste preferite ---------------------------------------------------------

            dataGridViewListePreferite.ColumnHeadersVisible = false;
            dataGridViewListePreferite.AllowUserToAddRows = false;

            dataGridViewListePreferite.Columns[2].Visible = false;

            List<Lista> leMieListePreferite = _laMiaLibreria.GetListePreferite();

            nome = "";
            foreach (Lista lista in leMieListePreferite)
            {
                nome = lista.Nome;


                DataGridViewButtonCell b = new DataGridViewButtonCell();
                int rowIndex = dataGridViewListePreferite.Rows.Add(b);

                dataGridViewListePreferite.Rows[rowIndex].Cells[0].Value = "Elimina";
                dataGridViewListePreferite.Rows[rowIndex].Cells[1].Value = nome;
                dataGridViewListePreferite.Rows[rowIndex].Cells[2].Value = lista;
            }

            //Le mie recensioni -------------------------------------------------------

            dataGridViewLeMieRecensioni.ColumnHeadersVisible = false;
            dataGridViewLeMieRecensioni.AllowUserToAddRows = false;

            

            dataGridViewLeMieRecensioni.Columns[0].HeaderText = "Modifica";
            dataGridViewLeMieRecensioni.Columns[1].HeaderText = "Punteggio";
            dataGridViewLeMieRecensioni.Columns[2].HeaderText = "Libro";
            dataGridViewLeMieRecensioni.Columns[3].HeaderText = "Commento";

            dataGridViewLeMieRecensioni.Columns[4].Visible = false;

            List<Recensione> leMieRecensioni = _laMiaLibreria.GetLeMieRecensioni();

            string commento = "";
            foreach (Recensione rec in leMieRecensioni)
            {
                commento = rec.Commento;
                string punteggio = rec.Punteggio.ToString();
                string titolo = rec.Libro.Titolo;


                DataGridViewButtonCell b = new DataGridViewButtonCell();
                int rowIndex = dataGridViewLeMieRecensioni.Rows.Add(b);

                dataGridViewLeMieRecensioni.Rows[rowIndex].Cells[0].Value = "Modifica";
                dataGridViewLeMieRecensioni.Rows[rowIndex].Cells[1].Value = punteggio;
                dataGridViewLeMieRecensioni.Rows[rowIndex].Cells[2].Value = titolo;
                dataGridViewLeMieRecensioni.Rows[rowIndex].Cells[3].Value = commento;
                dataGridViewLeMieRecensioni.Rows[rowIndex].Cells[3].Value = commento;
                dataGridViewLeMieRecensioni.Rows[rowIndex].Cells[4].Value = rec;

            }

            //Recensioni preferite ----------------------------------------------------

            dataGridViewRecensioniPreferite.ColumnHeadersVisible = false;
            dataGridViewRecensioniPreferite.AllowUserToAddRows = false;

            dataGridViewRecensioniPreferite.Columns[0].HeaderText = "Elimina";
            dataGridViewRecensioniPreferite.Columns[1].HeaderText = "Punteggio";
            dataGridViewRecensioniPreferite.Columns[2].HeaderText = "Libro";
            dataGridViewRecensioniPreferite.Columns[3].HeaderText = "Commento";

            dataGridViewRecensioniPreferite.Columns[4].Visible = false;

            List<Recensione> recensioniPreferite = _laMiaLibreria.GetRecensioniPreferite();

            string commentoRecPreferita = "";
            foreach (Recensione rec in recensioniPreferite)
            {
                commentoRecPreferita = rec.Commento;
                string punteggio = rec.Punteggio.ToString();
                string titolo = rec.Libro.Titolo;


                DataGridViewButtonCell b = new DataGridViewButtonCell();
                int rowIndex = dataGridViewRecensioniPreferite.Rows.Add(b);

                dataGridViewRecensioniPreferite.Rows[rowIndex].Cells[0].Value = "Elimina";
                dataGridViewRecensioniPreferite.Rows[rowIndex].Cells[1].Value = punteggio;
                dataGridViewRecensioniPreferite.Rows[rowIndex].Cells[2].Value = titolo;
                dataGridViewRecensioniPreferite.Rows[rowIndex].Cells[3].Value = commentoRecPreferita;
                dataGridViewRecensioniPreferite.Rows[rowIndex].Cells[4].Value = rec;
            }
        }
    }
}
