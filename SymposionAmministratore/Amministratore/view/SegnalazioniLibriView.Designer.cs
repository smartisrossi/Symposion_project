namespace Amministratore
{
    partial class SegnalazioniLibriView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegnalazioniLibriView));
            this.bunifuGradientPanelSceltaDate = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonAggiornaLibro = new System.Windows.Forms.Button();
            this.borderLabelSegnalazioneLibro = new Amministratore.BorderLabel();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonVediLibro = new System.Windows.Forms.Button();
            this.bunifuGradientPanelSceltaDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelSceltaDate
            // 
            this.bunifuGradientPanelSceltaDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelSceltaDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelSceltaDate.BackgroundImage")));
            this.bunifuGradientPanelSceltaDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.buttonAggiornaLibro);
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.borderLabelSegnalazioneLibro);
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.buttonVediLibro);
            this.bunifuGradientPanelSceltaDate.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelSceltaDate.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelSceltaDate.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelSceltaDate.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelSceltaDate.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelSceltaDate.Name = "bunifuGradientPanelSceltaDate";
            this.bunifuGradientPanelSceltaDate.Quality = 10;
            this.bunifuGradientPanelSceltaDate.Size = new System.Drawing.Size(880, 439);
            this.bunifuGradientPanelSceltaDate.TabIndex = 11;
            // 
            // buttonAggiornaLibro
            // 
            this.buttonAggiornaLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAggiornaLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonAggiornaLibro.FlatAppearance.BorderSize = 0;
            this.buttonAggiornaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggiornaLibro.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiornaLibro.ForeColor = System.Drawing.Color.Black;
            this.buttonAggiornaLibro.Location = new System.Drawing.Point(467, 221);
            this.buttonAggiornaLibro.Name = "buttonAggiornaLibro";
            this.buttonAggiornaLibro.Size = new System.Drawing.Size(357, 45);
            this.buttonAggiornaLibro.TabIndex = 26;
            this.buttonAggiornaLibro.Text = "Aggiorna Libro";
            this.buttonAggiornaLibro.UseVisualStyleBackColor = false;
            this.buttonAggiornaLibro.Click += new System.EventHandler(this.buttonAggiornaLibro_Click);
            // 
            // borderLabelSegnalazioneLibro
            // 
            this.borderLabelSegnalazioneLibro.AutoSize = true;
            this.borderLabelSegnalazioneLibro.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelSegnalazioneLibro.BorderColor = System.Drawing.Color.Black;
            this.borderLabelSegnalazioneLibro.Font = new System.Drawing.Font("Georgia", 48F);
            this.borderLabelSegnalazioneLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelSegnalazioneLibro.Location = new System.Drawing.Point(80, 45);
            this.borderLabelSegnalazioneLibro.Name = "borderLabelSegnalazioneLibro";
            this.borderLabelSegnalazioneLibro.Size = new System.Drawing.Size(591, 72);
            this.borderLabelSegnalazioneLibro.TabIndex = 25;
            this.borderLabelSegnalazioneLibro.Text = "Segnalazione Libro:";
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
            this.bunifuImageButtonBack.TabIndex = 24;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // buttonVediLibro
            // 
            this.buttonVediLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVediLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonVediLibro.FlatAppearance.BorderSize = 0;
            this.buttonVediLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVediLibro.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVediLibro.ForeColor = System.Drawing.Color.White;
            this.buttonVediLibro.Location = new System.Drawing.Point(92, 221);
            this.buttonVediLibro.Name = "buttonVediLibro";
            this.buttonVediLibro.Size = new System.Drawing.Size(357, 45);
            this.buttonVediLibro.TabIndex = 16;
            this.buttonVediLibro.Text = "Vedi Libro";
            this.buttonVediLibro.UseVisualStyleBackColor = false;
            this.buttonVediLibro.Click += new System.EventHandler(this.buttonVediLibro_Click);
            // 
            // SegnalazioniLibriView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.bunifuGradientPanelSceltaDate);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SegnalazioniLibriView";
            this.Text = "SegnalazioniLibri";
            this.bunifuGradientPanelSceltaDate.ResumeLayout(false);
            this.bunifuGradientPanelSceltaDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelSceltaDate;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private System.Windows.Forms.Button buttonVediLibro;
        private BorderLabel borderLabelSegnalazioneLibro;
        private System.Windows.Forms.Button buttonAggiornaLibro;
    }
}