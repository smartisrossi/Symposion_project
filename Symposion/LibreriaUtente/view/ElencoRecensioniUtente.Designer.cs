namespace Libreria
{
    partial class ElencoRecensioniUtente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElencoRecensioniUtente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanelListaLibri = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dataGridViewRecensioniUtente = new System.Windows.Forms.DataGridView();
            this.Punteggio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Genere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Libro = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RecensioneTot = new System.Windows.Forms.DataGridViewButtonColumn();
            this.borderLabelRecensioni = new Libreria.BorderLabel();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanelListaLibri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecensioniUtente)).BeginInit();
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
            this.bunifuGradientPanelListaLibri.Controls.Add(this.dataGridViewRecensioniUtente);
            this.bunifuGradientPanelListaLibri.Controls.Add(this.borderLabelRecensioni);
            this.bunifuGradientPanelListaLibri.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelListaLibri.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelListaLibri.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelListaLibri.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelListaLibri.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelListaLibri.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelListaLibri.Name = "bunifuGradientPanelListaLibri";
            this.bunifuGradientPanelListaLibri.Quality = 10;
            this.bunifuGradientPanelListaLibri.Size = new System.Drawing.Size(1163, 689);
            this.bunifuGradientPanelListaLibri.TabIndex = 13;
            // 
            // dataGridViewRecensioniUtente
            // 
            this.dataGridViewRecensioniUtente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRecensioniUtente.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecensioniUtente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecensioniUtente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecensioniUtente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Punteggio,
            this.Genere,
            this.Libro,
            this.RecensioneTot});
            this.dataGridViewRecensioniUtente.GridColor = System.Drawing.Color.Black;
            this.dataGridViewRecensioniUtente.Location = new System.Drawing.Point(175, 270);
            this.dataGridViewRecensioniUtente.Name = "dataGridViewRecensioniUtente";
            this.dataGridViewRecensioniUtente.ReadOnly = true;
            this.dataGridViewRecensioniUtente.Size = new System.Drawing.Size(840, 230);
            this.dataGridViewRecensioniUtente.TabIndex = 27;
            this.dataGridViewRecensioniUtente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecensioni_CellContentClick);
            // 
            // Punteggio
            // 
            this.Punteggio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Punteggio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Punteggio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Punteggio.HeaderText = "Punteggio";
            this.Punteggio.MinimumWidth = 250;
            this.Punteggio.Name = "Punteggio";
            this.Punteggio.ReadOnly = true;
            this.Punteggio.Text = "Punteggio";
            this.Punteggio.Width = 250;
            // 
            // Genere
            // 
            this.Genere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Genere.DefaultCellStyle = dataGridViewCellStyle2;
            this.Genere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Genere.HeaderText = "Commento";
            this.Genere.MinimumWidth = 600;
            this.Genere.Name = "Genere";
            this.Genere.ReadOnly = true;
            this.Genere.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genere.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Genere.Width = 600;
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            this.Libro.ReadOnly = true;
            this.Libro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Libro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Libro.Visible = false;
            // 
            // RecensioneTot
            // 
            this.RecensioneTot.HeaderText = "RecensioneTot";
            this.RecensioneTot.Name = "RecensioneTot";
            this.RecensioneTot.ReadOnly = true;
            this.RecensioneTot.Visible = false;
            // 
            // borderLabelRecensioni
            // 
            this.borderLabelRecensioni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borderLabelRecensioni.AutoSize = true;
            this.borderLabelRecensioni.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelRecensioni.BorderColor = System.Drawing.Color.Black;
            this.borderLabelRecensioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderLabelRecensioni.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelRecensioni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelRecensioni.Location = new System.Drawing.Point(161, 93);
            this.borderLabelRecensioni.Name = "borderLabelRecensioni";
            this.borderLabelRecensioni.Size = new System.Drawing.Size(387, 82);
            this.borderLabelRecensioni.TabIndex = 26;
            this.borderLabelRecensioni.Text = "Recensioni";
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
            // 
            // ElencoRecensioniUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 684);
            this.Controls.Add(this.bunifuGradientPanelListaLibri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElencoRecensioniUtente";
            this.Text = "Recensioni";
            this.bunifuGradientPanelListaLibri.ResumeLayout(false);
            this.bunifuGradientPanelListaLibri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecensioniUtente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelListaLibri;
        private System.Windows.Forms.DataGridView dataGridViewRecensioniUtente;
        private System.Windows.Forms.DataGridViewButtonColumn Punteggio;
        private System.Windows.Forms.DataGridViewButtonColumn Genere;
        private System.Windows.Forms.DataGridViewButtonColumn Libro;
        private System.Windows.Forms.DataGridViewButtonColumn RecensioneTot;
        private BorderLabel borderLabelRecensioni;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
    }
}