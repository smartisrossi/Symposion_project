using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class InserimentoLibroView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserimentoLibroView));
            this.bunifuGradientPanelInserimentoLibro = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.comboBoxGeneri = new System.Windows.Forms.ComboBox();
            this.buttonScegliFile = new System.Windows.Forms.Button();
            this.borderLabelCopertina = new Libreria.BorderLabel();
            this.textBoxAnnoPubblicazione = new System.Windows.Forms.TextBox();
            this.textBoxAutore = new System.Windows.Forms.TextBox();
            this.textBoxTitolo = new System.Windows.Forms.TextBox();
            this.borderLabelAutore = new Libreria.BorderLabel();
            this.borderLabelAnnoPubblicazione = new Libreria.BorderLabel();
            this.borderLabelGenere = new Libreria.BorderLabel();
            this.borderLabelTitolo = new Libreria.BorderLabel();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.openFileDialogCopertina = new System.Windows.Forms.OpenFileDialog();
            this.borderLabelInserisciLibro = new Libreria.BorderLabel();
            this.bunifuGradientPanelInserimentoLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelInserimentoLibro
            // 
            this.bunifuGradientPanelInserimentoLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuGradientPanelInserimentoLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelInserimentoLibro.BackgroundImage")));
            this.bunifuGradientPanelInserimentoLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.comboBoxGeneri);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.buttonScegliFile);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.borderLabelCopertina);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.textBoxAnnoPubblicazione);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.textBoxTitolo);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.textBoxAutore);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.borderLabelAutore);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.borderLabelAnnoPubblicazione);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.borderLabelGenere);
            this.bunifuGradientPanelInserimentoLibro.Controls.Add(this.borderLabelTitolo);
            this.bunifuGradientPanelInserimentoLibro.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelInserimentoLibro.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelInserimentoLibro.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelInserimentoLibro.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelInserimentoLibro.Location = new System.Drawing.Point(172, 200);
            this.bunifuGradientPanelInserimentoLibro.Name = "bunifuGradientPanelInserimentoLibro";
            this.bunifuGradientPanelInserimentoLibro.Quality = 10;
            this.bunifuGradientPanelInserimentoLibro.Size = new System.Drawing.Size(839, 340);
            this.bunifuGradientPanelInserimentoLibro.TabIndex = 10;
            // 
            // comboBoxGeneri
            // 
            this.comboBoxGeneri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGeneri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGeneri.FormattingEnabled = true;
            this.comboBoxGeneri.Items.AddRange(new object[] {
            "Avventura",
            "Classici",
            "Fantascienza",
            "Fantasy",
            "Giallo",
            "Horror",
            "Personale",
            "Romanzo",
            "Thriller",
            "Umorismo"});
            this.comboBoxGeneri.Location = new System.Drawing.Point(341, 216);
            this.comboBoxGeneri.Name = "comboBoxGeneri";
            this.comboBoxGeneri.Size = new System.Drawing.Size(452, 28);
            this.comboBoxGeneri.Sorted = true;
            this.comboBoxGeneri.TabIndex = 14;
            // 
            // buttonScegliFile
            // 
            this.buttonScegliFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScegliFile.BackColor = System.Drawing.SystemColors.Window;
            this.buttonScegliFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScegliFile.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScegliFile.Location = new System.Drawing.Point(341, 273);
            this.buttonScegliFile.Name = "buttonScegliFile";
            this.buttonScegliFile.Size = new System.Drawing.Size(452, 32);
            this.buttonScegliFile.TabIndex = 13;
            this.buttonScegliFile.Text = "Scegli file";
            this.buttonScegliFile.UseVisualStyleBackColor = false;
            this.buttonScegliFile.Click += new System.EventHandler(this.buttonScegliFile_Click);
            // 
            // borderLabelCopertina
            // 
            this.borderLabelCopertina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelCopertina.AutoSize = true;
            this.borderLabelCopertina.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelCopertina.BorderColor = System.Drawing.Color.Black;
            this.borderLabelCopertina.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelCopertina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelCopertina.Location = new System.Drawing.Point(61, 265);
            this.borderLabelCopertina.Name = "borderLabelCopertina";
            this.borderLabelCopertina.Size = new System.Drawing.Size(174, 38);
            this.borderLabelCopertina.TabIndex = 12;
            this.borderLabelCopertina.Text = "Copertina: ";
            this.borderLabelCopertina.Click += new System.EventHandler(this.borderLabelCopertina_Click);
            // 
            // textBoxAnnoPubblicazione
            // 
            this.textBoxAnnoPubblicazione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAnnoPubblicazione.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxAnnoPubblicazione.Location = new System.Drawing.Point(341, 134);
            this.textBoxAnnoPubblicazione.Name = "textBoxAnnoPubblicazione";
            this.textBoxAnnoPubblicazione.Size = new System.Drawing.Size(452, 44);
            this.textBoxAnnoPubblicazione.TabIndex = 10;
            // 
            // textBoxAutore
            // 
            this.textBoxAutore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAutore.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxAutore.Location = new System.Drawing.Point(341, 69);
            this.textBoxAutore.Name = "textBoxAutore";
            this.textBoxAutore.Size = new System.Drawing.Size(452, 44);
            this.textBoxAutore.TabIndex = 9;
            // 
            // textBoxTitolo
            // 
            this.textBoxTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTitolo.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxTitolo.Location = new System.Drawing.Point(341, 18);
            this.textBoxTitolo.Name = "textBoxTitolo";
            this.textBoxTitolo.Size = new System.Drawing.Size(452, 44);
            this.textBoxTitolo.TabIndex = 8;
            // 
            // borderLabelAutore
            // 
            this.borderLabelAutore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelAutore.AutoSize = true;
            this.borderLabelAutore.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelAutore.BorderColor = System.Drawing.Color.Black;
            this.borderLabelAutore.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelAutore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelAutore.Location = new System.Drawing.Point(61, 75);
            this.borderLabelAutore.Name = "borderLabelAutore";
            this.borderLabelAutore.Size = new System.Drawing.Size(123, 38);
            this.borderLabelAutore.TabIndex = 7;
            this.borderLabelAutore.Text = "Autore:";
            // 
            // borderLabelAnnoPubblicazione
            // 
            this.borderLabelAnnoPubblicazione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelAnnoPubblicazione.AutoSize = true;
            this.borderLabelAnnoPubblicazione.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelAnnoPubblicazione.BorderColor = System.Drawing.Color.Black;
            this.borderLabelAnnoPubblicazione.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelAnnoPubblicazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelAnnoPubblicazione.Location = new System.Drawing.Point(61, 118);
            this.borderLabelAnnoPubblicazione.Name = "borderLabelAnnoPubblicazione";
            this.borderLabelAnnoPubblicazione.Size = new System.Drawing.Size(223, 76);
            this.borderLabelAnnoPubblicazione.TabIndex = 6;
            this.borderLabelAnnoPubblicazione.Text = "Anno di \r\npubblicazione:";
            this.borderLabelAnnoPubblicazione.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // borderLabelGenere
            // 
            this.borderLabelGenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelGenere.AutoSize = true;
            this.borderLabelGenere.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelGenere.BorderColor = System.Drawing.Color.Black;
            this.borderLabelGenere.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelGenere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelGenere.Location = new System.Drawing.Point(61, 204);
            this.borderLabelGenere.Name = "borderLabelGenere";
            this.borderLabelGenere.Size = new System.Drawing.Size(135, 38);
            this.borderLabelGenere.TabIndex = 5;
            this.borderLabelGenere.Text = "Genere: ";
            // 
            // borderLabelTitolo
            // 
            this.borderLabelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelTitolo.AutoSize = true;
            this.borderLabelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelTitolo.BorderColor = System.Drawing.Color.Black;
            this.borderLabelTitolo.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelTitolo.Location = new System.Drawing.Point(61, 24);
            this.borderLabelTitolo.Name = "borderLabelTitolo";
            this.borderLabelTitolo.Size = new System.Drawing.Size(110, 38);
            this.borderLabelTitolo.TabIndex = 4;
            this.borderLabelTitolo.Text = "Titolo:";
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInserisci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonInserisci.FlatAppearance.BorderSize = 0;
            this.buttonInserisci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserisci.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonInserisci.ForeColor = System.Drawing.Color.White;
            this.buttonInserisci.Location = new System.Drawing.Point(799, 567);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(212, 31);
            this.buttonInserisci.TabIndex = 8;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = false;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // bunifuImageButtonBack
            // 
            this.bunifuImageButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonBack.Image")));
            this.bunifuImageButtonBack.ImageActive = null;
            this.bunifuImageButtonBack.Location = new System.Drawing.Point(944, 93);
            this.bunifuImageButtonBack.Name = "bunifuImageButtonBack";
            this.bunifuImageButtonBack.Size = new System.Drawing.Size(67, 55);
            this.bunifuImageButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBack.TabIndex = 13;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // openFileDialogCopertina
            // 
            this.openFileDialogCopertina.FileName = "openFileDialogCopertina";
            // 
            // borderLabelInserisciLibro
            // 
            this.borderLabelInserisciLibro.AutoSize = true;
            this.borderLabelInserisciLibro.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelInserisciLibro.BorderColor = System.Drawing.Color.Black;
            this.borderLabelInserisciLibro.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelInserisciLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelInserisciLibro.Location = new System.Drawing.Point(161, 93);
            this.borderLabelInserisciLibro.Name = "borderLabelInserisciLibro";
            this.borderLabelInserisciLibro.Size = new System.Drawing.Size(386, 65);
            this.borderLabelInserisciLibro.TabIndex = 9;
            this.borderLabelInserisciLibro.Text = "Inserisci Libro";
            // 
            // InserimentoLibroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuImageButtonBack);
            this.Controls.Add(this.bunifuGradientPanelInserimentoLibro);
            this.Controls.Add(this.borderLabelInserisciLibro);
            this.Controls.Add(this.buttonInserisci);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserimentoLibroView";
            this.Text = "Inserisci Libro";
            this.bunifuGradientPanelInserimentoLibro.ResumeLayout(false);
            this.bunifuGradientPanelInserimentoLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelInserimentoLibro;
        private BorderLabel borderLabelTitolo;
        private System.Windows.Forms.Button buttonInserisci;
        private System.Windows.Forms.TextBox textBoxTitolo;
        private BorderLabel borderLabelAutore;
        private BorderLabel borderLabelAnnoPubblicazione;
        private BorderLabel borderLabelGenere;
        private System.Windows.Forms.TextBox textBoxAnnoPubblicazione;
        private System.Windows.Forms.TextBox textBoxAutore;
        private BorderLabel borderLabelCopertina;
        private System.Windows.Forms.Button buttonScegliFile;
        private System.Windows.Forms.ComboBox comboBoxGeneri;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private BorderLabel borderLabelInserisciLibro;
        private System.Windows.Forms.OpenFileDialog openFileDialogCopertina;
    }
}