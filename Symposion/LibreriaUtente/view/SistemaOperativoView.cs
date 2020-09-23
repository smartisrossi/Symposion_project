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
    public partial class SistemaOperativoView : Form
    {
        private string _addr;
        private string _username;

        public SistemaOperativoView(string addr, string username, string so)
        {
            InitializeComponent();
            _addr = addr;
            _username = username;

            listViewSO.View = View.Details;
            listViewSO.GridLines = true;

            ListViewItem item = new ListViewItem(so);
            listViewSO.Items.Add(item);
        }

        private void buttonChiudi_Click(object sender, EventArgs e)
        {
            new GestioneConfigurazioniView(_addr, _username).Show();
            this.Hide();
        }
    }
}
