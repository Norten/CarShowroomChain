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
            this.panelBackground.SuspendLayout();
            this.groupBoxDataRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonGenerateReport);
            this.panelBackground.Controls.Add(this.comboBox1);
            this.panelBackground.Controls.Add(this.labelChooseReport);
            this.panelBackground.Controls.Add(this.groupBoxDataRange);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(407, 353);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(309, 287);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateReport.AutoSize = true;
            this.buttonGenerateReport.Location = new System.Drawing.Point(192, 287);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(111, 27);
            this.buttonGenerateReport.TabIndex = 3;
            this.buttonGenerateReport.Text = "Generuj raport";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // labelChooseReport
            // 
            this.labelChooseReport.AutoSize = true;
            this.labelChooseReport.Location = new System.Drawing.Point(25, 225);
            this.labelChooseReport.Margin = new System.Windows.Forms.Padding(3);
            this.labelChooseReport.Name = "labelChooseReport";
            this.labelChooseReport.Size = new System.Drawing.Size(101, 17);
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
            this.groupBoxDataRange.Location = new System.Drawing.Point(25, 30);
            this.groupBoxDataRange.Name = "groupBoxDataRange";
            this.groupBoxDataRange.Size = new System.Drawing.Size(361, 173);
            this.groupBoxDataRange.TabIndex = 0;
            this.groupBoxDataRange.TabStop = false;
            this.groupBoxDataRange.Text = "Zakres danych uwzględnionych w raporcie";
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(155, 130);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateTo.TabIndex = 5;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(125, 135);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(24, 17);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "do";
            this.labelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(155, 95);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateFrom.TabIndex = 3;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(125, 100);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(24, 17);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "od";
            this.labelFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonDataFromTo
            // 
            this.radioButtonDataFromTo.AutoSize = true;
            this.radioButtonDataFromTo.Location = new System.Drawing.Point(25, 65);
            this.radioButtonDataFromTo.Name = "radioButtonDataFromTo";
            this.radioButtonDataFromTo.Size = new System.Drawing.Size(126, 21);
            this.radioButtonDataFromTo.TabIndex = 1;
            this.radioButtonDataFromTo.TabStop = true;
            this.radioButtonDataFromTo.Text = "dane z zakresu";
            this.radioButtonDataFromTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDataFromTo.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllData
            // 
            this.radioButtonAllData.AutoSize = true;
            this.radioButtonAllData.Location = new System.Drawing.Point(25, 30);
            this.radioButtonAllData.Name = "radioButtonAllData";
            this.radioButtonAllData.Size = new System.Drawing.Size(124, 21);
            this.radioButtonAllData.TabIndex = 0;
            this.radioButtonAllData.TabStop = true;
            this.radioButtonAllData.Text = "wszystkie dane";
            this.radioButtonAllData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAllData.UseVisualStyleBackColor = true;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 353);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(425, 400);
            this.Name = "FormReports";
            this.Text = "Raporty";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.groupBoxDataRange.ResumeLayout(false);
            this.groupBoxDataRange.PerformLayout();
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
    }
}