using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class RicercaPubblicaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RicercaPubblicaView));
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanelRicerca = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textBoxCercaUtente = new Bunifu.Framework.UI.BunifuTextbox();
            this.textBoxCercaLista = new Bunifu.Framework.UI.BunifuTextbox();
            this.textBoxCercaGenere = new Bunifu.Framework.UI.BunifuTextbox();
            this.textBoxCercaLibro = new Bunifu.Framework.UI.BunifuTextbox();
            this.buttonUtente = new Libreria.RoundButton();
            this.buttonLista = new Libreria.RoundButton();
            this.buttonGenere = new Libreria.RoundButton();
            this.buttonLibro = new Libreria.RoundButton();
            this.borderLabelRicercaPubblica = new Libreria.BorderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.bunifuGradientPanelRicerca.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuImageButtonBack
            // 
            this.bunifuImageButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonBack.Image")));
            this.bunifuImageButtonBack.ImageActive = null;
            this.bunifuImageButtonBack.Location = new System.Drawing.Point(944, 93);
            this.bunifuImageButtonBack.Name = "bunifuImageButtonBack";
            this.bunifuImageButtonBack.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBack.TabIndex = 15;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // bunifuGradientPanelRicerca
            // 
            this.bunifuGradientPanelRicerca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuGradientPanelRicerca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelRicerca.BackgroundImage")));
            this.bunifuGradientPanelRicerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelRicerca.Controls.Add(this.textBoxCercaUtente);
            this.bunifuGradientPanelRicerca.Controls.Add(this.textBoxCercaLista);
            this.bunifuGradientPanelRicerca.Controls.Add(this.textBoxCercaGenere);
            this.bunifuGradientPanelRicerca.Controls.Add(this.textBoxCercaLibro);
            this.bunifuGradientPanelRicerca.Controls.Add(this.buttonUtente);
            this.bunifuGradientPanelRicerca.Controls.Add(this.buttonLista);
            this.bunifuGradientPanelRicerca.Controls.Add(this.buttonGenere);
            this.bunifuGradientPanelRicerca.Controls.Add(this.buttonLibro);
            this.bunifuGradientPanelRicerca.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelRicerca.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelRicerca.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelRicerca.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelRicerca.Location = new System.Drawing.Point(172, 213);
            this.bunifuGradientPanelRicerca.Name = "bunifuGradientPanelRicerca";
            this.bunifuGradientPanelRicerca.Quality = 10;
            this.bunifuGradientPanelRicerca.Size = new System.Drawing.Size(843, 428);
            this.bunifuGradientPanelRicerca.TabIndex = 11;
            // 
            // textBoxCercaUtente
            // 
            this.textBoxCercaUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCercaUtente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(214)))));
            this.textBoxCercaUtente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxCercaUtente.BackgroundImage")));
            this.textBoxCercaUtente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxCercaUtente.ForeColor = System.Drawing.Color.Black;
            this.textBoxCercaUtente.Icon = ((System.Drawing.Image)(resources.GetObject("textBoxCercaUtente.Icon")));
            this.textBoxCercaUtente.Location = new System.Drawing.Point(51, 318);
            this.textBoxCercaUtente.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.textBoxCercaUtente.Name = "textBoxCercaUtente";
            this.textBoxCercaUtente.Size = new System.Drawing.Size(584, 67);
            this.textBoxCercaUtente.TabIndex = 30;
            this.textBoxCercaUtente.text = "Username utente";
            // 
            // textBoxCercaLista
            // 
            this.textBoxCercaLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCercaLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(74)))));
            this.textBoxCercaLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxCercaLista.BackgroundImage")));
            this.textBoxCercaLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxCercaLista.ForeColor = System.Drawing.Color.Black;
            this.textBoxCercaLista.Icon = ((System.Drawing.Image)(resources.GetObject("textBoxCercaLista.Icon")));
            this.textBoxCercaLista.Location = new System.Drawing.Point(51, 231);
            this.textBoxCercaLista.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.textBoxCercaLista.Name = "textBoxCercaLista";
            this.textBoxCercaLista.Size = new System.Drawing.Size(584, 67);
            this.textBoxCercaLista.TabIndex = 29;
            this.textBoxCercaLista.text = "Nome della lista";
            // 
            // textBoxCercaGenere
            // 
            this.textBoxCercaGenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCercaGenere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(57)))));
            this.textBoxCercaGenere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxCercaGenere.BackgroundImage")));
            this.textBoxCercaGenere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxCercaGenere.ForeColor = System.Drawing.Color.Black;
            this.textBoxCercaGenere.Icon = ((System.Drawing.Image)(resources.GetObject("textBoxCercaGenere.Icon")));
            this.textBoxCercaGenere.Location = new System.Drawing.Point(51, 142);
            this.textBoxCercaGenere.Margin = new System.Windows.Forms.Padding(7);
            this.textBoxCercaGenere.Name = "textBoxCercaGenere";
            this.textBoxCercaGenere.Size = new System.Drawing.Size(584, 67);
            this.textBoxCercaGenere.TabIndex = 28;
            this.textBoxCercaGenere.text = "Genere";
            // 
            // textBoxCercaLibro
            // 
            this.textBoxCercaLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCercaLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.textBoxCercaLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxCercaLibro.BackgroundImage")));
            this.textBoxCercaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBoxCercaLibro.ForeColor = System.Drawing.Color.Black;
            this.textBoxCercaLibro.Icon = ((System.Drawing.Image)(resources.GetObject("textBoxCercaLibro.Icon")));
            this.textBoxCercaLibro.Location = new System.Drawing.Point(51, 55);
            this.textBoxCercaLibro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxCercaLibro.Name = "textBoxCercaLibro";
            this.textBoxCercaLibro.Size = new System.Drawing.Size(584, 67);
            this.textBoxCercaLibro.TabIndex = 16;
            this.textBoxCercaLibro.text = "Titolo del libro";
            // 
            // buttonUtente
            // 
            this.buttonUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUtente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(214)))));
            this.buttonUtente.FlatAppearance.BorderSize = 0;
            this.buttonUtente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUtente.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtente.Location = new System.Drawing.Point(676, 318);
            this.buttonUtente.Name = "buttonUtente";
            this.buttonUtente.Size = new System.Drawing.Size(105, 67);
            this.buttonUtente.TabIndex = 23;
            this.buttonUtente.Text = "Cerca";
            this.buttonUtente.UseVisualStyleBackColor = false;
            this.buttonUtente.Click += new System.EventHandler(this.buttonUtente_Click);
            // 
            // buttonLista
            // 
            this.buttonLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(74)))));
            this.buttonLista.FlatAppearance.BorderSize = 0;
            this.buttonLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLista.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLista.Location = new System.Drawing.Point(676, 224);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(105, 67);
            this.buttonLista.TabIndex = 22;
            this.buttonLista.Text = "Cerca";
            this.buttonLista.UseVisualStyleBackColor = false;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // buttonGenere
            // 
            this.buttonGenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGenere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(57)))));
            this.buttonGenere.FlatAppearance.BorderSize = 0;
            this.buttonGenere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenere.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenere.Location = new System.Drawing.Point(676, 142);
            this.buttonGenere.Name = "buttonGenere";
            this.buttonGenere.Size = new System.Drawing.Size(105, 67);
            this.buttonGenere.TabIndex = 21;
            this.buttonGenere.Text = "Cerca";
            this.buttonGenere.UseVisualStyleBackColor = false;
            this.buttonGenere.Click += new System.EventHandler(this.buttonGenere_Click);
            // 
            // buttonLibro
            // 
            this.buttonLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(68)))));
            this.buttonLibro.FlatAppearance.BorderSize = 0;
            this.buttonLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibro.Location = new System.Drawing.Point(676, 55);
            this.buttonLibro.Name = "buttonLibro";
            this.buttonLibro.Size = new System.Drawing.Size(105, 67);
            this.buttonLibro.TabIndex = 20;
            this.buttonLibro.Text = "Cerca";
            this.buttonLibro.UseVisualStyleBackColor = false;
            this.buttonLibro.Click += new System.EventHandler(this.buttonLibro_Click);
            // 
            // borderLabelRicercaPubblica
            // 
            this.borderLabelRicercaPubblica.AutoSize = true;
            this.borderLabelRicercaPubblica.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelRicercaPubblica.BorderColor = System.Drawing.Color.Black;
            this.borderLabelRicercaPubblica.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelRicercaPubblica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelRicercaPubblica.Location = new System.Drawing.Point(161, 93);
            this.borderLabelRicercaPubblica.Name = "borderLabelRicercaPubblica";
            this.borderLabelRicercaPubblica.Size = new System.Drawing.Size(203, 61);
            this.borderLabelRicercaPubblica.TabIndex = 12;
            this.borderLabelRicercaPubblica.Text = "Ricerca";
            // 
            // RicercaPubblicaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuImageButtonBack);
            this.Controls.Add(this.borderLabelRicercaPubblica);
            this.Controls.Add(this.bunifuGradientPanelRicerca);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RicercaPubblicaView";
            this.Text = "Ricerca ";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.bunifuGradientPanelRicerca.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BorderLabel borderLabelRicercaPubblica;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelRicerca;
        private RoundButton buttonUtente;
        private RoundButton buttonLista;
        private RoundButton buttonGenere;
        private RoundButton buttonLibro;
        private Bunifu.Framework.UI.BunifuTextbox textBoxCercaLibro;
        private Bunifu.Framework.UI.BunifuTextbox textBoxCercaGenere;
        private Bunifu.Framework.UI.BunifuTextbox textBoxCercaUtente;
        private Bunifu.Framework.UI.BunifuTextbox textBoxCercaLista;
    }
}