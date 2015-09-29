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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelChooseReport = new System.Windows.Forms.Label();
            this.groupBoxDataRange = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.radioButtonDataFromTo = new System.Windows.Forms.RadioButton();
            this.radioButtonAllData = new System.Windows.Forms.RadioButton();
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            this.groupBoxDataRange.SuspendLayout();
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
            this.panelBackground.Controls.Add(this.groupBoxDataRange);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.panelBackground.Size = new System.Drawing.Size(307, 293);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(234, 238);
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
            this.buttonGenerateReport.Location = new System.Drawing.Point(145, 238);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(84, 23);
            this.buttonGenerateReport.TabIndex = 3;
            this.buttonGenerateReport.Text = "Generuj raport";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 180);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // labelChooseReport
            // 
            this.labelChooseReport.AutoSize = true;
            this.labelChooseReport.Location = new System.Drawing.Point(19, 183);
            this.labelChooseReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelChooseReport.Name = "labelChooseReport";
            this.labelChooseReport.Size = new System.Drawing.Size(75, 13);
            this.labelChooseReport.TabIndex = 1;
            this.labelChooseReport.Text = "Wybierz raport";
            this.labelChooseReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDataRange
            // 
            this.groupBoxDataRange.AutoSize = true;
            this.groupBoxDataRange.Controls.Add(this.dateTimePickerDateTo);
            this.groupBoxDataRange.Controls.Add(this.labelTo);
            this.groupBoxDataRange.Controls.Add(this.dateTimePickerDateFrom);
            this.groupBoxDataRange.Controls.Add(this.labelFrom);
            this.groupBoxDataRange.Controls.Add(this.radioButtonDataFromTo);
            this.groupBoxDataRange.Controls.Add(this.radioButtonAllData);
            this.groupBoxDataRange.Location = new System.Drawing.Point(19, 24);
            this.groupBoxDataRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDataRange.Name = "groupBoxDataRange";
            this.groupBoxDataRange.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDataRange.Size = new System.Drawing.Size(271, 143);
            this.groupBoxDataRange.TabIndex = 0;
            this.groupBoxDataRange.TabStop = false;
            this.groupBoxDataRange.Text = "Zakres danych uwzględnionych w raporcie";
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(116, 106);
            this.dateTimePickerDateTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerDateTo.TabIndex = 5;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(94, 110);
            this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(19, 13);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "do";
            this.labelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(116, 77);
            this.dateTimePickerDateFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerDateFrom.TabIndex = 3;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(94, 81);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(19, 13);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "od";
            this.labelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonDataFromTo
            // 
            this.radioButtonDataFromTo.AutoSize = true;
            this.radioButtonDataFromTo.Location = new System.Drawing.Point(19, 53);
            this.radioButtonDataFromTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDataFromTo.Name = "radioButtonDataFromTo";
            this.radioButtonDataFromTo.Size = new System.Drawing.Size(97, 17);
            this.radioButtonDataFromTo.TabIndex = 1;
            this.radioButtonDataFromTo.TabStop = true;
            this.radioButtonDataFromTo.Text = "dane z zakresu";
            this.radioButtonDataFromTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDataFromTo.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllData
            // 
            this.radioButtonAllData.AutoSize = true;
            this.radioButtonAllData.Location = new System.Drawing.Point(19, 24);
            this.radioButtonAllData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonAllData.Name = "radioButtonAllData";
            this.radioButtonAllData.Size = new System.Drawing.Size(97, 17);
            this.radioButtonAllData.TabIndex = 0;
            this.radioButtonAllData.TabStop = true;
            this.radioButtonAllData.Text = "wszystkie dane";
            this.radioButtonAllData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAllData.UseVisualStyleBackColor = true;
            // 
            // pictureBoxQuestionMark
            // 
            this.pictureBoxQuestionMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuestionMark.BackgroundImage")));
            this.pictureBoxQuestionMark.Location = new System.Drawing.Point(270, 12);
            this.pictureBoxQuestionMark.Name = "pictureBoxQuestionMark";
            this.pictureBoxQuestionMark.Size = new System.Drawing.Size(25, 24);
            this.pictureBoxQuestionMark.TabIndex = 81;
            this.pictureBoxQuestionMark.TabStop = false;
            this.pictureBoxQuestionMark.Click += new System.EventHandler(this.pictureBoxQuestionMark_Click);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 293);
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(323, 332);
            this.Name = "FormReports";
            this.Text = "Raporty";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.groupBoxDataRange.ResumeLayout(false);
            this.groupBoxDataRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelChooseReport;
        private System.Windows.Forms.GroupBox groupBoxDataRange;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.RadioButton radioButtonDataFromTo;
        private System.Windows.Forms.RadioButton radioButtonAllData;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
    }
}