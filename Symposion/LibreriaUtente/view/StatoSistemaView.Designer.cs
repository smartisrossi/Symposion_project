using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class StatoSistemaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatoSistemaView));
            this.borderLabelStatoSistema = new Libreria.BorderLabel();
            this.bunifuGradientPanelStatoSistema = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.listViewStatoSistema = new System.Windows.Forms.ListView();
            this.Componente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InFunzione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.bunifuGradientPanelStatoSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderLabelStatoSistema
            // 
            this.borderLabelStatoSistema.AutoSize = true;
            this.borderLabelStatoSistema.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelStatoSistema.BorderColor = System.Drawing.Color.Black;
            this.borderLabelStatoSistema.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelStatoSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelStatoSistema.Location = new System.Drawing.Point(36, 100);
            this.borderLabelStatoSistema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borderLabelStatoSistema.Name = "borderLabelStatoSistema";
            this.borderLabelStatoSistema.Size = new System.Drawing.Size(625, 109);
            this.borderLabelStatoSistema.TabIndex = 13;
            this.borderLabelStatoSistema.Text = "Stato Sistema";
            this.borderLabelStatoSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuGradientPanelStatoSistema
            // 
            this.bunifuGradientPanelStatoSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelStatoSistema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelStatoSistema.BackgroundImage")));
            this.bunifuGradientPanelStatoSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelStatoSistema.Controls.Add(this.listViewStatoSistema);
            this.bunifuGradientPanelStatoSistema.Controls.Add(this.borderLabelStatoSistema);
            this.bunifuGradientPanelStatoSistema.Controls.Add(this.buttonChiudi);
            this.bunifuGradientPanelStatoSistema.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelStatoSistema.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelStatoSistema.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelStatoSistema.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelStatoSistema.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelStatoSistema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanelStatoSistema.Name = "bunifuGradientPanelStatoSistema";
            this.bunifuGradientPanelStatoSistema.Quality = 10;
            this.bunifuGradientPanelStatoSistema.Size = new System.Drawing.Size(1163, 689);
            this.bunifuGradientPanelStatoSistema.TabIndex = 14;
            // 
            // listViewStatoSistema
            // 
            this.listViewStatoSistema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewStatoSistema.BackColor = System.Drawing.Color.White;
            this.listViewStatoSistema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStatoSistema.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Componente,
            this.InFunzione,
            this.Stato});
            this.listViewStatoSistema.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.listViewStatoSistema.Location = new System.Drawing.Point(55, 230);
            this.listViewStatoSistema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewStatoSistema.Name = "listViewStatoSistema";
            this.listViewStatoSistema.Size = new System.Drawing.Size(1024, 312);
            this.listViewStatoSistema.TabIndex = 14;
            this.listViewStatoSistema.UseCompatibleStateImageBehavior = false;
            this.listViewStatoSistema.View = System.Windows.Forms.View.Details;
            // 
            // Componente
            // 
            this.Componente.Text = "Componente";
            this.Componente.Width = 300;
            // 
            // InFunzione
            // 
            this.InFunzione.Text = "In funzione";
            this.InFunzione.Width = 250;
            // 
            // Stato
            // 
            this.Stato.Text = "Stato";
            this.Stato.Width = 100;
            // 
            // buttonChiudi
            // 
            this.buttonChiudi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChiudi.AutoSize = true;
            this.buttonChiudi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonChiudi.FlatAppearance.BorderSize = 0;
            this.buttonChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiudi.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonChiudi.ForeColor = System.Drawing.Color.White;
            this.buttonChiudi.Location = new System.Drawing.Point(917, 552);
            this.buttonChiudi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(162, 60);
            this.buttonChiudi.TabIndex = 13;
            this.buttonChiudi.Text = "Chiudi";
            this.buttonChiudi.UseVisualStyleBackColor = false;
            this.buttonChiudi.Click += new System.EventHandler(this.buttonChiudi_Click);
            // 
            // StatoSistemaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuGradientPanelStatoSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatoSistemaView";
            this.Text = "StatoSistema";
            this.bunifuGradientPanelStatoSistema.ResumeLayout(false);
            this.bunifuGradientPanelStatoSistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BorderLabel borderLabelStatoSistema;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelStatoSistema;
        private System.Windows.Forms.ListView listViewStatoSistema;
        private System.Windows.Forms.ColumnHeader Componente;
        private System.Windows.Forms.ColumnHeader InFunzione;
        private System.Windows.Forms.ColumnHeader Stato;
        private System.Windows.Forms.Button buttonChiudi;
    }
}