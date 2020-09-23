using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class PubblicaRecensione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PubblicaRecensione));
            this.borderLabelSalotto = new Libreria.BorderLabel();
            this.bunifuGradientPanelModificaRecensione = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textBoxCommento = new System.Windows.Forms.TextBox();
            this.textBoxPunteggio = new System.Windows.Forms.TextBox();
            this.borderLabelCommento = new Libreria.BorderLabel();
            this.borderLabelPunteggio = new Libreria.BorderLabel();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonPubblica = new System.Windows.Forms.Button();
            this.bunifuGradientPanelModificaRecensione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // borderLabelSalotto
            // 
            this.borderLabelSalotto.AutoSize = true;
            this.borderLabelSalotto.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelSalotto.BorderColor = System.Drawing.Color.Black;
            this.borderLabelSalotto.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelSalotto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelSalotto.Location = new System.Drawing.Point(161, 93);
            this.borderLabelSalotto.Name = "borderLabelSalotto";
            this.borderLabelSalotto.Size = new System.Drawing.Size(536, 65);
            this.borderLabelSalotto.TabIndex = 15;
            this.borderLabelSalotto.Text = "Pubblica Recensione";
            // 
            // bunifuGradientPanelModificaRecensione
            // 
            this.bunifuGradientPanelModificaRecensione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuGradientPanelModificaRecensione.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelModificaRecensione.BackgroundImage")));
            this.bunifuGradientPanelModificaRecensione.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.bunifuGradientPanelModificaRecensione.Size = new System.Drawing.Size(843, 234);
            this.bunifuGradientPanelModificaRecensione.TabIndex = 20;
            // 
            // textBoxCommento
            // 
            this.textBoxCommento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCommento.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxCommento.Location = new System.Drawing.Point(315, 110);
            this.textBoxCommento.Multiline = true;
            this.textBoxCommento.Name = "textBoxCommento";
            this.textBoxCommento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommento.Size = new System.Drawing.Size(465, 74);
            this.textBoxCommento.TabIndex = 9;
            // 
            // textBoxPunteggio
            // 
            this.textBoxPunteggio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPunteggio.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxPunteggio.Location = new System.Drawing.Point(315, 50);
            this.textBoxPunteggio.Name = "textBoxPunteggio";
            this.textBoxPunteggio.Size = new System.Drawing.Size(465, 44);
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
            this.borderLabelCommento.Location = new System.Drawing.Point(61, 107);
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
            this.borderLabelPunteggio.Location = new System.Drawing.Point(61, 50);
            this.borderLabelPunteggio.Name = "borderLabelPunteggio";
            this.borderLabelPunteggio.Size = new System.Drawing.Size(177, 38);
            this.borderLabelPunteggio.TabIndex = 4;
            this.borderLabelPunteggio.Text = "Punteggio: ";
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
            this.bunifuImageButtonBack.TabIndex = 23;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // buttonPubblica
            // 
            this.buttonPubblica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPubblica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonPubblica.FlatAppearance.BorderSize = 0;
            this.buttonPubblica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPubblica.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonPubblica.ForeColor = System.Drawing.Color.White;
            this.buttonPubblica.Location = new System.Drawing.Point(825, 487);
            this.buttonPubblica.Name = "buttonPubblica";
            this.buttonPubblica.Size = new System.Drawing.Size(190, 48);
            this.buttonPubblica.TabIndex = 24;
            this.buttonPubblica.Text = "Pubblica";
            this.buttonPubblica.UseVisualStyleBackColor = false;
            this.buttonPubblica.Click += new System.EventHandler(this.buttonPubblica_Click);
            // 
            // PubblicaRecensione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.buttonPubblica);
            this.Controls.Add(this.bunifuImageButtonBack);
            this.Controls.Add(this.bunifuGradientPanelModificaRecensione);
            this.Controls.Add(this.borderLabelSalotto);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PubblicaRecensione";
            this.Text = "Pubblica Recensione";
            this.bunifuGradientPanelModificaRecensione.ResumeLayout(false);
            this.bunifuGradientPanelModificaRecensione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BorderLabel borderLabelSalotto;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelModificaRecensione;
        private System.Windows.Forms.TextBox textBoxCommento;
        private System.Windows.Forms.TextBox textBoxPunteggio;
        private BorderLabel borderLabelCommento;
        private BorderLabel borderLabelPunteggio;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private System.Windows.Forms.Button buttonPubblica;
    }
}
