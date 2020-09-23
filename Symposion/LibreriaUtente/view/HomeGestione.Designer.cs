namespace Libreria
{
    partial class HomeGestione
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeGestione));
            this.buttonEntra = new System.Windows.Forms.Button();
            this.buttonRegistrati = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonHomeLogin = new System.Windows.Forms.Button();
            this.buttonEntraLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.panelIscrizione = new System.Windows.Forms.Panel();
            this.labelEmailIscrizione = new System.Windows.Forms.Label();
            this.textBoxEmailIscrizione = new System.Windows.Forms.TextBox();
            this.buttonHomeIscrizione = new System.Windows.Forms.Button();
            this.buttonRegistratiIscrizione = new System.Windows.Forms.Button();
            this.labelPasswordIscrizione = new System.Windows.Forms.Label();
            this.labelUsernameIscrizione = new System.Windows.Forms.Label();
            this.textBoxPasswordIscrizione = new System.Windows.Forms.TextBox();
            this.textBoxUsernameIscrizione = new System.Windows.Forms.TextBox();
            this.labelSymposion = new Libreria.BorderLabel();
            this.panelHome.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelIscrizione.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEntra
            // 
            this.buttonEntra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEntra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonEntra.FlatAppearance.BorderSize = 0;
            this.buttonEntra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntra.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonEntra.ForeColor = System.Drawing.Color.White;
            this.buttonEntra.Location = new System.Drawing.Point(86, 51);
            this.buttonEntra.Name = "buttonEntra";
            this.buttonEntra.Size = new System.Drawing.Size(393, 37);
            this.buttonEntra.TabIndex = 0;
            this.buttonEntra.Text = "Entra";
            this.buttonEntra.UseVisualStyleBackColor = false;
            this.buttonEntra.Click += new System.EventHandler(this.buttonEntra_Click);
            // 
            // buttonRegistrati
            // 
            this.buttonRegistrati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegistrati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonRegistrati.FlatAppearance.BorderSize = 0;
            this.buttonRegistrati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrati.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonRegistrati.ForeColor = System.Drawing.Color.Black;
            this.buttonRegistrati.Location = new System.Drawing.Point(86, 94);
            this.buttonRegistrati.Name = "buttonRegistrati";
            this.buttonRegistrati.Size = new System.Drawing.Size(393, 37);
            this.buttonRegistrati.TabIndex = 1;
            this.buttonRegistrati.Text = "Registrati";
            this.buttonRegistrati.UseVisualStyleBackColor = false;
            this.buttonRegistrati.Click += new System.EventHandler(this.buttonRegistrati_Click);
            // 
            // panelHome
            // 
            this.panelHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHome.BackColor = System.Drawing.Color.Transparent;
            this.panelHome.Controls.Add(this.buttonEntra);
            this.panelHome.Controls.Add(this.buttonRegistrati);
            this.panelHome.Location = new System.Drawing.Point(298, 278);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(606, 289);
            this.panelHome.TabIndex = 4;
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.AutoSize = true;
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panelLogin.Controls.Add(this.buttonHomeLogin);
            this.panelLogin.Controls.Add(this.buttonEntraLogin);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Controls.Add(this.textBoxPasswordLogin);
            this.panelLogin.Controls.Add(this.textBoxUsernameLogin);
            this.panelLogin.Location = new System.Drawing.Point(384, 278);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(406, 226);
            this.panelLogin.TabIndex = 5;
            // 
            // buttonHomeLogin
            // 
            this.buttonHomeLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHomeLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonHomeLogin.FlatAppearance.BorderSize = 0;
            this.buttonHomeLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeLogin.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonHomeLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonHomeLogin.Location = new System.Drawing.Point(84, 164);
            this.buttonHomeLogin.Name = "buttonHomeLogin";
            this.buttonHomeLogin.Size = new System.Drawing.Size(240, 28);
            this.buttonHomeLogin.TabIndex = 22;
            this.buttonHomeLogin.Text = "Home";
            this.buttonHomeLogin.UseVisualStyleBackColor = false;
            this.buttonHomeLogin.Click += new System.EventHandler(this.buttonHomeLogin_Click);
            // 
            // buttonEntraLogin
            // 
            this.buttonEntraLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEntraLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonEntraLogin.FlatAppearance.BorderSize = 0;
            this.buttonEntraLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntraLogin.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonEntraLogin.ForeColor = System.Drawing.Color.White;
            this.buttonEntraLogin.Location = new System.Drawing.Point(84, 116);
            this.buttonEntraLogin.Name = "buttonEntraLogin";
            this.buttonEntraLogin.Size = new System.Drawing.Size(240, 42);
            this.buttonEntraLogin.TabIndex = 21;
            this.buttonEntraLogin.Text = "Entra";
            this.buttonEntraLogin.UseVisualStyleBackColor = false;
            this.buttonEntraLogin.Click += new System.EventHandler(this.buttonEntraLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(81, 70);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(115, 29);
            this.labelPassword.TabIndex = 18;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(81, 37);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(122, 29);
            this.labelUsername.TabIndex = 17;
            this.labelUsername.Text = "Username";
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(191, 70);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.PasswordChar = '*';
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(133, 35);
            this.textBoxPasswordLogin.TabIndex = 16;
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsernameLogin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(191, 34);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(133, 35);
            this.textBoxUsernameLogin.TabIndex = 15;
            // 
            // panelIscrizione
            // 
            this.panelIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelIscrizione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panelIscrizione.Controls.Add(this.labelEmailIscrizione);
            this.panelIscrizione.Controls.Add(this.textBoxEmailIscrizione);
            this.panelIscrizione.Controls.Add(this.buttonHomeIscrizione);
            this.panelIscrizione.Controls.Add(this.buttonRegistratiIscrizione);
            this.panelIscrizione.Controls.Add(this.labelPasswordIscrizione);
            this.panelIscrizione.Controls.Add(this.labelUsernameIscrizione);
            this.panelIscrizione.Controls.Add(this.textBoxPasswordIscrizione);
            this.panelIscrizione.Controls.Add(this.textBoxUsernameIscrizione);
            this.panelIscrizione.Location = new System.Drawing.Point(384, 278);
            this.panelIscrizione.Name = "panelIscrizione";
            this.panelIscrizione.Size = new System.Drawing.Size(406, 226);
            this.panelIscrizione.TabIndex = 6;
            // 
            // labelEmailIscrizione
            // 
            this.labelEmailIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmailIscrizione.AutoSize = true;
            this.labelEmailIscrizione.BackColor = System.Drawing.Color.Transparent;
            this.labelEmailIscrizione.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);
            this.labelEmailIscrizione.ForeColor = System.Drawing.Color.White;
            this.labelEmailIscrizione.Location = new System.Drawing.Point(81, 22);
            this.labelEmailIscrizione.Name = "labelEmailIscrizione";
            this.labelEmailIscrizione.Size = new System.Drawing.Size(76, 29);
            this.labelEmailIscrizione.TabIndex = 30;
            this.labelEmailIscrizione.Text = "Email";
            // 
            // textBoxEmailIscrizione
            // 
            this.textBoxEmailIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmailIscrizione.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailIscrizione.Location = new System.Drawing.Point(191, 19);
            this.textBoxEmailIscrizione.Name = "textBoxEmailIscrizione";
            this.textBoxEmailIscrizione.Size = new System.Drawing.Size(133, 35);
            this.textBoxEmailIscrizione.TabIndex = 29;
            // 
            // buttonHomeIscrizione
            // 
            this.buttonHomeIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHomeIscrizione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonHomeIscrizione.FlatAppearance.BorderSize = 0;
            this.buttonHomeIscrizione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomeIscrizione.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonHomeIscrizione.ForeColor = System.Drawing.Color.White;
            this.buttonHomeIscrizione.Location = new System.Drawing.Point(85, 185);
            this.buttonHomeIscrizione.Name = "buttonHomeIscrizione";
            this.buttonHomeIscrizione.Size = new System.Drawing.Size(240, 28);
            this.buttonHomeIscrizione.TabIndex = 28;
            this.buttonHomeIscrizione.Text = "Home";
            this.buttonHomeIscrizione.UseVisualStyleBackColor = false;
            this.buttonHomeIscrizione.Click += new System.EventHandler(this.buttonHomeIscrizione_Click);
            // 
            // buttonRegistratiIscrizione
            // 
            this.buttonRegistratiIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRegistratiIscrizione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonRegistratiIscrizione.FlatAppearance.BorderSize = 0;
            this.buttonRegistratiIscrizione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistratiIscrizione.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonRegistratiIscrizione.ForeColor = System.Drawing.Color.Black;
            this.buttonRegistratiIscrizione.Location = new System.Drawing.Point(85, 137);
            this.buttonRegistratiIscrizione.Name = "buttonRegistratiIscrizione";
            this.buttonRegistratiIscrizione.Size = new System.Drawing.Size(240, 42);
            this.buttonRegistratiIscrizione.TabIndex = 27;
            this.buttonRegistratiIscrizione.Text = "Registrati";
            this.buttonRegistratiIscrizione.UseVisualStyleBackColor = false;
            this.buttonRegistratiIscrizione.Click += new System.EventHandler(this.buttonRegistratiIscrizione_Click);
            // 
            // labelPasswordIscrizione
            // 
            this.labelPasswordIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPasswordIscrizione.AutoSize = true;
            this.labelPasswordIscrizione.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordIscrizione.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);
            this.labelPasswordIscrizione.ForeColor = System.Drawing.Color.White;
            this.labelPasswordIscrizione.Location = new System.Drawing.Point(81, 97);
            this.labelPasswordIscrizione.Name = "labelPasswordIscrizione";
            this.labelPasswordIscrizione.Size = new System.Drawing.Size(115, 29);
            this.labelPasswordIscrizione.TabIndex = 26;
            this.labelPasswordIscrizione.Text = "Password";
            // 
            // labelUsernameIscrizione
            // 
            this.labelUsernameIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsernameIscrizione.AutoSize = true;
            this.labelUsernameIscrizione.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameIscrizione.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);
            this.labelUsernameIscrizione.ForeColor = System.Drawing.Color.White;
            this.labelUsernameIscrizione.Location = new System.Drawing.Point(81, 60);
            this.labelUsernameIscrizione.Name = "labelUsernameIscrizione";
            this.labelUsernameIscrizione.Size = new System.Drawing.Size(122, 29);
            this.labelUsernameIscrizione.TabIndex = 25;
            this.labelUsernameIscrizione.Text = "Username";
            // 
            // textBoxPasswordIscrizione
            // 
            this.textBoxPasswordIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPasswordIscrizione.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordIscrizione.Location = new System.Drawing.Point(192, 94);
            this.textBoxPasswordIscrizione.Name = "textBoxPasswordIscrizione";
            this.textBoxPasswordIscrizione.PasswordChar = '*';
            this.textBoxPasswordIscrizione.Size = new System.Drawing.Size(133, 35);
            this.textBoxPasswordIscrizione.TabIndex = 24;
            // 
            // textBoxUsernameIscrizione
            // 
            this.textBoxUsernameIscrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsernameIscrizione.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameIscrizione.Location = new System.Drawing.Point(191, 57);
            this.textBoxUsernameIscrizione.Name = "textBoxUsernameIscrizione";
            this.textBoxUsernameIscrizione.Size = new System.Drawing.Size(133, 35);
            this.textBoxUsernameIscrizione.TabIndex = 23;
            // 
            // labelSymposion
            // 
            this.labelSymposion.AutoSize = true;
            this.labelSymposion.BackColor = System.Drawing.Color.Transparent;
            this.labelSymposion.BorderColor = System.Drawing.Color.Black;
            this.labelSymposion.Font = new System.Drawing.Font("Georgia", 36F);
            this.labelSymposion.ForeColor = System.Drawing.Color.White;
            this.labelSymposion.Location = new System.Drawing.Point(200, 82);
            this.labelSymposion.Name = "labelSymposion";
            this.labelSymposion.Size = new System.Drawing.Size(387, 82);
            this.labelSymposion.TabIndex = 7;
            this.labelSymposion.Text = "Symposion";
            // 
            // HomeGestione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.labelSymposion);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelIscrizione);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeGestione";
            this.Text = "Symposion ";
            this.panelHome.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelIscrizione.ResumeLayout(false);
            this.panelIscrizione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntra;
        private System.Windows.Forms.Button buttonRegistrati;
        private BorderLabel borderLabelSymposion;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.TextBox textBoxUsernameLogin;
        private System.Windows.Forms.Button buttonHomeLogin;
        private System.Windows.Forms.Button buttonEntraLogin;
        private System.Windows.Forms.Panel panelIscrizione;
        private System.Windows.Forms.Button buttonHomeIscrizione;
        private System.Windows.Forms.Button buttonRegistratiIscrizione;
        private System.Windows.Forms.Label labelPasswordIscrizione;
        private System.Windows.Forms.Label labelUsernameIscrizione;
        private System.Windows.Forms.TextBox textBoxPasswordIscrizione;
        private System.Windows.Forms.TextBox textBoxUsernameIscrizione;
        private System.Windows.Forms.Label labelEmailIscrizione;
        private System.Windows.Forms.TextBox textBoxEmailIscrizione;
        private BorderLabel labelSymposion;
    }
}