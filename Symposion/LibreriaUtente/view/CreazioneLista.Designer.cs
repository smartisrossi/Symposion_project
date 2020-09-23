using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class CreazioneLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreazioneLista));
            this.bunifuGradientPanelCreaLista = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.comboBoxGeneri = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.borderLabelGenere = new Libreria.BorderLabel();
            this.borderLabelNome = new Libreria.BorderLabel();
            this.buttonCrea = new System.Windows.Forms.Button();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.borderLabelCreaLista = new Libreria.BorderLabel();
            this.bunifuGradientPanelCreaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelCreaLista
            // 
            this.bunifuGradientPanelCreaLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuGradientPanelCreaLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelCreaLista.BackgroundImage")));
            this.bunifuGradientPanelCreaLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelCreaLista.Controls.Add(this.comboBoxGeneri);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.textBoxNome);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.borderLabelGenere);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.borderLabelNome);
            this.bunifuGradientPanelCreaLista.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelCreaLista.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelCreaLista.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelCreaLista.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelCreaLista.Location = new System.Drawing.Point(172, 243);
            this.bunifuGradientPanelCreaLista.Name = "bunifuGradientPanelCreaLista";
            this.bunifuGradientPanelCreaLista.Quality = 10;
            this.bunifuGradientPanelCreaLista.Size = new System.Drawing.Size(843, 194);
            this.bunifuGradientPanelCreaLista.TabIndex = 13;
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
            this.comboBoxGeneri.Location = new System.Drawing.Point(311, 95);
            this.comboBoxGeneri.Name = "comboBoxGeneri";
            this.comboBoxGeneri.Size = new System.Drawing.Size(394, 28);
            this.comboBoxGeneri.Sorted = true;
            this.comboBoxGeneri.TabIndex = 15;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNome.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxNome.Location = new System.Drawing.Point(311, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(394, 44);
            this.textBoxNome.TabIndex = 8;
            // 
            // borderLabelGenere
            // 
            this.borderLabelGenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelGenere.AutoSize = true;
            this.borderLabelGenere.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelGenere.BorderColor = System.Drawing.Color.Black;
            this.borderLabelGenere.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelGenere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelGenere.Location = new System.Drawing.Point(143, 88);
            this.borderLabelGenere.Name = "borderLabelGenere";
            this.borderLabelGenere.Size = new System.Drawing.Size(127, 38);
            this.borderLabelGenere.TabIndex = 7;
            this.borderLabelGenere.Text = "Genere:";
            // 
            // borderLabelNome
            // 
            this.borderLabelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelNome.AutoSize = true;
            this.borderLabelNome.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelNome.BorderColor = System.Drawing.Color.Black;
            this.borderLabelNome.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelNome.Location = new System.Drawing.Point(157, 36);
            this.borderLabelNome.Name = "borderLabelNome";
            this.borderLabelNome.Size = new System.Drawing.Size(112, 38);
            this.borderLabelNome.TabIndex = 4;
            this.borderLabelNome.Text = "Nome:";
            // 
            // buttonCrea
            // 
            this.buttonCrea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCrea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonCrea.FlatAppearance.BorderSize = 0;
            this.buttonCrea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrea.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonCrea.ForeColor = System.Drawing.Color.White;
            this.buttonCrea.Location = new System.Drawing.Point(889, 470);
            this.buttonCrea.Name = "buttonCrea";
            this.buttonCrea.Size = new System.Drawing.Size(126, 33);
            this.buttonCrea.TabIndex = 11;
            this.buttonCrea.Text = "Crea";
            this.buttonCrea.UseVisualStyleBackColor = false;
            this.buttonCrea.Click += new System.EventHandler(this.buttonCrea_Click);
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
            this.bunifuImageButtonBack.TabIndex = 14;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // borderLabelCreaLista
            // 
            this.borderLabelCreaLista.AutoSize = true;
            this.borderLabelCreaLista.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelCreaLista.BorderColor = System.Drawing.Color.Black;
            this.borderLabelCreaLista.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelCreaLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelCreaLista.Location = new System.Drawing.Point(161, 93);
            this.borderLabelCreaLista.Name = "borderLabelCreaLista";
            this.borderLabelCreaLista.Size = new System.Drawing.Size(277, 65);
            this.borderLabelCreaLista.TabIndex = 12;
            this.borderLabelCreaLista.Text = "Crea Lista";
            // 
            // CreazioneLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuImageButtonBack);
            this.Controls.Add(this.bunifuGradientPanelCreaLista);
            this.Controls.Add(this.borderLabelCreaLista);
            this.Controls.Add(this.buttonCrea);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreazioneLista";
            this.Text = "Creazione Lista";
            this.bunifuGradientPanelCreaLista.ResumeLayout(false);
            this.bunifuGradientPanelCreaLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelCreaLista;
        private System.Windows.Forms.TextBox textBoxNome;
        private BorderLabel borderLabelGenere;
        private BorderLabel borderLabelNome;
        private BorderLabel borderLabelCreaLista;
        private System.Windows.Forms.Button buttonCrea;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private System.Windows.Forms.ComboBox comboBoxGeneri;
    }
}
