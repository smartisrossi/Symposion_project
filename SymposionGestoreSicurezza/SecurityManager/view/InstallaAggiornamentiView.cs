using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityManager
{
    //View mai usata
    public partial class InstallaAggiornamentiView : Form
    {
        private string _addr;
        public InstallaAggiornamentiView(string addr)
        {
            InitializeComponent();
            _addr = addr;
        }
        private void buttonChiudi_Click(object sender, EventArgs e)
        {
            new GestioneConfigurazioniView(_addr).Show();
            this.Hide();
        }
    }
}
