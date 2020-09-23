namespace SecurityManager
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonEntra = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.borderLabelSymposion = new SecurityManager.BorderLabel();
            this.panelHome.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHome.BackColor = System.Drawing.Color.Transparent;
            this.panelHome.Controls.Add(this.buttonEntra);
            this.panelHome.Location = new System.Drawing.Point(164, 155);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(606, 289);
            this.panelHome.TabIndex = 2;
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
            this.buttonEntra.TabIndex = 3;
            this.buttonEntra.Text = "Entra";
            this.buttonEntra.UseVisualStyleBackColor = false;
            this.buttonEntra.Click += new System.EventHandler(this.buttonEntra_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panelLogin.Controls.Add(this.buttonBack);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Location = new System.Drawing.Point(250, 155);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(406, 226);
            this.panelLogin.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(84, 164);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(240, 28);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Text = "Indietro";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Georgia", 12F);
            this.textBoxUsername.Location = new System.Drawing.Point(191, 34);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(133, 35);
            this.textBoxUsername.TabIndex = 23;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(84, 116);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(240, 42);
            this.buttonLogin.TabIndex = 27;
            this.buttonLogin.Text = "Entra";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(191, 70);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(133, 35);
            this.textBoxPassword.TabIndex = 24;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Underline);
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(81, 70);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(115, 29);
            this.labelPassword.TabIndex = 26;
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
            this.labelUsername.TabIndex = 25;
            this.labelUsername.Text = "Username";
            // 
            // borderLabelSymposion
            // 
            this.borderLabelSymposion.AutoSize = true;
            this.borderLabelSymposion.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelSymposion.BorderColor = System.Drawing.Color.Black;
            this.borderLabelSymposion.Font = new System.Drawing.Font("Georgia", 48F);
            this.borderLabelSymposion.ForeColor = System.Drawing.Color.White;
            this.borderLabelSymposion.Location = new System.Drawing.Point(46, 37);
            this.borderLabelSymposion.Margin = new System.Windows.Forms.Padding(3);
            this.borderLabelSymposion.Name = "borderLabelSymposion";
            this.borderLabelSymposion.Size = new System.Drawing.Size(518, 109);
            this.borderLabelSymposion.TabIndex = 4;
            this.borderLabelSymposion.Text = "Symposion";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.borderLabelSymposion);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelLogin);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Underline);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.Text = "Home";
            this.panelHome.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Panel panelLogin;
        private BorderLabel borderLabelSymposion;
        private System.Windows.Forms.Button buttonEntra;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
    }
}