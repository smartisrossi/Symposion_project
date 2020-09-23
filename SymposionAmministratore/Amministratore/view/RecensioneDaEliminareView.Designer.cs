namespace Amministratore
{
    partial class RecensioneDaEliminareView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecensioneDaEliminareView));
            this.bunifuGradientPanelRecensione = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonProssimaRecensione = new System.Windows.Forms.Button();
            this.textBoxCommento = new System.Windows.Forms.TextBox();
            this.textBoxPunteggio = new System.Windows.Forms.TextBox();
            this.textBoxLibro = new System.Windows.Forms.TextBox();
            this.textBoxIDRecensione = new System.Windows.Forms.TextBox();
            this.borderLabelCommento = new Amministratore.BorderLabel();
            this.borderLabelID = new Amministratore.BorderLabel();
            this.borderLabelPunteggio = new Amministratore.BorderLabel();
            this.borderLabelLibro = new Amministratore.BorderLabel();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.borderLabelRecensione = new Amministratore.BorderLabel();
            this.bunifuGradientPanelRecensione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelRecensione
            // 
            this.bunifuGradientPanelRecensione.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelRecensione.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelRecensione.BackgroundImage")));
            this.bunifuGradientPanelRecensione.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelRecensione.Controls.Add(this.buttonProssimaRecensione);
            this.bunifuGradientPanelRecensione.Controls.Add(this.textBoxCommento);
            this.bunifuGradientPanelRecensione.Controls.Add(this.textBoxPunteggio);
            this.bunifuGradientPanelRecensione.Controls.Add(this.textBoxLibro);
            this.bunifuGradientPanelRecensione.Controls.Add(this.textBoxIDRecensione);
            this.bunifuGradientPanelRecensione.Controls.Add(this.borderLabelCommento);
            this.bunifuGradientPanelRecensione.Controls.Add(this.borderLabelID);
            this.bunifuGradientPanelRecensione.Controls.Add(this.borderLabelPunteggio);
            this.bunifuGradientPanelRecensione.Controls.Add(this.borderLabelLibro);
            this.bunifuGradientPanelRecensione.Controls.Add(this.buttonElimina);
            this.bunifuGradientPanelRecensione.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelRecensione.Controls.Add(this.borderLabelRecensione);
            this.bunifuGradientPanelRecensione.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelRecensione.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelRecensione.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelRecensione.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelRecensione.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelRecensione.Name = "bunifuGradientPanelRecensione";
            this.bunifuGradientPanelRecensione.Quality = 10;
            this.bunifuGradientPanelRecensione.Size = new System.Drawing.Size(880, 439);
            this.bunifuGradientPanelRecensione.TabIndex = 25;
            // 
            // buttonProssimaRecensione
            // 
            this.buttonProssimaRecensione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProssimaRecensione.AutoSize = true;
            this.buttonProssimaRecensione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonProssimaRecensione.FlatAppearance.BorderSize = 0;
            this.buttonProssimaRecensione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProssimaRecensione.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonProssimaRecensione.ForeColor = System.Drawing.Color.Black;
            this.buttonProssimaRecensione.Location = new System.Drawing.Point(405, 362);
            this.buttonProssimaRecensione.Name = "buttonProssimaRecensione";
            this.buttonProssimaRecensione.Size = new System.Drawing.Size(166, 31);
            this.buttonProssimaRecensione.TabIndex = 35;
            this.buttonProssimaRecensione.Text = "Prossima Recensione";
            this.buttonProssimaRecensione.UseVisualStyleBackColor = false;
            this.buttonProssimaRecensione.Click += new System.EventHandler(this.buttonProssimaRecensione_Click);
            // 
            // textBoxCommento
            // 
            this.textBoxCommento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCommento.Font = new System.Drawing.Font("Georgia", 20F);
            this.textBoxCommento.Location = new System.Drawing.Point(405, 248);
            this.textBoxCommento.Name = "textBoxCommento";
            this.textBoxCommento.ReadOnly = true;
            this.textBoxCommento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommento.Size = new System.Drawing.Size(365, 38);
            this.textBoxCommento.TabIndex = 34;
            // 
            // textBoxPunteggio
            // 
            this.textBoxPunteggio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPunteggio.Font = new System.Drawing.Font("Georgia", 20F);
            this.textBoxPunteggio.Location = new System.Drawing.Point(405, 200);
            this.textBoxPunteggio.Name = "textBoxPunteggio";
            this.textBoxPunteggio.ReadOnly = true;
            this.textBoxPunteggio.Size = new System.Drawing.Size(365, 38);
            this.textBoxPunteggio.TabIndex = 33;
            // 
            // textBoxLibro
            // 
            this.textBoxLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLibro.Font = new System.Drawing.Font("Georgia", 20F);
            this.textBoxLibro.Location = new System.Drawing.Point(405, 156);
            this.textBoxLibro.Name = "textBoxLibro";
            this.textBoxLibro.ReadOnly = true;
            this.textBoxLibro.Size = new System.Drawing.Size(365, 38);
            this.textBoxLibro.TabIndex = 32;
            // 
            // textBoxIDRecensione
            // 
            this.textBoxIDRecensione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDRecensione.Font = new System.Drawing.Font("Georgia", 20F);
            this.textBoxIDRecensione.Location = new System.Drawing.Point(405, 111);
            this.textBoxIDRecensione.Name = "textBoxIDRecensione";
            this.textBoxIDRecensione.ReadOnly = true;
            this.textBoxIDRecensione.Size = new System.Drawing.Size(365, 38);
            this.textBoxIDRecensione.TabIndex = 31;
            // 
            // borderLabelCommento
            // 
            this.borderLabelCommento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelCommento.AutoSize = true;
            this.borderLabelCommento.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelCommento.BorderColor = System.Drawing.Color.Black;
            this.borderLabelCommento.Font = new System.Drawing.Font("Georgia", 20F);
            this.borderLabelCommento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelCommento.Location = new System.Drawing.Point(126, 255);
            this.borderLabelCommento.Name = "borderLabelCommento";
            this.borderLabelCommento.Size = new System.Drawing.Size(147, 31);
            this.borderLabelCommento.TabIndex = 30;
            this.borderLabelCommento.Text = "Commento";
            // 
            // borderLabelID
            // 
            this.borderLabelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelID.AutoSize = true;
            this.borderLabelID.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelID.BorderColor = System.Drawing.Color.Black;
            this.borderLabelID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderLabelID.Font = new System.Drawing.Font("Georgia", 20F);
            this.borderLabelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelID.Location = new System.Drawing.Point(126, 118);
            this.borderLabelID.Name = "borderLabelID";
            this.borderLabelID.Size = new System.Drawing.Size(189, 31);
            this.borderLabelID.TabIndex = 29;
            this.borderLabelID.Text = "ID Recensione";
            // 
            // borderLabelPunteggio
            // 
            this.borderLabelPunteggio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelPunteggio.AutoSize = true;
            this.borderLabelPunteggio.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelPunteggio.BorderColor = System.Drawing.Color.Black;
            this.borderLabelPunteggio.Font = new System.Drawing.Font("Georgia", 20F);
            this.borderLabelPunteggio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelPunteggio.Location = new System.Drawing.Point(126, 207);
            this.borderLabelPunteggio.Name = "borderLabelPunteggio";
            this.borderLabelPunteggio.Size = new System.Drawing.Size(135, 31);
            this.borderLabelPunteggio.TabIndex = 28;
            this.borderLabelPunteggio.Text = "Punteggio";
            // 
            // borderLabelLibro
            // 
            this.borderLabelLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelLibro.AutoSize = true;
            this.borderLabelLibro.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelLibro.BorderColor = System.Drawing.Color.Black;
            this.borderLabelLibro.Font = new System.Drawing.Font("Georgia", 20F);
            this.borderLabelLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelLibro.Location = new System.Drawing.Point(126, 163);
            this.borderLabelLibro.Name = "borderLabelLibro";
            this.borderLabelLibro.Size = new System.Drawing.Size(79, 31);
            this.borderLabelLibro.TabIndex = 27;
            this.borderLabelLibro.Text = "Libro";
            // 
            // buttonElimina
            // 
            this.buttonElimina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonElimina.AutoSize = true;
            this.buttonElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonElimina.FlatAppearance.BorderSize = 0;
            this.buttonElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElimina.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonElimina.ForeColor = System.Drawing.Color.White;
            this.buttonElimina.Location = new System.Drawing.Point(606, 362);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(164, 31);
            this.buttonElimina.TabIndex = 26;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = false;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // bunifuImageButtonBack
            // 
            this.bunifuImageButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonBack.Image")));
            this.bunifuImageButtonBack.ImageActive = null;
            this.bunifuImageButtonBack.Location = new System.Drawing.Point(797, 12);
            this.bunifuImageButtonBack.Name = "bunifuImageButtonBack";
            this.bunifuImageButtonBack.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBack.TabIndex = 25;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // borderLabelRecensione
            // 
            this.borderLabelRecensione.AutoSize = true;
            this.borderLabelRecensione.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelRecensione.BorderColor = System.Drawing.Color.Black;
            this.borderLabelRecensione.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelRecensione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelRecensione.Location = new System.Drawing.Point(80, 45);
            this.borderLabelRecensione.Name = "borderLabelRecensione";
            this.borderLabelRecensione.Size = new System.Drawing.Size(219, 43);
            this.borderLabelRecensione.TabIndex = 0;
            this.borderLabelRecensione.Text = "Recensione:";
            // 
            // RecensioneDaEliminareView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.bunifuGradientPanelRecensione);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecensioneDaEliminareView";
            this.Text = "Recensione";
            this.bunifuGradientPanelRecensione.ResumeLayout(false);
            this.bunifuGradientPanelRecensione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelRecensione;
        private System.Windows.Forms.TextBox textBoxCommento;
        private System.Windows.Forms.TextBox textBoxPunteggio;
        private System.Windows.Forms.TextBox textBoxLibro;
        private System.Windows.Forms.TextBox textBoxIDRecensione;
        private BorderLabel borderLabelCommento;
        private BorderLabel borderLabelID;
        private BorderLabel borderLabelPunteggio;
        private BorderLabel borderLabelLibro;
        private System.Windows.Forms.Button buttonElimina;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private BorderLabel borderLabelRecensione;
        private System.Windows.Forms.Button buttonProssimaRecensione;
    }
}