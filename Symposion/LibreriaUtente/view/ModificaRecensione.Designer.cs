using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class ModificaRecensione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaRecensione));
            this.bunifuGradientPanelModificaRecensione = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textBoxCommento = new System.Windows.Forms.TextBox();
            this.textBoxPunteggio = new System.Windows.Forms.TextBox();
            this.borderLabelCommento = new Libreria.BorderLabel();
            this.borderLabelPunteggio = new Libreria.BorderLabel();
            this.borderLabelModificaRecensione = new Libreria.BorderLabel();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanelModificaRecensione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuGradientPanelModificaRecensione.TabIndex = 19;
            // 
            // textBoxCommento
            // 
            this.textBoxCommento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCommento.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxCommento.Location = new System.Drawing.Point(308, 126);
            this.textBoxCommento.Multiline = true;
            this.textBoxCommento.Name = "textBoxCommento";
            this.textBoxCommento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommento.Size = new System.Drawing.Size(394, 74);
            this.textBoxCommento.TabIndex = 9;
            // 
            // textBoxPunteggio
            // 
            this.textBoxPunteggio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPunteggio.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxPunteggio.Location = new System.Drawing.Point(308, 60);
            this.textBoxPunteggio.Name = "textBoxPunteggio";
            this.textBoxPunteggio.Size = new System.Drawing.Size(471, 44);
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
            this.borderLabelCommento.Location = new System.Drawing.Point(55, 123);
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
            this.borderLabelPunteggio.Location = new System.Drawing.Point(55, 66);
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
            this.borderLabelModificaRecensione.Size = new System.Drawing.Size(540, 65);
            this.borderLabelModificaRecensione.TabIndex = 18;
            this.borderLabelModificaRecensione.Text = "Modifica Recensione";
            // 
            // buttonElimina
            // 
            this.buttonElimina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonElimina.FlatAppearance.BorderSize = 0;
            this.buttonElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElimina.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonElimina.ForeColor = System.Drawing.Color.Black;
            this.buttonElimina.Location = new System.Drawing.Point(697, 487);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(152, 44);
            this.buttonElimina.TabIndex = 21;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = false;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonSalva.FlatAppearance.BorderSize = 0;
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonSalva.ForeColor = System.Drawing.Color.White;
            this.buttonSalva.Location = new System.Drawing.Point(863, 487);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(152, 44);
            this.buttonSalva.TabIndex = 20;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = false;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
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
            this.bunifuImageButtonBack.TabIndex = 22;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // ModificaRecensione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuImageButtonBack);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.buttonSalva);
            this.Controls.Add(this.bunifuGradientPanelModificaRecensione);
            this.Controls.Add(this.borderLabelModificaRecensione);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificaRecensione";
            this.Text = "Modifica Recensione";
            this.bunifuGradientPanelModificaRecensione.ResumeLayout(false);
            this.bunifuGradientPanelModificaRecensione.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelModificaRecensione;
        private System.Windows.Forms.TextBox textBoxCommento;
        private System.Windows.Forms.TextBox textBoxPunteggio;
        private BorderLabel borderLabelCommento;
        private BorderLabel borderLabelPunteggio;
        private BorderLabel borderLabelModificaRecensione;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonSalva;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
    }
}