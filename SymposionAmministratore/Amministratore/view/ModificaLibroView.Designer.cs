namespace Amministratore
{
    partial class ModificaLibroView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaLibroView));
            this.bunifuGradientPanelRecensione = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.borderLabelLibro = new Amministratore.BorderLabel();
            this.labelCopertina = new System.Windows.Forms.Label();
            this.labelGenere = new System.Windows.Forms.Label();
            this.labelAnno = new System.Windows.Forms.Label();
            this.labelAutore = new System.Windows.Forms.Label();
            this.labelTitolo = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.textBoxGenere = new System.Windows.Forms.TextBox();
            this.textBoxAnno = new System.Windows.Forms.TextBox();
            this.textBoxAutore = new System.Windows.Forms.TextBox();
            this.textBoxTitolo = new System.Windows.Forms.TextBox();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanelRecensione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
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
            this.bunifuGradientPanelRecensione.Controls.Add(this.buttonSalva);
            this.bunifuGradientPanelRecensione.Controls.Add(this.borderLabelLibro);
            this.bunifuGradientPanelRecensione.Controls.Add(this.labelCopertina);
            this.bunifuGradientPanelRecensione.Controls.Add(this.labelGenere);
            this.bunifuGradientPanelRecensione.Controls.Add(this.labelAnno);
            this.bunifuGradientPanelRecensione.Controls.Add(this.labelAutore);
            this.bunifuGradientPanelRecensione.Controls.Add(this.labelTitolo);
            this.bunifuGradientPanelRecensione.Controls.Add(this.pictureBoxCover);
            this.bunifuGradientPanelRecensione.Controls.Add(this.textBoxGenere);
            this.bunifuGradientPanelRecensione.Controls.Add(this.textBoxAnno);
            this.bunifuGradientPanelRecensione.Controls.Add(this.textBoxAutore);
            this.bunifuGradientPanelRecensione.Controls.Add(this.textBoxTitolo);
            this.bunifuGradientPanelRecensione.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelRecensione.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelRecensione.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelRecensione.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelRecensione.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelRecensione.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelRecensione.Name = "bunifuGradientPanelRecensione";
            this.bunifuGradientPanelRecensione.Quality = 10;
            this.bunifuGradientPanelRecensione.Size = new System.Drawing.Size(880, 439);
            this.bunifuGradientPanelRecensione.TabIndex = 26;
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalva.AutoSize = true;
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonSalva.FlatAppearance.BorderSize = 0;
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonSalva.ForeColor = System.Drawing.Color.White;
            this.buttonSalva.Location = new System.Drawing.Point(589, 375);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(203, 31);
            this.buttonSalva.TabIndex = 42;
            this.buttonSalva.Text = "Salva modifiche";
            this.buttonSalva.UseVisualStyleBackColor = false;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // borderLabelLibro
            // 
            this.borderLabelLibro.AutoSize = true;
            this.borderLabelLibro.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelLibro.BorderColor = System.Drawing.Color.Black;
            this.borderLabelLibro.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelLibro.Location = new System.Drawing.Point(114, 25);
            this.borderLabelLibro.Name = "borderLabelLibro";
            this.borderLabelLibro.Size = new System.Drawing.Size(185, 72);
            this.borderLabelLibro.TabIndex = 41;
            this.borderLabelLibro.Text = "Libro";
            // 
            // labelCopertina
            // 
            this.labelCopertina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCopertina.AutoSize = true;
            this.labelCopertina.BackColor = System.Drawing.Color.Transparent;
            this.labelCopertina.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopertina.Location = new System.Drawing.Point(123, 115);
            this.labelCopertina.Name = "labelCopertina";
            this.labelCopertina.Size = new System.Drawing.Size(73, 18);
            this.labelCopertina.TabIndex = 40;
            this.labelCopertina.Text = "Copertina";
            // 
            // labelGenere
            // 
            this.labelGenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGenere.AutoSize = true;
            this.labelGenere.BackColor = System.Drawing.Color.Transparent;
            this.labelGenere.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenere.Location = new System.Drawing.Point(424, 307);
            this.labelGenere.Name = "labelGenere";
            this.labelGenere.Size = new System.Drawing.Size(56, 18);
            this.labelGenere.TabIndex = 39;
            this.labelGenere.Text = "Genere";
            // 
            // labelAnno
            // 
            this.labelAnno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAnno.AutoSize = true;
            this.labelAnno.BackColor = System.Drawing.Color.Transparent;
            this.labelAnno.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnno.Location = new System.Drawing.Point(424, 239);
            this.labelAnno.Name = "labelAnno";
            this.labelAnno.Size = new System.Drawing.Size(44, 18);
            this.labelAnno.TabIndex = 38;
            this.labelAnno.Text = "Anno";
            // 
            // labelAutore
            // 
            this.labelAutore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAutore.AutoSize = true;
            this.labelAutore.BackColor = System.Drawing.Color.Transparent;
            this.labelAutore.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutore.Location = new System.Drawing.Point(424, 177);
            this.labelAutore.Name = "labelAutore";
            this.labelAutore.Size = new System.Drawing.Size(53, 18);
            this.labelAutore.TabIndex = 37;
            this.labelAutore.Text = "Autore";
            // 
            // labelTitolo
            // 
            this.labelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitolo.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.Location = new System.Drawing.Point(424, 115);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.Size = new System.Drawing.Size(46, 18);
            this.labelTitolo.TabIndex = 36;
            this.labelTitolo.Text = "Titolo";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCover.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCover.ErrorImage")));
            this.pictureBoxCover.Location = new System.Drawing.Point(126, 136);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(262, 270);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 35;
            this.pictureBoxCover.TabStop = false;
            // 
            // textBoxGenere
            // 
            this.textBoxGenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGenere.Font = new System.Drawing.Font("Georgia", 20F);
            this.textBoxGenere.Location = new System.Drawing.Point(427, 328);
            this.textBoxGenere.Name = "textBoxGenere";
            this.textBoxGenere.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGenere.Size = new System.Drawing.Size(365, 38);
            this.textBoxGenere.TabIndex = 34;
            // 
            // textBoxAnno
            // 
            this.textBoxAnno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnno.Font = new System.Drawing.Font("Georgia", 20F);
            this.textBoxAnno.Location = new System.Drawing.Point(427, 260);
            this.textBoxAnno.Name = "textBoxAnno";
            this.textBoxAnno.Size = new System.Drawing.Size(365, 38);
            this.textBoxAnno.TabIndex = 33;
            // 
            // textBoxAutore
            // 
            this.textBoxAutore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAutore.Font = new System.Drawing.Font("Georgia", 20F);
            this.textBoxAutore.Location = new System.Drawing.Point(427, 198);
            this.textBoxAutore.Name = "textBoxAutore";
            this.textBoxAutore.Size = new System.Drawing.Size(365, 38);
            this.textBoxAutore.TabIndex = 32;
            // 
            // textBoxTitolo
            // 
            this.textBoxTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTitolo.Font = new System.Drawing.Font("Georgia", 20F);
            this.textBoxTitolo.Location = new System.Drawing.Point(427, 136);
            this.textBoxTitolo.Name = "textBoxTitolo";
            this.textBoxTitolo.Size = new System.Drawing.Size(365, 38);
            this.textBoxTitolo.TabIndex = 31;
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
            // ModificaLibroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.bunifuGradientPanelRecensione);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificaLibroView";
            this.Text = "Scheda Libro - Modifica";
            this.bunifuGradientPanelRecensione.ResumeLayout(false);
            this.bunifuGradientPanelRecensione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelRecensione;
        private System.Windows.Forms.Label labelCopertina;
        private System.Windows.Forms.Label labelGenere;
        private System.Windows.Forms.Label labelAnno;
        private System.Windows.Forms.Label labelAutore;
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.TextBox textBoxGenere;
        private System.Windows.Forms.TextBox textBoxAnno;
        private System.Windows.Forms.TextBox textBoxAutore;
        private System.Windows.Forms.TextBox textBoxTitolo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private BorderLabel borderLabelLibro;
        private System.Windows.Forms.Button buttonSalva;
    }
}