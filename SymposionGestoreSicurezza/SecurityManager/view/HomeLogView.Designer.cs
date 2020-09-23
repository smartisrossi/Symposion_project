namespace SecurityManager
{
    partial class HomeLogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeLogView));
            this.bunifuImageButtonConfigurazioni = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelSceltaLog = new System.Windows.Forms.Panel();
            this.buttonLogOperazioni = new System.Windows.Forms.Button();
            this.buttonLogAccessi = new System.Windows.Forms.Button();
            this.borderLabelSymposion = new SecurityManager.BorderLabel();
            this.bunifuImageButtonLogout = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonConfigurazioni)).BeginInit();
            this.panelSceltaLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButtonConfigurazioni
            // 
            this.bunifuImageButtonConfigurazioni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonConfigurazioni.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonConfigurazioni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonConfigurazioni.BackgroundImage")));
            this.bunifuImageButtonConfigurazioni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButtonConfigurazioni.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonConfigurazioni.Image")));
            this.bunifuImageButtonConfigurazioni.ImageActive = null;
            this.bunifuImageButtonConfigurazioni.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonConfigurazioni.InitialImage")));
            this.bunifuImageButtonConfigurazioni.Location = new System.Drawing.Point(1196, 37);
            this.bunifuImageButtonConfigurazioni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButtonConfigurazioni.Name = "bunifuImageButtonConfigurazioni";
            this.bunifuImageButtonConfigurazioni.Size = new System.Drawing.Size(106, 109);
            this.bunifuImageButtonConfigurazioni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonConfigurazioni.TabIndex = 5;
            this.bunifuImageButtonConfigurazioni.TabStop = false;
            this.bunifuImageButtonConfigurazioni.Zoom = 10;
            this.bunifuImageButtonConfigurazioni.Click += new System.EventHandler(this.bunifuImageButtonConfigurazioni_Click);
            // 
            // panelSceltaLog
            // 
            this.panelSceltaLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelSceltaLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.panelSceltaLog.Controls.Add(this.buttonLogOperazioni);
            this.panelSceltaLog.Controls.Add(this.buttonLogAccessi);
            this.panelSceltaLog.Location = new System.Drawing.Point(375, 238);
            this.panelSceltaLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSceltaLog.Name = "panelSceltaLog";
            this.panelSceltaLog.Size = new System.Drawing.Size(609, 348);
            this.panelSceltaLog.TabIndex = 12;
            // 
            // buttonLogOperazioni
            // 
            this.buttonLogOperazioni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogOperazioni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonLogOperazioni.FlatAppearance.BorderSize = 0;
            this.buttonLogOperazioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOperazioni.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonLogOperazioni.ForeColor = System.Drawing.Color.Black;
            this.buttonLogOperazioni.Location = new System.Drawing.Point(69, 185);
            this.buttonLogOperazioni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogOperazioni.Name = "buttonLogOperazioni";
            this.buttonLogOperazioni.Size = new System.Drawing.Size(482, 65);
            this.buttonLogOperazioni.TabIndex = 22;
            this.buttonLogOperazioni.Text = "Log Operazioni";
            this.buttonLogOperazioni.UseVisualStyleBackColor = false;
            this.buttonLogOperazioni.Click += new System.EventHandler(this.buttonLogOperazioni_Click);
            // 
            // buttonLogAccessi
            // 
            this.buttonLogAccessi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogAccessi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonLogAccessi.FlatAppearance.BorderSize = 0;
            this.buttonLogAccessi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogAccessi.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonLogAccessi.ForeColor = System.Drawing.Color.White;
            this.buttonLogAccessi.Location = new System.Drawing.Point(69, 97);
            this.buttonLogAccessi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogAccessi.Name = "buttonLogAccessi";
            this.buttonLogAccessi.Size = new System.Drawing.Size(482, 65);
            this.buttonLogAccessi.TabIndex = 21;
            this.buttonLogAccessi.Text = "Log Accessi";
            this.buttonLogAccessi.UseVisualStyleBackColor = false;
            this.buttonLogAccessi.Click += new System.EventHandler(this.buttonLogAccessi_Click);
            // 
            // borderLabelSymposion
            // 
            this.borderLabelSymposion.AutoSize = true;
            this.borderLabelSymposion.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelSymposion.BorderColor = System.Drawing.Color.Black;
            this.borderLabelSymposion.Font = new System.Drawing.Font("Georgia", 48F);
            this.borderLabelSymposion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelSymposion.Location = new System.Drawing.Point(69, 57);
            this.borderLabelSymposion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.borderLabelSymposion.Name = "borderLabelSymposion";
            this.borderLabelSymposion.Size = new System.Drawing.Size(518, 109);
            this.borderLabelSymposion.TabIndex = 13;
            this.borderLabelSymposion.Text = "Symposion";
            // 
            // bunifuImageButtonLogout
            // 
            this.bunifuImageButtonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonLogout.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonLogout.BackgroundImage")));
            this.bunifuImageButtonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuImageButtonLogout.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonLogout.Image")));
            this.bunifuImageButtonLogout.ImageActive = null;
            this.bunifuImageButtonLogout.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonLogout.InitialImage")));
            this.bunifuImageButtonLogout.Location = new System.Drawing.Point(1082, 37);
            this.bunifuImageButtonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButtonLogout.Name = "bunifuImageButtonLogout";
            this.bunifuImageButtonLogout.Size = new System.Drawing.Size(106, 109);
            this.bunifuImageButtonLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonLogout.TabIndex = 19;
            this.bunifuImageButtonLogout.TabStop = false;
            this.bunifuImageButtonLogout.Zoom = 10;
            this.bunifuImageButtonLogout.Click += new System.EventHandler(this.bunifuImageButtonLogout_Click);
            // 
            // HomeLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 675);
            this.Controls.Add(this.bunifuImageButtonLogout);
            this.Controls.Add(this.borderLabelSymposion);
            this.Controls.Add(this.panelSceltaLog);
            this.Controls.Add(this.bunifuImageButtonConfigurazioni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeLogView";
            this.Text = "HomeLog";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonConfigurazioni)).EndInit();
            this.panelSceltaLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonConfigurazioni;
        private System.Windows.Forms.Panel panelSceltaLog;
        private System.Windows.Forms.Button buttonLogOperazioni;
        private System.Windows.Forms.Button buttonLogAccessi;
        private BorderLabel borderLabelSymposion;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonLogout;
    }
}