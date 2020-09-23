using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class RecensioneView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecensioneView));
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonSegnala = new System.Windows.Forms.Button();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.bunifuGradientPanelModificaRecensione = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textBoxLibro = new System.Windows.Forms.TextBox();
            this.borderLabelLibro = new Libreria.BorderLabel();
            this.textBoxCommento = new System.Windows.Forms.TextBox();
            this.textBoxPunteggio = new System.Windows.Forms.TextBox();
            this.borderLabelCommento = new Libreria.BorderLabel();
            this.borderLabelPunteggio = new Libreria.BorderLabel();
            this.borderLabelModificaRecensione = new Libreria.BorderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.bunifuGradientPanelModificaRecensione.SuspendLayout();
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
            this.bunifuImageButtonBack.TabIndex = 27;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // buttonSegnala
            // 
            this.buttonSegnala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSegnala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonSegnala.FlatAppearance.BorderSize = 0;
            this.buttonSegnala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSegnala.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonSegnala.ForeColor = System.Drawing.Color.Black;
            this.buttonSegnala.Location = new System.Drawing.Point(735, 559);
            this.buttonSegnala.Name = "buttonSegnala";
            this.buttonSegnala.Size = new System.Drawing.Size(137, 46);
            this.buttonSegnala.TabIndex = 26;
            this.buttonSegnala.Text = "Segnala";
            this.buttonSegnala.UseVisualStyleBackColor = false;
            this.buttonSegnala.Click += new System.EventHandler(this.buttonSegnala_Click);
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonSalva.FlatAppearance.BorderSize = 0;
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonSalva.ForeColor = System.Drawing.Color.White;
            this.buttonSalva.Location = new System.Drawing.Point(878, 559);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(137, 46);
            this.buttonSalva.TabIndex = 25;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = false;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // bunifuGradientPanelModificaRecensione
            // 
            this.bunifuGradientPanelModificaRecensione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuGradientPanelModificaRecensione.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelModificaRecensione.BackgroundImage")));
            this.bunifuGradientPanelModificaRecensione.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelModificaRecensione.Controls.Add(this.textBoxLibro);
            this.bunifuGradientPanelModificaRecensione.Controls.Add(this.borderLabelLibro);
            this.bunifuGradientPanelModificaRecensione.Controls.Add(this.textBoxCommento);
            this.bunifuGradientPanelModificaRecensione.Controls.Add(this.textBoxPunteggio);
            this.bunifuGradientPanelModificaRecensione.Controls.Add(this.borderLabelCommento);
            this.bunifuGradientPanelModificaRecensione.Controls.Add(this.borderLabelPunteggio);
            this.bunifuGradientPanelModificaRecensione.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelModificaRecensione.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelModificaRecensione.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelModificaRecensione.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelModificaRecensione.Location = new System.Drawing.Point(172, 232);
            this.bunifuGradientPanelModificaRecensione.Name = "bunifuGradientPanelModificaRecensione";
            this.bunifuGradientPanelModificaRecensione.Quality = 10;
            this.bunifuGradientPanelModificaRecensione.Size = new System.Drawing.Size(843, 307);
            this.bunifuGradientPanelModificaRecensione.TabIndex = 24;
            // 
            // textBoxLibro
            // 
            this.textBoxLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLibro.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxLibro.Location = new System.Drawing.Point(308, 57);
            this.textBoxLibro.Name = "textBoxLibro";
            this.textBoxLibro.ReadOnly = true;
            this.textBoxLibro.Size = new System.Drawing.Size(482, 44);
            this.textBoxLibro.TabIndex = 11;
            // 
            // borderLabelLibro
            // 
            this.borderLabelLibro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelLibro.AutoSize = true;
            this.borderLabelLibro.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelLibro.BorderColor = System.Drawing.Color.Black;
            this.borderLabelLibro.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelLibro.Location = new System.Drawing.Point(85, 60);
            this.borderLabelLibro.Name = "borderLabelLibro";
            this.borderLabelLibro.Size = new System.Drawing.Size(111, 38);
            this.borderLabelLibro.TabIndex = 10;
            this.borderLabelLibro.Text = "Libro: ";
            // 
            // textBoxCommento
            // 
            this.textBoxCommento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCommento.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxCommento.Location = new System.Drawing.Point(308, 174);
            this.textBoxCommento.Multiline = true;
            this.textBoxCommento.Name = "textBoxCommento";
            this.textBoxCommento.ReadOnly = true;
            this.textBoxCommento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommento.Size = new System.Drawing.Size(482, 114);
            this.textBoxCommento.TabIndex = 9;
            // 
            // textBoxPunteggio
            // 
            this.textBoxPunteggio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPunteggio.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxPunteggio.Location = new System.Drawing.Point(308, 119);
            this.textBoxPunteggio.Name = "textBoxPunteggio";
            this.textBoxPunteggio.ReadOnly = true;
            this.textBoxPunteggio.Size = new System.Drawing.Size(482, 44);
            this.textBoxPunteggio.TabIndex = 8;
            // 
            // borderLabelCommento
            // 
            this.borderLabelCommento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelCommento.AutoSize = true;
            this.borderLabelCommento.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelCommento.BorderColor = System.Drawing.Color.Black;
            this.borderLabelCommento.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelCommento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelCommento.Location = new System.Drawing.Point(85, 177);
            this.borderLabelCommento.Name = "borderLabelCommento";
            this.borderLabelCommento.Size = new System.Drawing.Size(183, 38);
            this.borderLabelCommento.TabIndex = 7;
            this.borderLabelCommento.Text = "Commento:";
            // 
            // borderLabelPunteggio
            // 
            this.borderLabelPunteggio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelPunteggio.AutoSize = true;
            this.borderLabelPunteggio.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelPunteggio.BorderColor = System.Drawing.Color.Black;
            this.borderLabelPunteggio.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelPunteggio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelPunteggio.Location = new System.Drawing.Point(85, 122);
            this.borderLabelPunteggio.Name = "borderLabelPunteggio";
            this.borderLabelPunteggio.Size = new System.Drawing.Size(177, 38);
            this.borderLabelPunteggio.TabIndex = 4;
            this.borderLabelPunteggio.Text = "Punteggio: ";
            // 
            // borderLabelModificaRecensione
            // 
            this.borderLabelModificaRecensione.AutoSize = true;
            this.borderLabelModificaRecensione.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelModificaRecensione.BorderColor = System.Drawing.Color.Black;
            this.borderLabelModificaRecensione.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelModificaRecensione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelModificaRecensione.Location = new System.Drawing.Point(161, 93);
            this.borderLabelModificaRecensione.Name = "borderLabelModificaRecensione";
            this.borderLabelModificaRecensione.Size = new System.Drawing.Size(309, 65);
            this.borderLabelModificaRecensione.TabIndex = 23;
            this.borderLabelModificaRecensione.Text = "Recensione";
            // 
            // RecensioneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuImageButtonBack);
            this.Controls.Add(this.buttonSegnala);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.bunifuGradientPanelModificaRecensione);
            this.Controls.Add(this.borderLabelModificaRecensione);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecensioneView";
            this.Text = "Recensione";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.bunifuGradientPanelModificaRecensione.ResumeLayout(false);
            this.bunifuGradientPanelModificaRecensione.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private System.Windows.Forms.Button buttonSegnala;
        private System.Windows.Forms.Button buttonSalva;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelModificaRecensione;
        private System.Windows.Forms.TextBox textBoxCommento;
        private System.Windows.Forms.TextBox textBoxPunteggio;
        private BorderLabel borderLabelCommento;
        private BorderLabel borderLabelPunteggio;
        private BorderLabel borderLabelModificaRecensione;
        private System.Windows.Forms.TextBox textBoxLibro;
        private BorderLabel borderLabelLibro;
    }
}