using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class SistemaOperativoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaOperativoView));
            this.borderLabelSistemaOperativo = new Libreria.BorderLabel();
            this.bunifuGradientPanelSO = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.listViewSO = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuGradientPanelSO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // borderLabelSistemaOperativo
            // 
            this.borderLabelSistemaOperativo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelSistemaOperativo.AutoSize = true;
            this.borderLabelSistemaOperativo.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelSistemaOperativo.BorderColor = System.Drawing.Color.Black;
            this.borderLabelSistemaOperativo.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelSistemaOperativo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelSistemaOperativo.Location = new System.Drawing.Point(36, 120);
            this.borderLabelSistemaOperativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borderLabelSistemaOperativo.Name = "borderLabelSistemaOperativo";
            this.borderLabelSistemaOperativo.Size = new System.Drawing.Size(825, 109);
            this.borderLabelSistemaOperativo.TabIndex = 9;
            this.borderLabelSistemaOperativo.Text = "Sistema Operativo";
            this.borderLabelSistemaOperativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuGradientPanelSO
            // 
            this.bunifuGradientPanelSO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelSO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelSO.BackgroundImage")));
            this.bunifuGradientPanelSO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelSO.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanelSO.Controls.Add(this.buttonChiudi);
            this.bunifuGradientPanelSO.Controls.Add(this.borderLabelSistemaOperativo);
            this.bunifuGradientPanelSO.Controls.Add(this.listViewSO);
            this.bunifuGradientPanelSO.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelSO.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelSO.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelSO.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelSO.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelSO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanelSO.Name = "bunifuGradientPanelSO";
            this.bunifuGradientPanelSO.Quality = 10;
            this.bunifuGradientPanelSO.Size = new System.Drawing.Size(1163, 741);
            this.bunifuGradientPanelSO.TabIndex = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(-33, -67);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 14;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
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
            this.buttonChiudi.Location = new System.Drawing.Point(917, 593);
            this.buttonChiudi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(162, 60);
            this.buttonChiudi.TabIndex = 13;
            this.buttonChiudi.Text = "Chiudi";
            this.buttonChiudi.UseVisualStyleBackColor = false;
            this.buttonChiudi.Click += new System.EventHandler(this.buttonChiudi_Click);
            // 
            // listViewSO
            // 
            this.listViewSO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewSO.BackColor = System.Drawing.Color.White;
            this.listViewSO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewSO.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.listViewSO.Location = new System.Drawing.Point(55, 256);
            this.listViewSO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewSO.Name = "listViewSO";
            this.listViewSO.Size = new System.Drawing.Size(1024, 312);
            this.listViewSO.TabIndex = 3;
            this.listViewSO.UseCompatibleStateImageBehavior = false;
            this.listViewSO.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sistema Operativo";
            this.columnHeader1.Width = 650;
            // 
            // SistemaOperativoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuGradientPanelSO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SistemaOperativoView";
            this.Text = "SistemaOperativo";
            this.bunifuGradientPanelSO.ResumeLayout(false);
            this.bunifuGradientPanelSO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderLabel borderLabelSistemaOperativo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelSO;
        private System.Windows.Forms.Button buttonChiudi;
        private System.Windows.Forms.ListView listViewSO;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}