using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class ListaVisualizzazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaVisualizzazione));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanelListaPersonale = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.textBoxGenereLista = new System.Windows.Forms.TextBox();
            this.textBoxNomeLista = new System.Windows.Forms.TextBox();
            this.borderLabelGenereLista = new Libreria.BorderLabel();
            this.borderLabelNomeLista = new Libreria.BorderLabel();
            this.dataGridViewLibriLista = new System.Windows.Forms.DataGridView();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.Titolo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Autore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AnnoPubblicazione = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Genere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuGradientPanelListaPersonale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibriLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelListaPersonale
            // 
            this.bunifuGradientPanelListaPersonale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelListaPersonale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelListaPersonale.BackgroundImage")));
            this.bunifuGradientPanelListaPersonale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelListaPersonale.Controls.Add(this.textBoxGenereLista);
            this.bunifuGradientPanelListaPersonale.Controls.Add(this.textBoxNomeLista);
            this.bunifuGradientPanelListaPersonale.Controls.Add(this.dataGridViewLibriLista);
            this.bunifuGradientPanelListaPersonale.Controls.Add(this.borderLabelGenereLista);
            this.bunifuGradientPanelListaPersonale.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelListaPersonale.Controls.Add(this.borderLabelNomeLista);
            this.bunifuGradientPanelListaPersonale.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelListaPersonale.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelListaPersonale.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelListaPersonale.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelListaPersonale.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelListaPersonale.Name = "bunifuGradientPanelListaPersonale";
            this.bunifuGradientPanelListaPersonale.Quality = 10;
            this.bunifuGradientPanelListaPersonale.Size = new System.Drawing.Size(1148, 684);
            this.bunifuGradientPanelListaPersonale.TabIndex = 10;
            // 
            // textBoxGenereLista
            // 
            this.textBoxGenereLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGenereLista.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenereLista.Location = new System.Drawing.Point(422, 191);
            this.textBoxGenereLista.Name = "textBoxGenereLista";
            this.textBoxGenereLista.Size = new System.Drawing.Size(471, 43);
            this.textBoxGenereLista.TabIndex = 3;
            // 
            // textBoxNomeLista
            // 
            this.textBoxNomeLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomeLista.Font = new System.Drawing.Font("Georgia", 20.25F);
            this.textBoxNomeLista.Location = new System.Drawing.Point(422, 110);
            this.textBoxNomeLista.Name = "textBoxNomeLista";
            this.textBoxNomeLista.Size = new System.Drawing.Size(471, 54);
            this.textBoxNomeLista.TabIndex = 2;
            // 
            // borderLabelGenereLista
            // 
            this.borderLabelGenereLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelGenereLista.AutoSize = true;
            this.borderLabelGenereLista.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelGenereLista.BorderColor = System.Drawing.Color.Black;
            this.borderLabelGenereLista.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelGenereLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelGenereLista.Location = new System.Drawing.Point(168, 196);
            this.borderLabelGenereLista.Name = "borderLabelGenereLista";
            this.borderLabelGenereLista.Size = new System.Drawing.Size(194, 38);
            this.borderLabelGenereLista.TabIndex = 1;
            this.borderLabelGenereLista.Text = "Genere lista:";
            // 
            // borderLabelNomeLista
            // 
            this.borderLabelNomeLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelNomeLista.AutoSize = true;
            this.borderLabelNomeLista.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelNomeLista.BorderColor = System.Drawing.Color.Black;
            this.borderLabelNomeLista.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelNomeLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelNomeLista.Location = new System.Drawing.Point(167, 117);
            this.borderLabelNomeLista.Name = "borderLabelNomeLista";
            this.borderLabelNomeLista.Size = new System.Drawing.Size(229, 47);
            this.borderLabelNomeLista.TabIndex = 0;
            this.borderLabelNomeLista.Text = "Nome lista:";
            // 
            // dataGridViewLibriLista
            // 
            this.dataGridViewLibriLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewLibriLista.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLibriLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLibriLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibriLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titolo,
            this.Autore,
            this.AnnoPubblicazione,
            this.Genere});
            this.dataGridViewLibriLista.GridColor = System.Drawing.Color.Black;
            this.dataGridViewLibriLista.Location = new System.Drawing.Point(175, 270);
            this.dataGridViewLibriLista.Name = "dataGridViewLibriLista";
            this.dataGridViewLibriLista.ReadOnly = true;
            this.dataGridViewLibriLista.Size = new System.Drawing.Size(840, 247);
            this.dataGridViewLibriLista.TabIndex = 25;
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
            this.Titolo.Text = "Titolo";
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
            this.Autore.Text = "Autore";
            this.Autore.UseColumnTextForButtonValue = true;
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
            this.Genere.MinimumWidth = 100;
            this.Genere.Name = "Genere";
            this.Genere.ReadOnly = true;
            this.Genere.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ListaVisualizzazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuGradientPanelListaPersonale);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaVisualizzazione";
            this.Text = "Lista Personale";
            this.bunifuGradientPanelListaPersonale.ResumeLayout(false);
            this.bunifuGradientPanelListaPersonale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibriLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelListaPersonale;
        private System.Windows.Forms.TextBox textBoxGenereLista;
        private System.Windows.Forms.TextBox textBoxNomeLista;
        private BorderLabel borderLabelGenereLista;
        private BorderLabel borderLabelNomeLista;
        private System.Windows.Forms.DataGridView dataGridViewLibriLista;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private System.Windows.Forms.DataGridViewButtonColumn Titolo;
        private System.Windows.Forms.DataGridViewButtonColumn Autore;
        private System.Windows.Forms.DataGridViewButtonColumn AnnoPubblicazione;
        private System.Windows.Forms.DataGridViewButtonColumn Genere;
    }
}
