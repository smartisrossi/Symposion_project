namespace Amministratore
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
            this.listViewSO = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuGradientPanelSO = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.borderLabelSO = new Amministratore.BorderLabel();
            this.bunifuGradientPanelSO.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewSO
            // 
            this.listViewSO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewSO.BackColor = System.Drawing.Color.White;
            this.listViewSO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewSO.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.listViewSO.Location = new System.Drawing.Point(89, 145);
            this.listViewSO.Name = "listViewSO";
            this.listViewSO.Size = new System.Drawing.Size(683, 203);
            this.listViewSO.TabIndex = 3;
            this.listViewSO.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sistema Operativo";
            this.columnHeader1.Width = 250;
            // 
            // bunifuGradientPanelSO
            // 
            this.bunifuGradientPanelSO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelSO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelSO.BackgroundImage")));
            this.bunifuGradientPanelSO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelSO.Controls.Add(this.buttonChiudi);
            this.bunifuGradientPanelSO.Controls.Add(this.borderLabelSO);
            this.bunifuGradientPanelSO.Controls.Add(this.listViewSO);
            this.bunifuGradientPanelSO.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelSO.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelSO.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelSO.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelSO.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelSO.Name = "bunifuGradientPanelSO";
            this.bunifuGradientPanelSO.Quality = 10;
            this.bunifuGradientPanelSO.Size = new System.Drawing.Size(880, 439);
            this.bunifuGradientPanelSO.TabIndex = 4;
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
            this.buttonChiudi.Location = new System.Drawing.Point(664, 372);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(108, 31);
            this.buttonChiudi.TabIndex = 13;
            this.buttonChiudi.Text = "Chiudi";
            this.buttonChiudi.UseVisualStyleBackColor = false;
            this.buttonChiudi.Click += new System.EventHandler(this.buttonChiudi_Click);
            // 
            // borderLabelSO
            // 
            this.borderLabelSO.AutoSize = true;
            this.borderLabelSO.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelSO.BorderColor = System.Drawing.Color.Black;
            this.borderLabelSO.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelSO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelSO.Location = new System.Drawing.Point(89, 45);
            this.borderLabelSO.Name = "borderLabelSO";
            this.borderLabelSO.Size = new System.Drawing.Size(551, 72);
            this.borderLabelSO.TabIndex = 4;
            this.borderLabelSO.Text = "Sistema Operativo";
            // 
            // SistemaOperativoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.bunifuGradientPanelSO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SistemaOperativoView";
            this.Text = "SistemaOperativo";
            this.bunifuGradientPanelSO.ResumeLayout(false);
            this.bunifuGradientPanelSO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewSO;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelSO;
        private BorderLabel borderLabelSO;
        private System.Windows.Forms.Button buttonChiudi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}