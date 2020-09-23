using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amministratore
{
    public partial class HomeView : Form
    {
        private Login _login;
        private const string _role = "amministratore"; 

        public HomeView()
        {
            _login = new Login();
            InitializeComponent();
        }

        public string Username()
        {
            return textBoxUsername.Text;
        }

        public string Password()
        {
            return textBoxPassword.Text;
        }


        private void buttonEntra_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelLogin.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username().Length < 3)
                {
                    System.Windows.Forms.MessageBox.Show("Username troppo corto");
                    textBoxUsername.Clear();
                }
                else if (Password().Length < 10)
                {
                    System.Windows.Forms.MessageBox.Show("Password troppo corta");
                    textBoxPassword.Clear();
                }
                else
                {
                    string addr = _login.VerificaCredenziali(Username(), Password(), _role);
                    if (addr == null)
                        throw new ArgumentNullException();
                    new HomeAmministratoreView(addr).Show();
                    this.Hide();
                }
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show("Credenziali non valide");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelLogin.Visible = false;
        }
        
    }
}
