namespace SecurityManager
{
    partial class SceltaIntervallo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceltaIntervallo));
            this.bunifuGradientPanelSceltaIntervallo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuImageButtonBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelFine = new System.Windows.Forms.Label();
            this.dateTimePickerSceltaFine = new System.Windows.Forms.DateTimePicker();
            this.labelInizio = new System.Windows.Forms.Label();
            this.buttonVisualizzaLog = new System.Windows.Forms.Button();
            this.dateTimePickerSceltaInizio = new System.Windows.Forms.DateTimePicker();
            this.borderLabelData = new SecurityManager.BorderLabel();
            this.bunifuGradientPanelSceltaIntervallo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanelSceltaIntervallo
            // 
            this.bunifuGradientPanelSceltaIntervallo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanelSceltaIntervallo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanelSceltaIntervallo.BackgroundImage")));
            this.bunifuGradientPanelSceltaIntervallo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanelSceltaIntervallo.Controls.Add(this.bunifuImageButtonBack);
            this.bunifuGradientPanelSceltaIntervallo.Controls.Add(this.labelFine);
            this.bunifuGradientPanelSceltaIntervallo.Controls.Add(this.dateTimePickerSceltaFine);
            this.bunifuGradientPanelSceltaIntervallo.Controls.Add(this.labelInizio);
            this.bunifuGradientPanelSceltaIntervallo.Controls.Add(this.buttonVisualizzaLog);
            this.bunifuGradientPanelSceltaIntervallo.Controls.Add(this.dateTimePickerSceltaInizio);
            this.bunifuGradientPanelSceltaIntervallo.Controls.Add(this.borderLabelData);
            this.bunifuGradientPanelSceltaIntervallo.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.bunifuGradientPanelSceltaIntervallo.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.bunifuGradientPanelSceltaIntervallo.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanelSceltaIntervallo.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanelSceltaIntervallo.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanelSceltaIntervallo.Name = "bunifuGradientPanelSceltaIntervallo";
            this.bunifuGradientPanelSceltaIntervallo.Quality = 10;
            this.bunifuGradientPanelSceltaIntervallo.Size = new System.Drawing.Size(880, 439);
            this.bunifuGradientPanelSceltaIntervallo.TabIndex = 11;
            // 
            // bunifuImageButtonBack
            // 
            this.bunifuImageButtonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButtonBack.Image")));
            this.bunifuImageButtonBack.ImageActive = null;
            this.bunifuImageButtonBack.Location = new System.Drawing.Point(797, 12);
            this.bunifuImageButtonBack.Name = "bunifuImageButtonBack";
            this.bunifuImageButtonBack.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButtonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButtonBack.TabIndex = 24;
            this.bunifuImageButtonBack.TabStop = false;
            this.bunifuImageButtonBack.Zoom = 10;
            this.bunifuImageButtonBack.Click += new System.EventHandler(this.bunifuImageButtonBack_Click);
            // 
            // labelFine
            // 
            this.labelFine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFine.AutoSize = true;
            this.labelFine.BackColor = System.Drawing.Color.Transparent;
            this.labelFine.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFine.Location = new System.Drawing.Point(89, 226);
            this.labelFine.Name = "labelFine";
            this.labelFine.Size = new System.Drawing.Size(175, 27);
            this.labelFine.TabIndex = 19;
            this.labelFine.Text = "Fine intervallo: ";
            // 
            // dateTimePickerSceltaFine
            // 
            this.dateTimePickerSceltaFine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerSceltaFine.CalendarFont = new System.Drawing.Font("Georgia", 28F);
            this.dateTimePickerSceltaFine.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.dateTimePickerSceltaFine.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.dateTimePickerSceltaFine.Location = new System.Drawing.Point(92, 247);
            this.dateTimePickerSceltaFine.MaxDate = new System.DateTime(4999, 6, 20, 0, 0, 0, 0);
            this.dateTimePickerSceltaFine.Name = "dateTimePickerSceltaFine";
            this.dateTimePickerSceltaFine.Size = new System.Drawing.Size(593, 26);
            this.dateTimePickerSceltaFine.TabIndex = 18;
            this.dateTimePickerSceltaFine.Value = new System.DateTime(2018, 6, 21, 0, 0, 0, 0);
            // 
            // labelInizio
            // 
            this.labelInizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInizio.AutoSize = true;
            this.labelInizio.BackColor = System.Drawing.Color.Transparent;
            this.labelInizio.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInizio.Location = new System.Drawing.Point(89, 149);
            this.labelInizio.Name = "labelInizio";
            this.labelInizio.Size = new System.Drawing.Size(182, 27);
            this.labelInizio.TabIndex = 17;
            this.labelInizio.Text = "Inizio intervallo:";
            // 
            // buttonVisualizzaLog
            // 
            this.buttonVisualizzaLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVisualizzaLog.AutoSize = true;
            this.buttonVisualizzaLog.BackColor = System.Drawing.Color.Transparent;
            this.buttonVisualizzaLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizzaLog.Location = new System.Drawing.Point(92, 313);
            this.buttonVisualizzaLog.Name = "buttonVisualizzaLog";
            this.buttonVisualizzaLog.Size = new System.Drawing.Size(593, 45);
            this.buttonVisualizzaLog.TabIndex = 16;
            this.buttonVisualizzaLog.Text = "Visualizza Log";
            this.buttonVisualizzaLog.UseVisualStyleBackColor = false;
            this.buttonVisualizzaLog.Click += new System.EventHandler(this.buttonVisualizzaLog_Click);
            // 
            // dateTimePickerSceltaInizio
            // 
            this.dateTimePickerSceltaInizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerSceltaInizio.CalendarFont = new System.Drawing.Font("Georgia", 28F);
            this.dateTimePickerSceltaInizio.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(161)))), ((int)(((byte)(172)))));
            this.dateTimePickerSceltaInizio.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.dateTimePickerSceltaInizio.Location = new System.Drawing.Point(92, 170);
            this.dateTimePickerSceltaInizio.MaxDate = new System.DateTime(4999, 6, 20, 0, 0, 0, 0);
            this.dateTimePickerSceltaInizio.Name = "dateTimePickerSceltaInizio";
            this.dateTimePickerSceltaInizio.Size = new System.Drawing.Size(593, 26);
            this.dateTimePickerSceltaInizio.TabIndex = 15;
            this.dateTimePickerSceltaInizio.Value = new System.DateTime(2018, 6, 21, 12, 7, 51, 0);
            // 
            // borderLabelData
            // 
            this.borderLabelData.AutoSize = true;
            this.borderLabelData.BackColor = System.Drawing.Color.Transparent;
            this.borderLabelData.BorderColor = System.Drawing.Color.Black;
            this.borderLabelData.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderLabelData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.borderLabelData.Location = new System.Drawing.Point(80, 45);
            this.borderLabelData.Name = "borderLabelData";
            this.borderLabelData.Size = new System.Drawing.Size(248, 109);
            this.borderLabelData.TabIndex = 4;
            this.borderLabelData.Text = "Data";
            // 
            // SceltaIntervallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 439);
            this.Controls.Add(this.bunifuGradientPanelSceltaIntervallo);
            this.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SceltaIntervallo";
            this.Text = "SceltaIntervallo";
            this.bunifuGradientPanelSceltaIntervallo.ResumeLayout(false);
            this.bunifuGradientPanelSceltaIntervallo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButtonBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanelSceltaIntervallo;
        private System.Windows.Forms.Label labelInizio;
        private System.Windows.Forms.Button buttonVisualizzaLog;
        private System.Windows.Forms.DateTimePicker dateTimePickerSceltaInizio;
        private BorderLabel borderLabelData;
        private System.Windows.Forms.Label labelFine;
        private System.Windows.Forms.DateTimePicker dateTimePickerSceltaFine;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButtonBack;
    }
}