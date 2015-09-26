namespace CarShowroomChain
{
    partial class FormOrders
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
            this.buttonNewServiceOrder = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonRealize = new System.Windows.Forms.Button();
            this.buttonNewCarOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIDNumber = new System.Windows.Forms.TextBox();
            this.labelIDNumber = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelHistory = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.buttonNewServiceOrder);
            this.panelBackground.Controls.Add(this.buttonFilter);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonModify);
            this.panelBackground.Controls.Add(this.buttonRealize);
            this.panelBackground.Controls.Add(this.buttonNewCarOrder);
            this.panelBackground.Controls.Add(this.dataGridView1);
            this.panelBackground.Controls.Add(this.textBoxIDNumber);
            this.panelBackground.Controls.Add(this.labelIDNumber);
            this.panelBackground.Controls.Add(this.textBoxSurname);
            this.panelBackground.Controls.Add(this.labelSurname);
            this.panelBackground.Controls.Add(this.textBoxName);
            this.panelBackground.Controls.Add(this.labelName);
            this.panelBackground.Controls.Add(this.labelClient);
            this.panelBackground.Controls.Add(this.dateTimePicker1);
            this.panelBackground.Controls.Add(this.labelDateTo);
            this.panelBackground.Controls.Add(this.dateTimePickerFrom);
            this.panelBackground.Controls.Add(this.labelDateFrom);
            this.panelBackground.Controls.Add(this.labelHistory);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(688, 603);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonNewServiceOrder
            // 
            this.buttonNewServiceOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewServiceOrder.AutoSize = true;
            this.buttonNewServiceOrder.Location = new System.Drawing.Point(36, 537);
            this.buttonNewServiceOrder.Name = "buttonNewServiceOrder";
            this.buttonNewServiceOrder.Size = new System.Drawing.Size(171, 27);
            this.buttonNewServiceOrder.TabIndex = 37;
            this.buttonNewServiceOrder.Text = "Nowe zamówienie usługi";
            this.buttonNewServiceOrder.UseVisualStyleBackColor = true;
            this.buttonNewServiceOrder.Click += new System.EventHandler(this.buttonNewServiceOrder_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.Location = new System.Drawing.Point(590, 205);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 27);
            this.buttonFilter.TabIndex = 36;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(590, 537);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Wycofaj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModify.AutoSize = true;
            this.buttonModify.Location = new System.Drawing.Point(507, 537);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(77, 27);
            this.buttonModify.TabIndex = 16;
            this.buttonModify.Text = "Modyfikuj";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonRealize
            // 
            this.buttonRealize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRealize.AutoSize = true;
            this.buttonRealize.Location = new System.Drawing.Point(426, 537);
            this.buttonRealize.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonRealize.Name = "buttonRealize";
            this.buttonRealize.Size = new System.Drawing.Size(75, 27);
            this.buttonRealize.TabIndex = 15;
            this.buttonRealize.Text = "Realizuj";
            this.buttonRealize.UseVisualStyleBackColor = true;
            // 
            // buttonNewCarOrder
            // 
            this.buttonNewCarOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewCarOrder.AutoSize = true;
            this.buttonNewCarOrder.Location = new System.Drawing.Point(213, 537);
            this.buttonNewCarOrder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonNewCarOrder.Name = "buttonNewCarOrder";
            this.buttonNewCarOrder.Size = new System.Drawing.Size(207, 27);
            this.buttonNewCarOrder.TabIndex = 14;
            this.buttonNewCarOrder.Text = "Nowe zamówienie samochodu";
            this.buttonNewCarOrder.UseVisualStyleBackColor = true;
            this.buttonNewCarOrder.Click += new System.EventHandler(this.buttonNewCarOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClientName,
            this.ColumnClientSurname,
            this.ColumnIDNum,
            this.ColumnDate,
            this.ColumnPrice,
            this.ColumnCar});
            this.dataGridView1.Location = new System.Drawing.Point(23, 265);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 254);
            this.dataGridView1.TabIndex = 13;
            // 
            // ColumnClientName
            // 
            this.ColumnClientName.HeaderText = "Imie";
            this.ColumnClientName.Name = "ColumnClientName";
            this.ColumnClientName.ReadOnly = true;
            // 
            // ColumnClientSurname
            // 
            this.ColumnClientSurname.HeaderText = "Nazwisko";
            this.ColumnClientSurname.Name = "ColumnClientSurname";
            this.ColumnClientSurname.ReadOnly = true;
            // 
            // ColumnIDNum
            // 
            this.ColumnIDNum.HeaderText = "Nr dowodu osobistego";
            this.ColumnIDNum.Name = "ColumnIDNum";
            this.ColumnIDNum.ReadOnly = true;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Data zakupu";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Cena";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnCar
            // 
            this.ColumnCar.HeaderText = "Zakupiony samochód";
            this.ColumnCar.Name = "ColumnCar";
            this.ColumnCar.ReadOnly = true;
            // 
            // textBoxIDNumber
            // 
            this.textBoxIDNumber.Location = new System.Drawing.Point(212, 202);
            this.textBoxIDNumber.MaxLength = 9;
            this.textBoxIDNumber.Name = "textBoxIDNumber";
            this.textBoxIDNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDNumber.TabIndex = 12;
            // 
            // labelIDNumber
            // 
            this.labelIDNumber.AutoSize = true;
            this.labelIDNumber.Location = new System.Drawing.Point(57, 205);
            this.labelIDNumber.Name = "labelIDNumber";
            this.labelIDNumber.Size = new System.Drawing.Size(149, 17);
            this.labelIDNumber.TabIndex = 11;
            this.labelIDNumber.Text = "Nr dowodu osobistego";
            this.labelIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(212, 167);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 10;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(57, 170);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(212, 132);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(57, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Imię";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(25, 100);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 17);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Klient";
            this.labelClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(293, 65);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(24, 17);
            this.labelDateTo.TabIndex = 4;
            this.labelDateTo.Text = "do";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(87, 60);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(57, 65);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(24, 17);
            this.labelDateFrom.TabIndex = 1;
            this.labelDateFrom.Text = "od";
            this.labelDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(25, 30);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(56, 17);
            this.labelHistory.TabIndex = 0;
            this.labelHistory.Text = "Historia";
            this.labelHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 603);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "FormOrders";
            this.Text = "Zamówienia";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCar;
        private System.Windows.Forms.TextBox textBoxIDNumber;
        private System.Windows.Forms.Label labelIDNumber;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonRealize;
        private System.Windows.Forms.Button buttonNewCarOrder;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonNewServiceOrder;
    }
}