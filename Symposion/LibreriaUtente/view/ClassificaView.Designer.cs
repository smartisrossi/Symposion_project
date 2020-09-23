using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class ClassificaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassificaView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanelChart = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dataGridViewClassifica = new System.Windows.Forms.DataGridView();
            this.Titolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibroRecensionePreferita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentoRecensionePreferita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borderLabelClassifica = new Libreria.BorderLabel();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelChart
            // 
            this.bunifuGradientPanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelChart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelChart.BackgroundImage")));
            this.bunifuGradientPanelChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelChart.Controls.Add(this.dataGridViewClassifica);
            this.bunifuGradientPanelChart.Controls.Add(this.borderLabelClassifica);
            this.bunifuGradientPanelChart.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelChart.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelChart.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelChart.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelChart.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelChart.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelChart.Name = "bunifuGradientPanelChart";
            this.bunifuGradientPanelChart.Quality = 10;
            this.bunifuGradientPanelChart.Size = new System.Drawing.Size(1163, 689);
            this.bunifuGradientPanelChart.TabIndex = 8;
            // 
            // dataGridViewClassifica
            // 
            this.dataGridViewClassifica.AllowUserToAddRows = false;
            this.dataGridViewClassifica.AllowUserToDeleteRows = false;
            this.dataGridViewClassifica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClassifica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewClassifica.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridViewClassifica.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClassifica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClassifica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassifica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titolo,
            this.Autore,
            this.LibroRecensionePreferita,
            this.CommentoRecensionePreferita});
            this.dataGridViewClassifica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewClassifica.GridColor = System.Drawing.Color.Black;
            this.dataGridViewClassifica.Location = new System.Drawing.Point(180, 258);
            this.dataGridViewClassifica.Name = "dataGridViewClassifica";
            this.dataGridViewClassifica.Size = new System.Drawing.Size(835, 294);
            this.dataGridViewClassifica.TabIndex = 28;
            // 
            // Titolo
            // 
            this.Titolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Titolo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Titolo.HeaderText = "Titolo";
            this.Titolo.MinimumWidth = 300;
            this.Titolo.Name = "Titolo";
            this.Titolo.ReadOnly = true;
            this.Titolo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Titolo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Titolo.Width = 300;
            // 
            // Autore
            // 
            this.Autore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Autore.DefaultCellStyle = dataGridViewCellStyle2;
            this.Autore.HeaderText = "Autore";
            this.Autore.MinimumWidth = 200;
            this.Autore.Name = "Autore";
            this.Autore.ReadOnly = true;
            this.Autore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Autore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Autore.Width = 200;
            // 
            // LibroRecensionePreferita
            // 
            this.LibroRecensionePreferita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.LibroRecensionePreferita.DefaultCellStyle = dataGridViewCellStyle3;
            this.LibroRecensionePreferita.FillWeight = 172.9F;
            this.LibroRecensionePreferita.HeaderText = "Anno Pubblicazione";
            this.LibroRecensionePreferita.MinimumWidth = 150;
            this.LibroRecensionePreferita.Name = "LibroRecensionePreferita";
            this.LibroRecensionePreferita.ReadOnly = true;
            this.LibroRecensionePreferita.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LibroRecensionePreferita.Width = 150;
            // 
            // CommentoRecensionePreferita
            // 
            this.CommentoRecensionePreferita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.CommentoRecensionePreferita.DefaultCellStyle = dataGridViewCellStyle4;
            this.CommentoRecensionePreferita.FillWeight = 27.02F;
            this.CommentoRecensionePreferita.HeaderText = "Genere";
            this.CommentoRecensionePreferita.MinimumWidth = 150;
            this.CommentoRecensionePreferita.Name = "CommentoRecensionePreferita";
            this.CommentoRecensionePreferita.ReadOnly = true;
            this.CommentoRecensionePreferita.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CommentoRecensionePreferita.Width = 150;
            // 
            // borderLabelClassifica
            // 
            this.borderLabelClassifica.AutoSize = true;
            this.borderLabelClassifica.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelClassifica.BorderColor = System.Drawing.Color.Black;
            this.borderLabelClassifica.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelClassifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelClassifica.Location = new System.Drawing.Point(161, 93);
            this.borderLabelClassifica.Name = "borderLabelClassifica";
            this.borderLabelClassifica.Size = new System.Drawing.Size(445, 109);
            this.borderLabelClassifica.TabIndex = 27;
            this.borderLabelClassifica.Text = "Classifica";
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
            // ClassificaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuGradientPanelChart);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassificaView";
            this.Text = "Classifica";
            this.bunifuGradientPanelChart.ResumeLayout(false);
            this.bunifuGradientPanelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelChart;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private BorderLabel borderLabelClassifica;
        private System.Windows.Forms.DataGridView dataGridViewClassifica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autore;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibroRecensionePreferita;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentoRecensionePreferita;
    }
}