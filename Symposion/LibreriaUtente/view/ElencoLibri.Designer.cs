using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class ElencoLibri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElencoLibri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanelListaLibri = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.borderLabelLibri = new Libreria.BorderLabel();
            this.dataGridViewLibri = new System.Windows.Forms.DataGridView();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.Titolo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Autore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AnnoPubblicazione = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Genere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Copertina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanelListaLibri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelListaLibri
            // 
            this.bunifuGradientPanelListaLibri.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelListaLibri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelListaLibri.BackgroundImage")));
            this.bunifuGradientPanelListaLibri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelListaLibri.Controls.Add(this.borderLabelLibri);
            this.bunifuGradientPanelListaLibri.Controls.Add(this.dataGridViewLibri);
            this.bunifuGradientPanelListaLibri.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelListaLibri.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelListaLibri.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelListaLibri.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelListaLibri.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelListaLibri.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelListaLibri.Name = "bunifuGradientPanelListaLibri";
            this.bunifuGradientPanelListaLibri.Quality = 10;
            this.bunifuGradientPanelListaLibri.Size = new System.Drawing.Size(1163, 689);
            this.bunifuGradientPanelListaLibri.TabIndex = 11;
            // 
            // borderLabelLibri
            // 
            this.borderLabelLibri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelLibri.AutoSize = true;
            this.borderLabelLibri.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelLibri.BorderColor = System.Drawing.Color.Black;
            this.borderLabelLibri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderLabelLibri.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelLibri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelLibri.Location = new System.Drawing.Point(161, 93);
            this.borderLabelLibri.Name = "borderLabelLibri";
            this.borderLabelLibri.Size = new System.Drawing.Size(189, 82);
            this.borderLabelLibri.TabIndex = 26;
            this.borderLabelLibri.Text = "Libri";
            // 
            // dataGridViewLibri
            // 
            this.dataGridViewLibri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLibri.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLibri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titolo,
            this.Autore,
            this.AnnoPubblicazione,
            this.Genere,
            this.Copertina});
            this.dataGridViewLibri.GridColor = System.Drawing.Color.Black;
            this.dataGridViewLibri.Location = new System.Drawing.Point(175, 270);
            this.dataGridViewLibri.Name = "dataGridViewLibri";
            this.dataGridViewLibri.ReadOnly = true;
            this.dataGridViewLibri.Size = new System.Drawing.Size(840, 230);
            this.dataGridViewLibri.TabIndex = 25;
            this.dataGridViewLibri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibri_CellContentClick);
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
            this.bunifuImageButtonBack.TabIndex = 24;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // Titolo
            // 
            this.Titolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Titolo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Titolo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titolo.HeaderText = "Titolo";
            this.Titolo.MinimumWidth = 350;
            this.Titolo.Name = "Titolo";
            this.Titolo.ReadOnly = true;
            this.Titolo.Text = "";
            this.Titolo.Width = 350;
            // 
            // Autore
            // 
            this.Autore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Autore.DefaultCellStyle = dataGridViewCellStyle2;
            this.Autore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Autore.HeaderText = "Autore";
            this.Autore.MinimumWidth = 300;
            this.Autore.Name = "Autore";
            this.Autore.ReadOnly = true;
            this.Autore.Text = "";
            this.Autore.Width = 300;
            // 
            // AnnoPubblicazione
            // 
            this.AnnoPubblicazione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.AnnoPubblicazione.DefaultCellStyle = dataGridViewCellStyle3;
            this.AnnoPubblicazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnoPubblicazione.HeaderText = "Anno Pubblicazione";
            this.AnnoPubblicazione.MinimumWidth = 200;
            this.AnnoPubblicazione.Name = "AnnoPubblicazione";
            this.AnnoPubblicazione.ReadOnly = true;
            this.AnnoPubblicazione.Width = 200;
            // 
            // Genere
            // 
            this.Genere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Genere.DefaultCellStyle = dataGridViewCellStyle4;
            this.Genere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genere.HeaderText = "Genere";
            this.Genere.MinimumWidth = 250;
            this.Genere.Name = "Genere";
            this.Genere.ReadOnly = true;
            this.Genere.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Genere.Width = 250;
            // 
            // Copertina
            // 
            this.Copertina.HeaderText = "Copertina";
            this.Copertina.Name = "Copertina";
            this.Copertina.ReadOnly = true;
            this.Copertina.Visible = false;
            // 
            // ElencoLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuGradientPanelListaLibri);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElencoLibri";
            this.Text = "Libri ";
            this.bunifuGradientPanelListaLibri.ResumeLayout(false);
            this.bunifuGradientPanelListaLibri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelListaLibri;
        private System.Windows.Forms.DataGridView dataGridViewLibri;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private BorderLabel borderLabelLibri;
        private System.Windows.Forms.DataGridViewButtonColumn Titolo;
        private System.Windows.Forms.DataGridViewButtonColumn Autore;
        private System.Windows.Forms.DataGridViewButtonColumn AnnoPubblicazione;
        private System.Windows.Forms.DataGridViewButtonColumn Genere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copertina;
    }
}