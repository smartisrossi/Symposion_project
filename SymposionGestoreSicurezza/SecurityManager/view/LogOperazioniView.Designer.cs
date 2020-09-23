namespace SecurityManager
{
    partial class LogOperazioniView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogOperazioniView));
            this.bunifuGradientPanelSO = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.buttonScegliIntervallo = new System.Windows.Forms.Button();
            this.buttonScegliData = new System.Windows.Forms.Button();
            this.borderLabelLogOperazioni = new SecurityManager.BorderLabel();
            this.listViewLogOperazioni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuGradientPanelSO.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelSO
            // 
            this.bunifuGradientPanelSO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelSO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelSO.BackgroundImage")));
            this.bunifuGradientPanelSO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelSO.Controls.Add(this.buttonChiudi);
            this.bunifuGradientPanelSO.Controls.Add(this.buttonScegliIntervallo);
            this.bunifuGradientPanelSO.Controls.Add(this.buttonScegliData);
            this.bunifuGradientPanelSO.Controls.Add(this.borderLabelLogOperazioni);
            this.bunifuGradientPanelSO.Controls.Add(this.listViewLogOperazioni);
            this.bunifuGradientPanelSO.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelSO.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelSO.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelSO.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelSO.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelSO.Name = "bunifuGradientPanelSO";
            this.bunifuGradientPanelSO.Quality = 10;
            this.bunifuGradientPanelSO.Size = new System.Drawing.Size(880, 439);
            this.bunifuGradientPanelSO.TabIndex = 10;
            // 
            // buttonChiudi
            // 
            this.buttonChiudi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChiudi.AutoSize = true;
            this.buttonChiudi.BackColor = System.Drawing.Color.Transparent;
            this.buttonChiudi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChiudi.Font = new System.Drawing.Font("Georgia", 12F);
            this.buttonChiudi.ForeColor = System.Drawing.Color.Black;
            this.buttonChiudi.Location = new System.Drawing.Point(664, 372);
            this.buttonChiudi.Name = "buttonChiudi";
            this.buttonChiudi.Size = new System.Drawing.Size(108, 31);
            this.buttonChiudi.TabIndex = 13;
            this.buttonChiudi.Text = "Chiudi";
            this.buttonChiudi.UseVisualStyleBackColor = false;
            this.buttonChiudi.Click += new System.EventHandler(this.buttonChiudi_Click);
            // 
            // buttonScegliIntervallo
            // 
            this.buttonScegliIntervallo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScegliIntervallo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.buttonScegliIntervallo.FlatAppearance.BorderSize = 0;
            this.buttonScegliIntervallo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScegliIntervallo.Font = new System.Drawing.Font("Georgia", 11F);
            this.buttonScegliIntervallo.Location = new System.Drawing.Point(229, 373);
            this.buttonScegliIntervallo.Name = "buttonScegliIntervallo";
            this.buttonScegliIntervallo.Size = new System.Drawing.Size(133, 30);
            this.buttonScegliIntervallo.TabIndex = 7;
            this.buttonScegliIntervallo.Text = "Scegli intervallo";
            this.buttonScegliIntervallo.UseVisualStyleBackColor = false;
            this.buttonScegliIntervallo.Click += new System.EventHandler(this.buttonScegliIntervallo_Click);
            // 
            // buttonScegliData
            // 
            this.buttonScegliData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonScegliData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.buttonScegliData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScegliData.Font = new System.Drawing.Font("Georgia", 11F);
            this.buttonScegliData.ForeColor = System.Drawing.Color.White;
            this.buttonScegliData.Location = new System.Drawing.Point(89, 372);
            this.buttonScegliData.Name = "buttonScegliData";
            this.buttonScegliData.Size = new System.Drawing.Size(134, 31);
            this.buttonScegliData.TabIndex = 8;
            this.buttonScegliData.Text = "Scegli data";
            this.buttonScegliData.UseVisualStyleBackColor = false;
            this.buttonScegliData.Click += new System.EventHandler(this.buttonScegliData_Click);
            // 
            // borderLabelLogOperazioni
            // 
            this.borderLabelLogOperazioni.AutoSize = true;
            this.borderLabelLogOperazioni.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelLogOperazioni.BorderColor = System.Drawing.Color.Black;
            this.borderLabelLogOperazioni.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelLogOperazioni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelLogOperazioni.Location = new System.Drawing.Point(89, 45);
            this.borderLabelLogOperazioni.Name = "borderLabelLogOperazioni";
            this.borderLabelLogOperazioni.Size = new System.Drawing.Size(465, 72);
            this.borderLabelLogOperazioni.TabIndex = 4;
            this.borderLabelLogOperazioni.Text = "Log Operazioni";
            // 
            // listViewLogOperazioni
            // 
            this.listViewLogOperazioni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewLogOperazioni.BackColor = System.Drawing.Color.White;
            this.listViewLogOperazioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewLogOperazioni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewLogOperazioni.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.listViewLogOperazioni.Location = new System.Drawing.Point(89, 145);
            this.listViewLogOperazioni.Name = "listViewLogOperazioni";
            this.listViewLogOperazioni.Size = new System.Drawing.Size(683, 203);
            this.listViewLogOperazioni.TabIndex = 3;
            this.listViewLogOperazioni.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Log Operazioni";
            this.columnHeader1.Width = 600;
            // 
            // LogOperazioniView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.bunifuGradientPanelSO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogOperazioniView";
            this.Text = "LogOperazioni";
            this.bunifuGradientPanelSO.ResumeLayout(false);
            this.bunifuGradientPanelSO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelSO;
        private System.Windows.Forms.Button buttonChiudi;
        private System.Windows.Forms.Button buttonScegliIntervallo;
        private System.Windows.Forms.Button buttonScegliData;
        private BorderLabel borderLabelLogOperazioni;
        private System.Windows.Forms.ListView listViewLogOperazioni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}