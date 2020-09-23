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
    public partial class Salotto : Form
    {
        private string _addr;
        private string _username;
        private Classifiche _classifiche;

        public Salotto(string addr, string username)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            _classifiche = new Classifiche(_addr, _username);
        }

        //LA MIA LIBRERIA -------------------------------------------------------------
        private void buttonLaMiaLibreria_Click(object sender, EventArgs e)
        {
            new LaMiaLibreriaView(_addr, _username).Show();
            this.Hide();
        }

        //CERCA -----------------------------------------------------------------------
        private void bunifuImageButtonCerca_Click(object sender, EventArgs e)
        {
            new RicercaPubblicaView(_addr, _username).Show();
            this.Hide();
        }

        //INSERISCI LIBRO -------------------------------------------------------------
        private void bunifuImageButtonInserisciLibro_Click(object sender, EventArgs e)
        {
            new InserimentoLibroView(_addr, _username).Show();
            this.Hide();
        }

        //LOGOUT ----------------------------------------------------------------------

        private void bunifuImageButtonLogout_Click(object sender, EventArgs e)
        {
            new HomeGestione().Show();
            this.Hide();
        }

        //CONFIGURAZIONI --------------------------------------------------------------
        private void bunifuImageButtonConfigurazione_Click(object sender, EventArgs e)
        {
            new GestioneConfigurazioniView(_addr, _username).Show();
            this.Hide();
        }

        //Classifiche -----------------------------------------------------

        //Generi

        //avventura
        private void buttonChartAvventura_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide();
        }

        //classici
        private void buttonChartClassici_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide();
        }

        //fantascienza
        private void buttonChartFantascienza_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide();
        }

        //fantasy
        private void buttonChartFantasy_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide(); ;
        }

        //giallo
        private void buttonChartGiallo_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide(); ;
        }

        //horror
        private void buttonChartHorror_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide();
        }

        //personale
        private void buttonChartPersonale_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide();
        }

        //romanzo
        private void buttonChartRomanzo_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide();
        }

        //thriller
        private void buttonChartThriller_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide();
        }

        //umorismo
        private void buttonChartUmorismo_Click(object sender, EventArgs e)
        {
            string genere = (sender as Button).Text;

            Libro[] classificaGenere = _classifiche.GetClassificaGenere(genere);

            new ClassificaView(_addr, _username, classificaGenere).Show();
            this.Hide();
        }

        
        //Anni

        //2018
        private void buttonTop2018_Click(object sender, EventArgs e)
        {
            string anno = (sender as Button).Text;

            int x = 0;
            if (Int32.TryParse(anno, out x))
            {
                
                Libro[] classificaAnno = _classifiche.GetClassificaAnno(x);

                new ClassificaView(_addr, _username, classificaAnno).Show();
                this.Hide();
            }
        }

        //2017
        private void buttonTop2017_Click(object sender, EventArgs e)
        {
            string anno = (sender as Button).Text;

            int x = 0;
            if (Int32.TryParse(anno, out x))
            {
                Libro[] classificaAnno = _classifiche.GetClassificaAnno(x);

                new ClassificaView(_addr, _username, classificaAnno).Show();
                this.Hide();
            }
        }

        //2016
        private void buttonTop2016_Click(object sender, EventArgs e)
        {
            string anno = (sender as Button).Text;

            int x = 0;
            if (Int32.TryParse(anno, out x))
            {
                Libro[] classificaAnno = _classifiche.GetClassificaAnno(x);

                new ClassificaView(_addr, _username, classificaAnno).Show();
                this.Hide();
            }
        }

        //2015
        private void buttonTop2015_Click(object sender, EventArgs e)
        {
            string anno = (sender as Button).Text;

            int x = 0;
            if (Int32.TryParse(anno, out x))
            {
                Libro[] classificaAnno = _classifiche.GetClassificaAnno(x);

                new ClassificaView(_addr, _username, classificaAnno).Show();
                this.Hide();
            }
        }

        //2014
        private void buttonTop2014_Click(object sender, EventArgs e)
        {
            string anno = (sender as Button).Text;

            int x = 0;
            if (Int32.TryParse(anno, out x))
            {
                Libro[] classificaAnno = _classifiche.GetClassificaAnno(x);

                new ClassificaView(_addr, _username, classificaAnno).Show();
                this.Hide();
            }
        }
    }
}
