namespace SecurityManager
{
    partial class LogAccessiView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogAccessiView));
            this.buttonScegliData = new System.Windows.Forms.Button();
            this.buttonScegliIntervallo = new System.Windows.Forms.Button();
            this.bunifuGradientPanelSO = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.buttonChiudi = new System.Windows.Forms.Button();
            this.borderLabelLogAccessi = new SecurityManager.BorderLabel();
            this.listViewLogAccessi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bunifuGradientPanelSO.SuspendLayout();
            this.SuspendLayout();
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
            this.bunifuGradientPanelSO.Controls.Add(this.borderLabelLogAccessi);
            this.bunifuGradientPanelSO.Controls.Add(this.listViewLogAccessi);
            this.bunifuGradientPanelSO.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelSO.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelSO.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelSO.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelSO.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelSO.Name = "bunifuGradientPanelSO";
            this.bunifuGradientPanelSO.Quality = 10;
            this.bunifuGradientPanelSO.Size = new System.Drawing.Size(880, 439);
            this.bunifuGradientPanelSO.TabIndex = 9;
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
            // borderLabelLogAccessi
            // 
            this.borderLabelLogAccessi.AutoSize = true;
            this.borderLabelLogAccessi.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelLogAccessi.BorderColor = System.Drawing.Color.Black;
            this.borderLabelLogAccessi.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelLogAccessi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelLogAccessi.Location = new System.Drawing.Point(89, 45);
            this.borderLabelLogAccessi.Name = "borderLabelLogAccessi";
            this.borderLabelLogAccessi.Size = new System.Drawing.Size(359, 72);
            this.borderLabelLogAccessi.TabIndex = 4;
            this.borderLabelLogAccessi.Text = "Log Accessi";
            // 
            // listViewLogAccessi
            // 
            this.listViewLogAccessi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewLogAccessi.BackColor = System.Drawing.Color.White;
            this.listViewLogAccessi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewLogAccessi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewLogAccessi.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.listViewLogAccessi.Location = new System.Drawing.Point(89, 145);
            this.listViewLogAccessi.Name = "listViewLogAccessi";
            this.listViewLogAccessi.Size = new System.Drawing.Size(683, 203);
            this.listViewLogAccessi.TabIndex = 3;
            this.listViewLogAccessi.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Log Accessi";
            this.columnHeader1.Width = 600;
            // 
            // LogAccessiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.bunifuGradientPanelSO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogAccessiView";
            this.Text = "LogAccessi";
            this.bunifuGradientPanelSO.ResumeLayout(false);
            this.bunifuGradientPanelSO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonScegliData;
        private System.Windows.Forms.Button buttonScegliIntervallo;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelSO;
        private System.Windows.Forms.Button buttonChiudi;
        private BorderLabel borderLabelLogAccessi;
        private System.Windows.Forms.ListView listViewLogAccessi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}