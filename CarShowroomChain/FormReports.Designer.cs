namespace CarShowroomChain
{
    partial class FormReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelChooseReport = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.pictureBoxQuestionMark);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonGenerateReport);
            this.panelBackground.Controls.Add(this.comboBox1);
            this.panelBackground.Controls.Add(this.labelChooseReport);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.panelBackground.Size = new System.Drawing.Size(376, 293);
            this.panelBackground.TabIndex = 0;
            // 
            // pictureBoxQuestionMark
            // 
            this.pictureBoxQuestionMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuestionMark.BackgroundImage")));
            this.pictureBoxQuestionMark.Location = new System.Drawing.Point(333, 19);
            this.pictureBoxQuestionMark.Name = "pictureBoxQuestionMark";
            this.pictureBoxQuestionMark.Size = new System.Drawing.Size(25, 24);
            this.pictureBoxQuestionMark.TabIndex = 81;
            this.pictureBoxQuestionMark.TabStop = false;
            this.pictureBoxQuestionMark.Click += new System.EventHandler(this.pictureBoxQuestionMark_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(302, 162);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateReport.AutoSize = true;
            this.buttonGenerateReport.Location = new System.Drawing.Point(213, 162);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(84, 23);
            this.buttonGenerateReport.TabIndex = 3;
            this.buttonGenerateReport.Text = "Generuj raport";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ranking salonów",
            "Realizowane zamówienia",
            "Historia zamówień klienta",
            "Historia zamówień klienta - samochody kupione",
            "Historia zamówień klienta - samochody zarejestrowane",
            "Historia zamówień klienta - usługi wykupione"});
            this.comboBox1.Location = new System.Drawing.Point(17, 94);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(341, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelChooseReport
            // 
            this.labelChooseReport.AutoSize = true;
            this.labelChooseReport.Location = new System.Drawing.Point(17, 77);
            this.labelChooseReport.Margin = new System.Windows.Forms.Padding(2);
            this.labelChooseReport.Name = "labelChooseReport";
            this.labelChooseReport.Size = new System.Drawing.Size(75, 13);
            this.labelChooseReport.TabIndex = 1;
            this.labelChooseReport.Text = "Wybierz raport";
            this.labelChooseReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 293);
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(323, 332);
            this.Name = "FormReports";
            this.Text = "Raporty";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelChooseReport;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
    }
}