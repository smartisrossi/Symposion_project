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
    public partial class SistemaOperativoView : Form
    {
        private string _addr;

        public SistemaOperativoView(string addr, string so)
        {
            InitializeComponent();
            _addr = addr;

            listViewSO.View = View.Details;
            listViewSO.GridLines = true;

            /*listViewSO.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewSO.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Sistema Operativo";
            this.listViewSO.Columns.AddRange(new ColumnHeader[] { columnHeader1 });*/
            ListViewItem item = new ListViewItem(so);
            listViewSO.Items.Add(item);
            listViewSO.View = View.Details;


            //listViewSO.Items.Add(new ListViewItem(so));
        }

        private void buttonChiudi_Click(object sender, EventArgs e)
        {
            new GestioneConfigurazioniView(_addr).Show();
            this.Hide();
        }
    }
}
