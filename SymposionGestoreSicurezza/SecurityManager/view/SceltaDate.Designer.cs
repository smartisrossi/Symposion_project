namespace SecurityManager
{
    partial class SceltaDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceltaDate));
            this.borderLabelData = new SecurityManager.BorderLabel();
            this.dateTimePickerSceltaData = new System.Windows.Forms.DateTimePicker();
            this.buttonVisualizzaLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanelSceltaDate = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanelSceltaDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // borderLabelData
            // 
            this.borderLabelData.AutoSize = true;
            this.borderLabelData.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelData.BorderColor = System.Drawing.Color.Black;
            this.borderLabelData.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelData.Location = new System.Drawing.Point(120, 69);
            this.borderLabelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.borderLabelData.Name = "borderLabelData";
            this.borderLabelData.Size = new System.Drawing.Size(248, 109);
            this.borderLabelData.TabIndex = 4;
            this.borderLabelData.Text = "Data";
            // 
            // dateTimePickerSceltaData
            // 
            this.dateTimePickerSceltaData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerSceltaData.CalendarFont = new System.Drawing.Font("Georgia", 28F);
            this.dateTimePickerSceltaData.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.dateTimePickerSceltaData.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.dateTimePickerSceltaData.Location = new System.Drawing.Point(138, 305);
            this.dateTimePickerSceltaData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerSceltaData.MaxDate = new System.DateTime(4999, 6, 20, 0, 0, 0, 0);
            this.dateTimePickerSceltaData.Name = "dateTimePickerSceltaData";
            this.dateTimePickerSceltaData.Size = new System.Drawing.Size(888, 26);
            this.dateTimePickerSceltaData.TabIndex = 15;
            this.dateTimePickerSceltaData.Value = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            // 
            // buttonVisualizzaLog
            // 
            this.buttonVisualizzaLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVisualizzaLog.BackColor = System.Drawing.Color.Transparent;
            this.buttonVisualizzaLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizzaLog.Location = new System.Drawing.Point(138, 482);
            this.buttonVisualizzaLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVisualizzaLog.Name = "buttonVisualizzaLog";
            this.buttonVisualizzaLog.Size = new System.Drawing.Size(890, 69);
            this.buttonVisualizzaLog.TabIndex = 16;
            this.buttonVisualizzaLog.Text = "Visualizza Log";
            this.buttonVisualizzaLog.UseVisualStyleBackColor = false;
            this.buttonVisualizzaLog.Click += new System.EventHandler(this.buttonVisualizzaLog_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Scegliere una data:";
            // 
            // bunifuGradientPanelSceltaDate
            // 
            this.bunifuGradientPanelSceltaDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelSceltaDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelSceltaDate.BackgroundImage")));
            this.bunifuGradientPanelSceltaDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.label1);
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.buttonVisualizzaLog);
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.dateTimePickerSceltaData);
            this.bunifuGradientPanelSceltaDate.Controls.Add(this.borderLabelData);
            this.bunifuGradientPanelSceltaDate.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelSceltaDate.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelSceltaDate.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelSceltaDate.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelSceltaDate.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelSceltaDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuGradientPanelSceltaDate.Name = "bunifuGradientPanelSceltaDate";
            this.bunifuGradientPanelSceltaDate.Quality = 10;
            this.bunifuGradientPanelSceltaDate.Size = new System.Drawing.Size(1320, 675);
            this.bunifuGradientPanelSceltaDate.TabIndex = 10;
            // 
            // bunifuImageButtonBack
            // 
            this.bunifuImageButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonBack.Image")));
            this.bunifuImageButtonBack.ImageActive = null;
            this.bunifuImageButtonBack.Location = new System.Drawing.Point(1196, 18);
            this.bunifuImageButtonBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuImageButtonBack.Name = "bunifuImageButtonBack";
            this.bunifuImageButtonBack.Size = new System.Drawing.Size(106, 109);
            this.bunifuImageButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBack.TabIndex = 24;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // SceltaDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 675);
            this.Controls.Add(this.bunifuGradientPanelSceltaDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SceltaDate";
            this.Text = "SceltaDate";
            this.bunifuGradientPanelSceltaDate.ResumeLayout(false);
            this.bunifuGradientPanelSceltaDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BorderLabel borderLabelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerSceltaData;
        private System.Windows.Forms.Button buttonVisualizzaLog;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelSceltaDate;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
    }
}