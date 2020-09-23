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
    public partial class HomeGestione : Form
    {
        private Login _login;
        private Iscrizione _iscrizione;

        private const string _role = "utente";


        public HomeGestione()
        {
            InitializeComponent();

            _login = new Login();
            _iscrizione = new Iscrizione();
        }

        
        //-----------------------------------------//
        private void buttonEntra_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelLogin.Visible = true;
            panelIscrizione.Visible = false;
        }

        private void buttonRegistrati_Click(object sender, EventArgs e)
        {
            panelHome.Visible = false;
            panelLogin.Visible = false;
            panelIscrizione.Visible = true;
        }



        //Login ----------------------
        public string UsernameLogin()
        {
            return textBoxUsernameLogin.Text;
        }

        public string PasswordLogin()
        {
            return textBoxPasswordLogin.Text;
        }


        private void buttonEntraLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (UsernameLogin().Length < 3)
                {
                    System.Windows.Forms.MessageBox.Show("Username troppo corto");
                    textBoxUsernameLogin.Clear();
                }
                else if (PasswordLogin().Length < 10)
                {
                    System.Windows.Forms.MessageBox.Show("Password troppo corta");
                    textBoxPasswordLogin.Clear();
                }
                else
                {
                    string addr = _login.VerificaCredenziali(UsernameLogin(), PasswordLogin(), _role);

                    if (addr == null)
                        throw new ArgumentNullException();

                    new Salotto(addr, UsernameLogin()).Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Credenziali non valide ");
            }
        }

        //Iscrizione -------------------
        public string UsernameIscrizione()
        {
            return textBoxUsernameIscrizione.Text;
        }

        public string PasswordIscrizione()
        {
            return textBoxPasswordIscrizione.Text;
        }

        public string EmailIscrizione()
        {
            return textBoxEmailIscrizione.Text;
        }


        private void buttonRegistratiIscrizione_Click(object sender, EventArgs e)
        {
            //iscrizione

            try
            {
                if (UsernameIscrizione().Length < 3)
                {
                    System.Windows.Forms.MessageBox.Show("Username troppo corto");
                }
                else if (PasswordIscrizione().Length < 10)
                {
                    System.Windows.Forms.MessageBox.Show("Password troppo corta");
                }
                else if(String.IsNullOrEmpty(EmailIscrizione()))
                {
                    System.Windows.Forms.MessageBox.Show("Nessuna mail inserita");
                }
                else
                {
                    
                    string addr = _iscrizione.RegistraUtente(UsernameIscrizione(), PasswordIscrizione(), EmailIscrizione(), _role);

                    if (addr == null)
                        throw new ArgumentNullException();

                    new Salotto(addr, UsernameIscrizione()).Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Utente già presente nel sistema");
            }
        }

        private void buttonHomeIscrizione_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelLogin.Visible = false;
            panelIscrizione.Visible = false;
        }

        private void buttonHomeLogin_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelLogin.Visible = false;
            panelIscrizione.Visible = false;
        }
    }
}
