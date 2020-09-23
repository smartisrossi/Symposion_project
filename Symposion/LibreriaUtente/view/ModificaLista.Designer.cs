using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    partial class ModificaLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificaLista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.borderLabelModificaLista = new Libreria.BorderLabel();
            this.buttonSalva = new System.Windows.Forms.Button();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanelCreaLista = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dataGridViewLibri = new System.Windows.Forms.DataGridView();
            this.Titolo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Autore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AnnoPubblicazione = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Genere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Copertina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxGeneri = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.borderLabelGenere = new Libreria.BorderLabel();
            this.borderLabelLibri = new Libreria.BorderLabel();
            this.borderLabelNome = new Libreria.BorderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.bunifuGradientPanelCreaLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // borderLabelModificaLista
            // 
            this.borderLabelModificaLista.AutoSize = true;
            this.borderLabelModificaLista.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelModificaLista.BorderColor = System.Drawing.Color.Black;
            this.borderLabelModificaLista.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelModificaLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelModificaLista.Location = new System.Drawing.Point(161, 93);
            this.borderLabelModificaLista.Name = "borderLabelModificaLista";
            this.borderLabelModificaLista.Size = new System.Drawing.Size(380, 65);
            this.borderLabelModificaLista.TabIndex = 15;
            this.borderLabelModificaLista.Text = "Modifica Lista";
            // 
            // buttonSalva
            // 
            this.buttonSalva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonSalva.FlatAppearance.BorderSize = 0;
            this.buttonSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalva.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonSalva.ForeColor = System.Drawing.Color.White;
            this.buttonSalva.Location = new System.Drawing.Point(887, 552);
            this.buttonSalva.Name = "buttonSalva";
            this.buttonSalva.Size = new System.Drawing.Size(135, 37);
            this.buttonSalva.TabIndex = 14;
            this.buttonSalva.Text = "Salva";
            this.buttonSalva.UseVisualStyleBackColor = false;
            this.buttonSalva.Click += new System.EventHandler(this.buttonSalva_Click);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonElimina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonElimina.FlatAppearance.BorderSize = 0;
            this.buttonElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElimina.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonElimina.ForeColor = System.Drawing.Color.Black;
            this.buttonElimina.Location = new System.Drawing.Point(752, 552);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(126, 37);
            this.buttonElimina.TabIndex = 17;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = false;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // bunifuImageButtonBack
            // 
            this.bunifuImageButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonBack.Image")));
            this.bunifuImageButtonBack.ImageActive = null;
            this.bunifuImageButtonBack.Location = new System.Drawing.Point(944, 93);
            this.bunifuImageButtonBack.Name = "bunifuImageButtonBack";
            this.bunifuImageButtonBack.Size = new System.Drawing.Size(78, 59);
            this.bunifuImageButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBack.TabIndex = 18;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // bunifuGradientPanelCreaLista
            // 
            this.bunifuGradientPanelCreaLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelCreaLista.AutoSize = true;
            this.bunifuGradientPanelCreaLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelCreaLista.BackgroundImage")));
            this.bunifuGradientPanelCreaLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelCreaLista.Controls.Add(this.dataGridViewLibri);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.buttonElimina);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.buttonSalva);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.comboBoxGeneri);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.textBoxNome);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.borderLabelModificaLista);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.borderLabelGenere);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.borderLabelLibri);
            this.bunifuGradientPanelCreaLista.Controls.Add(this.borderLabelNome);
            this.bunifuGradientPanelCreaLista.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelCreaLista.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelCreaLista.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelCreaLista.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelCreaLista.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelCreaLista.Name = "bunifuGradientPanelCreaLista";
            this.bunifuGradientPanelCreaLista.Quality = 10;
            this.bunifuGradientPanelCreaLista.Size = new System.Drawing.Size(1163, 689);
            this.bunifuGradientPanelCreaLista.TabIndex = 19;
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
            this.dataGridViewLibri.Location = new System.Drawing.Point(321, 349);
            this.dataGridViewLibri.Name = "dataGridViewLibri";
            this.dataGridViewLibri.ReadOnly = true;
            this.dataGridViewLibri.Size = new System.Drawing.Size(701, 186);
            this.dataGridViewLibri.TabIndex = 26;
            this.dataGridViewLibri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibri_CellContentClick);
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
            this.Titolo.MinimumWidth = 250;
            this.Titolo.Name = "Titolo";
            this.Titolo.ReadOnly = true;
            this.Titolo.Text = "";
            this.Titolo.Width = 250;
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
            this.Autore.MinimumWidth = 200;
            this.Autore.Name = "Autore";
            this.Autore.ReadOnly = true;
            this.Autore.Text = "";
            this.Autore.Width = 200;
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
            // Copertina
            // 
            this.Copertina.HeaderText = "Copertina";
            this.Copertina.Name = "Copertina";
            this.Copertina.ReadOnly = true;
            this.Copertina.Visible = false;
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
            this.comboBoxGeneri.Location = new System.Drawing.Point(321, 284);
            this.comboBoxGeneri.Name = "comboBoxGeneri";
            this.comboBoxGeneri.Size = new System.Drawing.Size(701, 28);
            this.comboBoxGeneri.Sorted = true;
            this.comboBoxGeneri.TabIndex = 15;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNome.Font = new System.Drawing.Font("Georgia", 16F);
            this.textBoxNome.Location = new System.Drawing.Point(321, 203);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(701, 44);
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
            this.borderLabelGenere.Location = new System.Drawing.Point(173, 272);
            this.borderLabelGenere.Name = "borderLabelGenere";
            this.borderLabelGenere.Size = new System.Drawing.Size(127, 38);
            this.borderLabelGenere.TabIndex = 7;
            this.borderLabelGenere.Text = "Genere:";
            // 
            // borderLabelLibri
            // 
            this.borderLabelLibri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelLibri.AutoSize = true;
            this.borderLabelLibri.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelLibri.BorderColor = System.Drawing.Color.Black;
            this.borderLabelLibri.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelLibri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelLibri.Location = new System.Drawing.Point(205, 337);
            this.borderLabelLibri.Name = "borderLabelLibri";
            this.borderLabelLibri.Size = new System.Drawing.Size(95, 38);
            this.borderLabelLibri.TabIndex = 6;
            this.borderLabelLibri.Text = "Libri:";
            // 
            // borderLabelNome
            // 
            this.borderLabelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelNome.AutoSize = true;
            this.borderLabelNome.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelNome.BorderColor = System.Drawing.Color.Black;
            this.borderLabelNome.Font = new System.Drawing.Font("Georgia", 16F);
            this.borderLabelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelNome.Location = new System.Drawing.Point(188, 209);
            this.borderLabelNome.Name = "borderLabelNome";
            this.borderLabelNome.Size = new System.Drawing.Size(112, 38);
            this.borderLabelNome.TabIndex = 4;
            this.borderLabelNome.Text = "Nome:";
            // 
            // ModificaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuGradientPanelCreaLista);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificaLista";
            this.Text = "Modifica Lista";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.bunifuGradientPanelCreaLista.ResumeLayout(false);
            this.bunifuGradientPanelCreaLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BorderLabel borderLabelModificaLista;
        private System.Windows.Forms.Button buttonSalva;
        private System.Windows.Forms.Button buttonElimina;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelCreaLista;
        private System.Windows.Forms.ComboBox comboBoxGeneri;
        private System.Windows.Forms.TextBox textBoxNome;
        private BorderLabel borderLabelGenere;
        private BorderLabel borderLabelLibri;
        private BorderLabel borderLabelNome;
        private System.Windows.Forms.DataGridView dataGridViewLibri;
        private System.Windows.Forms.DataGridViewButtonColumn Titolo;
        private System.Windows.Forms.DataGridViewButtonColumn Autore;
        private System.Windows.Forms.DataGridViewButtonColumn AnnoPubblicazione;
        private System.Windows.Forms.DataGridViewButtonColumn Genere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copertina;
    }
}