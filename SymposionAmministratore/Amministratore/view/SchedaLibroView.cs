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

namespace Amministratore
{
    public partial class SchedaLibroView : Form
    {
        private string _addr;
        private Libro _libro;

        public SchedaLibroView(string addr, Libro libro)
        {
            InitializeComponent();

            _addr = addr;
            _libro = libro;

            textBoxTitolo.Text = _libro.Titolo;
            textBoxAutore.Text = _libro.Autore;
            textBoxAnno.Text = _libro.Anno.ToString();
            textBoxGenere.Text = _libro.Gen.ToString();

            if (_libro.FilePath != null)
            {
                pictureBoxCover.Image = Image.FromFile("C:\\Users\\mmart\\Desktop\\Download\\" + _libro.FilePath);
            }
            else
            {
                pictureBoxCover.Image = null;
            }
        }

        private void bunifuImageButtonBack_Click(object sender, EventArgs e)
        {
            new SegnalazioniLibriView(_addr, _libro).Show();
            this.Hide();
        }
    }
}
