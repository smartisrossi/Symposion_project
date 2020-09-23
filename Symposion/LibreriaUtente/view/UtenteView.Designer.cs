using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class UtenteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtenteView));
            this.listeUtente = new System.Windows.Forms.Button();
            this.recensioniUtente = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelUtente = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.borderLabelUsername = new Libreria.BorderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.panelUtente.SuspendLayout();
            this.SuspendLayout();
            // 
            // listeUtente
            // 
            this.listeUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listeUtente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.listeUtente.FlatAppearance.BorderSize = 0;
            this.listeUtente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listeUtente.Font = new System.Drawing.Font("Georgia", 12F);
            this.listeUtente.ForeColor = System.Drawing.Color.Black;
            this.listeUtente.Location = new System.Drawing.Point(54, 112);
            this.listeUtente.Name = "listeUtente";
            this.listeUtente.Size = new System.Drawing.Size(893, 45);
            this.listeUtente.TabIndex = 22;
            this.listeUtente.Text = "Liste";
            this.listeUtente.UseVisualStyleBackColor = false;
            this.listeUtente.Click += new System.EventHandler(this.listeUtente_Click);
            // 
            // recensioniUtente
            // 
            this.recensioniUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recensioniUtente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.recensioniUtente.FlatAppearance.BorderSize = 0;
            this.recensioniUtente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recensioniUtente.Font = new System.Drawing.Font("Georgia", 12F);
            this.recensioniUtente.ForeColor = System.Drawing.Color.White;
            this.recensioniUtente.Location = new System.Drawing.Point(54, 61);
            this.recensioniUtente.Name = "recensioniUtente";
            this.recensioniUtente.Size = new System.Drawing.Size(893, 45);
            this.recensioniUtente.TabIndex = 21;
            this.recensioniUtente.Text = "Recensioni";
            this.recensioniUtente.UseVisualStyleBackColor = false;
            this.recensioniUtente.Click += new System.EventHandler(this.recensioniUtente_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Georgia", 20.25F);
            this.textBoxUsername.Location = new System.Drawing.Point(414, 166);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(623, 47);
            this.textBoxUsername.TabIndex = 28;
            // 
            // bunifuImageButtonBack
            // 
            this.bunifuImageButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonBack.Image")));
            this.bunifuImageButtonBack.ImageActive = null;
            this.bunifuImageButtonBack.Location = new System.Drawing.Point(1032, 31);
            this.bunifuImageButtonBack.Name = "bunifuImageButtonBack";
            this.bunifuImageButtonBack.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBack.TabIndex = 33;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // panelUtente
            // 
            this.panelUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUtente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUtente.BackgroundImage")));
            this.panelUtente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelUtente.Controls.Add(this.recensioniUtente);
            this.panelUtente.Controls.Add(this.listeUtente);
            this.panelUtente.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.panelUtente.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.panelUtente.GradientTopLeft = System.Drawing.Color.White;
            this.panelUtente.GradientTopRight = System.Drawing.Color.White;
            this.panelUtente.Location = new System.Drawing.Point(70, 315);
            this.panelUtente.Name = "panelUtente";
            this.panelUtente.Quality = 10;
            this.panelUtente.Size = new System.Drawing.Size(1033, 209);
            this.panelUtente.TabIndex = 34;
            // 
            // borderLabelUsername
            // 
            this.borderLabelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelUsername.AutoSize = true;
            this.borderLabelUsername.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelUsername.BorderColor = System.Drawing.Color.Black;
            this.borderLabelUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderLabelUsername.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelUsername.Location = new System.Drawing.Point(62, 156);
            this.borderLabelUsername.Name = "borderLabelUsername";
            this.borderLabelUsername.Size = new System.Drawing.Size(346, 47);
            this.borderLabelUsername.TabIndex = 27;
            this.borderLabelUsername.Text = "Username utente:";
            // 
            // UtenteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 632);
            this.Controls.Add(this.panelUtente);
            this.Controls.Add(this.bunifuImageButtonBack);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.borderLabelUsername);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UtenteView";
            this.Text = "Utente";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.panelUtente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button listeUtente;
        private System.Windows.Forms.Button recensioniUtente;
        private BorderLabel borderLabelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private Bunifu.Framework.UI.BunifuGradientPanel panelUtente;
    }
}