namespace Libreria
{
    partial class ElencoListeUtente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElencoListeUtente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanelAggiungiALista = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.borderLabelListeUtente = new Libreria.BorderLabel();
            this.dataGridViewListe = new System.Windows.Forms.DataGridView();
            this.Salva = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NomeLista = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Genere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Libri = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanelAggiungiALista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelAggiungiALista
            // 
            this.bunifuGradientPanelAggiungiALista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelAggiungiALista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelAggiungiALista.BackgroundImage")));
            this.bunifuGradientPanelAggiungiALista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelAggiungiALista.Controls.Add(this.borderLabelListeUtente);
            this.bunifuGradientPanelAggiungiALista.Controls.Add(this.dataGridViewListe);
            this.bunifuGradientPanelAggiungiALista.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelAggiungiALista.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelAggiungiALista.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelAggiungiALista.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelAggiungiALista.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelAggiungiALista.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelAggiungiALista.Name = "bunifuGradientPanelAggiungiALista";
            this.bunifuGradientPanelAggiungiALista.Quality = 10;
            this.bunifuGradientPanelAggiungiALista.Size = new System.Drawing.Size(1163, 689);
            this.bunifuGradientPanelAggiungiALista.TabIndex = 13;
            // 
            // borderLabelListeUtente
            // 
            this.borderLabelListeUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelListeUtente.AutoSize = true;
            this.borderLabelListeUtente.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelListeUtente.BorderColor = System.Drawing.Color.Black;
            this.borderLabelListeUtente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderLabelListeUtente.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelListeUtente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelListeUtente.Location = new System.Drawing.Point(161, 93);
            this.borderLabelListeUtente.Name = "borderLabelListeUtente";
            this.borderLabelListeUtente.Size = new System.Drawing.Size(190, 82);
            this.borderLabelListeUtente.TabIndex = 26;
            this.borderLabelListeUtente.Text = "Liste";
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewListe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Salva,
            this.NomeLista,
            this.Genere,
            this.Libri});
            this.dataGridViewListe.GridColor = System.Drawing.Color.Black;
            this.dataGridViewListe.Location = new System.Drawing.Point(175, 270);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.ReadOnly = true;
            this.dataGridViewListe.Size = new System.Drawing.Size(840, 230);
            this.dataGridViewListe.TabIndex = 25;
            this.dataGridViewListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListe_CellContentClick);
            // 
            // Salva
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Salva.DefaultCellStyle = dataGridViewCellStyle1;
            this.Salva.HeaderText = "Aggiungi";
            this.Salva.MinimumWidth = 80;
            this.Salva.Name = "Salva";
            this.Salva.ReadOnly = true;
            this.Salva.Text = "Aggiungi";
            this.Salva.UseColumnTextForButtonValue = true;
            // 
            // NomeLista
            // 
            this.NomeLista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.NomeLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.NomeLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NomeLista.HeaderText = "Nome Lista";
            this.NomeLista.MinimumWidth = 250;
            this.NomeLista.Name = "NomeLista";
            this.NomeLista.ReadOnly = true;
            this.NomeLista.Text = "Nome Lista";
            // 
            // Genere
            // 
            this.Genere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Genere.DefaultCellStyle = dataGridViewCellStyle3;
            this.Genere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genere.HeaderText = "Genere";
            this.Genere.MinimumWidth = 100;
            this.Genere.Name = "Genere";
            this.Genere.ReadOnly = true;
            this.Genere.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Libri
            // 
            this.Libri.HeaderText = "Lista";
            this.Libri.Name = "Libri";
            this.Libri.ReadOnly = true;
            this.Libri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Libri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Libri.Visible = false;
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
            // ElencoListeUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuGradientPanelAggiungiALista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElencoListeUtente";
            this.Text = "Aggiungi Alla Lista";
            this.bunifuGradientPanelAggiungiALista.ResumeLayout(false);
            this.bunifuGradientPanelAggiungiALista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelAggiungiALista;
        private BorderLabel borderLabelListeUtente;
        private System.Windows.Forms.DataGridView dataGridViewListe;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
        private System.Windows.Forms.DataGridViewButtonColumn Salva;
        private System.Windows.Forms.DataGridViewButtonColumn NomeLista;
        private System.Windows.Forms.DataGridViewButtonColumn Genere;
        private System.Windows.Forms.DataGridViewButtonColumn Libri;
    }
}