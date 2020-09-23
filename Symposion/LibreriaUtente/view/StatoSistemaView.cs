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
    public partial class StatoSistemaView : Form
    {
        private string _addr;
        private string _username;

        public StatoSistemaView(string addr, string username, string stato)
        {
            InitializeComponent();

            _addr = addr;
            _username = username;

            listViewStatoSistema.View = View.Details;
            listViewStatoSistema.GridLines = true;

            ListViewItem item = new ListViewItem(new[] { "Client", "100%", stato });
            listViewStatoSistema.Items.Add(item);
        }

        private void buttonChiudi_Click(object sender, EventArgs e)
        {
            new GestioneConfigurazioniView(_addr, _username).Show();
            this.Hide();
        }
    }
}
