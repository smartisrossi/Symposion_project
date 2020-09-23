namespace Amministratore
{
    partial class StatoSistemaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatoSistemaView));
            this.bunifuGradientPanelStatoSistema = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.listViewStatoSistema = new System.Windows.Forms.ListView();
            this.Componente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InFunzione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.borderLabelStatoSistema = new Amministratore.BorderLabel();
            this.bunifuGradientPanelStatoSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelStatoSistema
            // 
            this.bunifuGradientPanelStatoSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelStatoSistema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelStatoSistema.BackgroundImage")));
            this.bunifuGradientPanelStatoSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelStatoSistema.Controls.Add(this.listViewStatoSistema);
            this.bunifuGradientPanelStatoSistema.Controls.Add(this.buttonChiudi);
            this.bunifuGradientPanelStatoSistema.Controls.Add(this.borderLabelStatoSistema);
            this.bunifuGradientPanelStatoSistema.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelStatoSistema.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelStatoSistema.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelStatoSistema.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelStatoSistema.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelStatoSistema.Name = "bunifuGradientPanelStatoSistema";
            this.bunifuGradientPanelStatoSistema.Quality = 10;
            this.bunifuGradientPanelStatoSistema.Size = new System.Drawing.Size(880, 439);
            this.bunifuGradientPanelStatoSistema.TabIndex = 7;
            // 
            // listViewStatoSistema
            // 
            this.listViewStatoSistema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewStatoSistema.BackColor = System.Drawing.Color.White;
            this.listViewStatoSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStatoSistema.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Componente,
            this.InFunzione,
            this.Stato});
            this.listViewStatoSistema.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.listViewStatoSistema.Location = new System.Drawing.Point(89, 145);
            this.listViewStatoSistema.Name = "listViewStatoSistema";
            this.listViewStatoSistema.Size = new System.Drawing.Size(683, 203);
            this.listViewStatoSistema.TabIndex = 14;
            this.listViewStatoSistema.UseCompatibleStateImageBehavior = false;
            // 
            // Componente
            // 
            this.Componente.Text = "Componente";
            this.Componente.Width = 150;
            // 
            // InFunzione
            // 
            this.InFunzione.Text = "In funzione";
            this.InFunzione.Width = 180;
            // 
            // Stato
            // 
            this.Stato.Text = "Stato";
            // 
            // buttonChiudi
            // 
            this.buttonChiudi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChiudi.AutoSize = true;
            this.buttonChiudi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonChiudi.FlatAppearance.BorderSize = 0;
            this.buttonChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiudi.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonChiudi.ForeColor = System.Drawing.Color.White;
            this.buttonChiudi.Location = new System.Drawing.Point(664, 372);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(108, 31);
            this.buttonChiudi.TabIndex = 13;
            this.buttonChiudi.Text = "Chiudi";
            this.buttonChiudi.UseVisualStyleBackColor = false;
            this.buttonChiudi.Click += new System.EventHandler(this.buttonChiudi_Click);
            // 
            // borderLabelStatoSistema
            // 
            this.borderLabelStatoSistema.AutoSize = true;
            this.borderLabelStatoSistema.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelStatoSistema.BorderColor = System.Drawing.Color.Black;
            this.borderLabelStatoSistema.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelStatoSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelStatoSistema.Location = new System.Drawing.Point(89, 45);
            this.borderLabelStatoSistema.Name = "borderLabelStatoSistema";
            this.borderLabelStatoSistema.Size = new System.Drawing.Size(416, 72);
            this.borderLabelStatoSistema.TabIndex = 4;
            this.borderLabelStatoSistema.Text = "Stato Sistema";
            // 
            // StatoSistemaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.bunifuGradientPanelStatoSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatoSistemaView";
            this.Text = "StatoSistema";
            this.bunifuGradientPanelStatoSistema.ResumeLayout(false);
            this.bunifuGradientPanelStatoSistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelStatoSistema;
        private System.Windows.Forms.Button buttonChiudi;
        private BorderLabel borderLabelStatoSistema;
        private System.Windows.Forms.ListView listViewStatoSistema;
        private System.Windows.Forms.ColumnHeader Componente;
        private System.Windows.Forms.ColumnHeader InFunzione;
        private System.Windows.Forms.ColumnHeader Stato;
    }
}