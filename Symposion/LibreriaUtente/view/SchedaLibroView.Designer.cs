using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class SchedaLibroView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedaLibroView));
            this.buttonSegnala = new System.Windows.Forms.Button();
            this.bunifuGradientPanelIndiceSalotto = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBoxCopertina = new System.Windows.Forms.PictureBox();
            this.textBoxAutoreLibro = new System.Windows.Forms.TextBox();
            this.textBoxTitoloLibro = new System.Windows.Forms.TextBox();
            this.textBoxAnnoLibro = new System.Windows.Forms.TextBox();
            this.textBoxGenereLibro = new System.Windows.Forms.TextBox();
            this.borderLabelGenere = new Libreria.BorderLabel();
            this.borderLabelAnnoPubblicazione = new Libreria.BorderLabel();
            this.borderLabelAutore = new Libreria.BorderLabel();
            this.borderLabelTitolo = new Libreria.BorderLabel();
            this.buttonVisualizzaRecensioni = new System.Windows.Forms.Button();
            this.buttonPubblicaRecensione = new System.Windows.Forms.Button();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonAggiungiALista = new System.Windows.Forms.Button();
            this.bunifuGradientPanelIndiceSalotto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopertina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSegnala
            // 
            this.buttonSegnala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSegnala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonSegnala.FlatAppearance.BorderSize = 0;
            this.buttonSegnala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSegnala.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSegnala.ForeColor = System.Drawing.Color.Black;
            this.buttonSegnala.Location = new System.Drawing.Point(882, 520);
            this.buttonSegnala.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSegnala.Name = "buttonSegnala";
            this.buttonSegnala.Size = new System.Drawing.Size(213, 42);
            this.buttonSegnala.TabIndex = 25;
            this.buttonSegnala.Text = "Segnala";
            this.buttonSegnala.UseVisualStyleBackColor = false;
            this.buttonSegnala.Click += new System.EventHandler(this.buttonSegnala_Click);
            // 
            // bunifuGradientPanelIndiceSalotto
            // 
            this.bunifuGradientPanelIndiceSalotto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelIndiceSalotto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelIndiceSalotto.BackgroundImage")));
            this.bunifuGradientPanelIndiceSalotto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.buttonSegnala);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.buttonPubblicaRecensione);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.buttonAggiungiALista);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.pictureBoxCopertina);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.textBoxAutoreLibro);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.textBoxTitoloLibro);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.textBoxAnnoLibro);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.textBoxGenereLibro);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.borderLabelGenere);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.borderLabelAnnoPubblicazione);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.borderLabelAutore);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.borderLabelTitolo);
            this.bunifuGradientPanelIndiceSalotto.Controls.Add(this.buttonVisualizzaRecensioni);
            this.bunifuGradientPanelIndiceSalotto.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelIndiceSalotto.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelIndiceSalotto.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelIndiceSalotto.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelIndiceSalotto.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelIndiceSalotto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanelIndiceSalotto.Name = "bunifuGradientPanelIndiceSalotto";
            this.bunifuGradientPanelIndiceSalotto.Quality = 10;
            this.bunifuGradientPanelIndiceSalotto.Size = new System.Drawing.Size(1148, 644);
            this.bunifuGradientPanelIndiceSalotto.TabIndex = 23;
            // 
            // pictureBoxCopertina
            // 
            this.pictureBoxCopertina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxCopertina.Location = new System.Drawing.Point(672, 126);
            this.pictureBoxCopertina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCopertina.Name = "pictureBoxCopertina";
            this.pictureBoxCopertina.Size = new System.Drawing.Size(308, 291);
            this.pictureBoxCopertina.TabIndex = 36;
            this.pictureBoxCopertina.TabStop = false;
            // 
            // textBoxAutoreLibro
            // 
            this.textBoxAutoreLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAutoreLibro.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.textBoxAutoreLibro.Location = new System.Drawing.Point(314, 200);
            this.textBoxAutoreLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAutoreLibro.Name = "textBoxAutoreLibro";
            this.textBoxAutoreLibro.Size = new System.Drawing.Size(334, 43);
            this.textBoxAutoreLibro.TabIndex = 35;
            // 
            // textBoxTitoloLibro
            // 
            this.textBoxTitoloLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTitoloLibro.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.textBoxTitoloLibro.Location = new System.Drawing.Point(314, 126);
            this.textBoxTitoloLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTitoloLibro.Name = "textBoxTitoloLibro";
            this.textBoxTitoloLibro.Size = new System.Drawing.Size(334, 43);
            this.textBoxTitoloLibro.TabIndex = 34;
            // 
            // textBoxAnnoLibro
            // 
            this.textBoxAnnoLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnnoLibro.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.textBoxAnnoLibro.Location = new System.Drawing.Point(314, 288);
            this.textBoxAnnoLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAnnoLibro.Name = "textBoxAnnoLibro";
            this.textBoxAnnoLibro.Size = new System.Drawing.Size(334, 43);
            this.textBoxAnnoLibro.TabIndex = 33;
            // 
            // textBoxGenereLibro
            // 
            this.textBoxGenereLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGenereLibro.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.textBoxGenereLibro.Location = new System.Drawing.Point(314, 374);
            this.textBoxGenereLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxGenereLibro.Name = "textBoxGenereLibro";
            this.textBoxGenereLibro.Size = new System.Drawing.Size(334, 43);
            this.textBoxGenereLibro.TabIndex = 32;
            // 
            // borderLabelGenere
            // 
            this.borderLabelGenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelGenere.AutoSize = true;
            this.borderLabelGenere.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelGenere.BorderColor = System.Drawing.Color.Black;
            this.borderLabelGenere.Font = new System.Drawing.Font("Georgia", 15.75F);
            this.borderLabelGenere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelGenere.Location = new System.Drawing.Point(164, 374);
            this.borderLabelGenere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borderLabelGenere.Name = "borderLabelGenere";
            this.borderLabelGenere.Size = new System.Drawing.Size(117, 38);
            this.borderLabelGenere.TabIndex = 31;
            this.borderLabelGenere.Text = "Genere";
            // 
            // borderLabelAnnoPubblicazione
            // 
            this.borderLabelAnnoPubblicazione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelAnnoPubblicazione.AutoSize = true;
            this.borderLabelAnnoPubblicazione.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelAnnoPubblicazione.BorderColor = System.Drawing.Color.Black;
            this.borderLabelAnnoPubblicazione.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelAnnoPubblicazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelAnnoPubblicazione.Location = new System.Drawing.Point(68, 288);
            this.borderLabelAnnoPubblicazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borderLabelAnnoPubblicazione.Name = "borderLabelAnnoPubblicazione";
            this.borderLabelAnnoPubblicazione.Size = new System.Drawing.Size(213, 76);
            this.borderLabelAnnoPubblicazione.TabIndex = 30;
            this.borderLabelAnnoPubblicazione.Text = "Anno di \r\npubblicazione";
            // 
            // borderLabelAutore
            // 
            this.borderLabelAutore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelAutore.AutoSize = true;
            this.borderLabelAutore.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelAutore.BorderColor = System.Drawing.Color.Black;
            this.borderLabelAutore.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelAutore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelAutore.Location = new System.Drawing.Point(111, 200);
            this.borderLabelAutore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borderLabelAutore.Name = "borderLabelAutore";
            this.borderLabelAutore.Size = new System.Drawing.Size(170, 56);
            this.borderLabelAutore.TabIndex = 29;
            this.borderLabelAutore.Text = "Autore";
            // 
            // borderLabelTitolo
            // 
            this.borderLabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelTitolo.AutoSize = true;
            this.borderLabelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelTitolo.BorderColor = System.Drawing.Color.Black;
            this.borderLabelTitolo.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelTitolo.Location = new System.Drawing.Point(114, 111);
            this.borderLabelTitolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borderLabelTitolo.Name = "borderLabelTitolo";
            this.borderLabelTitolo.Size = new System.Drawing.Size(167, 61);
            this.borderLabelTitolo.TabIndex = 28;
            this.borderLabelTitolo.Text = "Titolo";
            // 
            // buttonVisualizzaRecensioni
            // 
            this.buttonVisualizzaRecensioni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVisualizzaRecensioni.AutoSize = true;
            this.buttonVisualizzaRecensioni.BackColor = System.Drawing.Color.Transparent;
            this.buttonVisualizzaRecensioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizzaRecensioni.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVisualizzaRecensioni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.buttonVisualizzaRecensioni.Location = new System.Drawing.Point(69, 442);
            this.buttonVisualizzaRecensioni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVisualizzaRecensioni.Name = "buttonVisualizzaRecensioni";
            this.buttonVisualizzaRecensioni.Size = new System.Drawing.Size(1026, 57);
            this.buttonVisualizzaRecensioni.TabIndex = 27;
            this.buttonVisualizzaRecensioni.Text = "Visualizza Recensioni";
            this.buttonVisualizzaRecensioni.UseVisualStyleBackColor = false;
            this.buttonVisualizzaRecensioni.Click += new System.EventHandler(this.buttonVisualizzaRecensioni_Click);
            // 
            // buttonPubblicaRecensione
            // 
            this.buttonPubblicaRecensione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPubblicaRecensione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(217)))), ((int)(((byte)(221)))));
            this.buttonPubblicaRecensione.FlatAppearance.BorderSize = 0;
            this.buttonPubblicaRecensione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPubblicaRecensione.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonPubblicaRecensione.ForeColor = System.Drawing.Color.Black;
            this.buttonPubblicaRecensione.Location = new System.Drawing.Point(580, 520);
            this.buttonPubblicaRecensione.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPubblicaRecensione.Name = "buttonPubblicaRecensione";
            this.buttonPubblicaRecensione.Size = new System.Drawing.Size(276, 42);
            this.buttonPubblicaRecensione.TabIndex = 27;
            this.buttonPubblicaRecensione.Text = "Pubblica Recensione";
            this.buttonPubblicaRecensione.UseVisualStyleBackColor = false;
            this.buttonPubblicaRecensione.Click += new System.EventHandler(this.buttonPubblicaRecensione_Click);
            // 
            // bunifuImageButtonBack
            // 
            this.bunifuImageButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonBack.Image")));
            this.bunifuImageButtonBack.ImageActive = null;
            this.bunifuImageButtonBack.Location = new System.Drawing.Point(1024, 59);
            this.bunifuImageButtonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButtonBack.Name = "bunifuImageButtonBack";
            this.bunifuImageButtonBack.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBack.TabIndex = 28;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // buttonAggiungiALista
            // 
            this.buttonAggiungiALista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAggiungiALista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonAggiungiALista.FlatAppearance.BorderSize = 0;
            this.buttonAggiungiALista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggiungiALista.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonAggiungiALista.ForeColor = System.Drawing.Color.White;
            this.buttonAggiungiALista.Location = new System.Drawing.Point(69, 520);
            this.buttonAggiungiALista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAggiungiALista.Name = "buttonAggiungiALista";
            this.buttonAggiungiALista.Size = new System.Drawing.Size(484, 42);
            this.buttonAggiungiALista.TabIndex = 29;
            this.buttonAggiungiALista.Text = "Aggiungi Alla Lista";
            this.buttonAggiungiALista.UseVisualStyleBackColor = false;
            this.buttonAggiungiALista.Click += new System.EventHandler(this.buttonAggiungiALista_Click);
            // 
            // SchedaLibroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 632);
            this.Controls.Add(this.bunifuGradientPanelIndiceSalotto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SchedaLibroView";
            this.Text = "SchedaLibro";
            this.bunifuGradientPanelIndiceSalotto.ResumeLayout(false);
            this.bunifuGradientPanelIndiceSalotto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopertina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSegnala;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelIndiceSalotto;
        private System.Windows.Forms.Button buttonVisualizzaRecensioni;
        private System.Windows.Forms.Button buttonPubblicaRecensione;
        private BorderLabel borderLabelGenere;
        private BorderLabel borderLabelAnnoPubblicazione;
        private BorderLabel borderLabelAutore;
        private BorderLabel borderLabelTitolo;
        private System.Windows.Forms.TextBox textBoxAutoreLibro;
        private System.Windows.Forms.TextBox textBoxTitoloLibro;
        private System.Windows.Forms.TextBox textBoxAnnoLibro;
        private System.Windows.Forms.TextBox textBoxGenereLibro;
        private System.Windows.Forms.PictureBox pictureBoxCopertina;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private System.Windows.Forms.Button buttonAggiungiALista;
    }
}