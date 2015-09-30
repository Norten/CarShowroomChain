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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.buttonNewServiceOrder = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRealize = new System.Windows.Forms.Button();
            this.buttonNewCarOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.datereservationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datereservationexpiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullreservationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.polsl_agatek_bdDataSet2 = new CarShowroomChain.polsl_agatek_bdDataSet2();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.fullreservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.full_reservationTableAdapter = new CarShowroomChain.polsl_agatek_bdDataSet2TableAdapters.full_reservationTableAdapter();
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullreservationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polsl_agatek_bdDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullreservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.pictureBoxQuestionMark);
            this.panelBackground.Controls.Add(this.buttonNewServiceOrder);
            this.panelBackground.Controls.Add(this.buttonFilter);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonRealize);
            this.panelBackground.Controls.Add(this.buttonNewCarOrder);
            this.panelBackground.Controls.Add(this.dataGridViewOrders);
            this.panelBackground.Controls.Add(this.textBoxSurname);
            this.panelBackground.Controls.Add(this.labelSurname);
            this.panelBackground.Controls.Add(this.textBoxName);
            this.panelBackground.Controls.Add(this.labelName);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(753, 610);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonNewServiceOrder
            // 
            this.buttonNewServiceOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewServiceOrder.AutoSize = true;
            this.buttonNewServiceOrder.Location = new System.Drawing.Point(25, 538);
            this.buttonNewServiceOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNewServiceOrder.Name = "buttonNewServiceOrder";
            this.buttonNewServiceOrder.Size = new System.Drawing.Size(228, 33);
            this.buttonNewServiceOrder.TabIndex = 37;
            this.buttonNewServiceOrder.Text = "Nowe zamówienie usługi";
            this.buttonNewServiceOrder.UseVisualStyleBackColor = true;
            this.buttonNewServiceOrder.Click += new System.EventHandler(this.buttonNewServiceOrder_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.Location = new System.Drawing.Point(654, 94);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 33);
            this.buttonFilter.TabIndex = 36;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(638, 538);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 33);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Wycofaj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRealize
            // 
            this.buttonRealize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRealize.AutoSize = true;
            this.buttonRealize.Location = new System.Drawing.Point(541, 538);
            this.buttonRealize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.buttonRealize.Name = "buttonRealize";
            this.buttonRealize.Size = new System.Drawing.Size(91, 33);
            this.buttonRealize.TabIndex = 15;
            this.buttonRealize.Text = "Realizuj";
            this.buttonRealize.UseVisualStyleBackColor = true;
            this.buttonRealize.Click += new System.EventHandler(this.buttonRealize_Click);
            // 
            // buttonNewCarOrder
            // 
            this.buttonNewCarOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewCarOrder.AutoSize = true;
            this.buttonNewCarOrder.Location = new System.Drawing.Point(259, 538);
            this.buttonNewCarOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 30);
            this.buttonNewCarOrder.Name = "buttonNewCarOrder";
            this.buttonNewCarOrder.Size = new System.Drawing.Size(276, 33);
            this.buttonNewCarOrder.TabIndex = 14;
            this.buttonNewCarOrder.Text = "Nowe zamówienie samochodu";
            this.buttonNewCarOrder.UseVisualStyleBackColor = true;
            this.buttonNewCarOrder.Click += new System.EventHandler(this.buttonNewCarOrder_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datereservationDataGridViewTextBoxColumn,
            this.datereservationexpiredDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridViewOrders.DataSource = this.fullreservationBindingSource1;
            this.dataGridViewOrders.Location = new System.Drawing.Point(23, 148);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 75);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(708, 378);
            this.dataGridViewOrders.TabIndex = 13;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            // 
            // datereservationDataGridViewTextBoxColumn
            // 
            this.datereservationDataGridViewTextBoxColumn.DataPropertyName = "date_reservation";
            this.datereservationDataGridViewTextBoxColumn.HeaderText = "Data rezerwacji";
            this.datereservationDataGridViewTextBoxColumn.Name = "datereservationDataGridViewTextBoxColumn";
            this.datereservationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datereservationexpiredDataGridViewTextBoxColumn
            // 
            this.datereservationexpiredDataGridViewTextBoxColumn.DataPropertyName = "date_reservation_expired";
            this.datereservationexpiredDataGridViewTextBoxColumn.HeaderText = "Data wygaśnięcia rezerwacji";
            this.datereservationexpiredDataGridViewTextBoxColumn.Name = "datereservationexpiredDataGridViewTextBoxColumn";
            this.datereservationexpiredDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Imię";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model samochodu";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "Seria samochodu";
            this.seriesDataGridViewTextBoxColumn.Name = "seriesDataGridViewTextBoxColumn";
            this.seriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Kolor";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Numer identyfikacyjny";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullreservationBindingSource1
            // 
            this.fullreservationBindingSource1.DataMember = "full_reservation";
            this.fullreservationBindingSource1.DataSource = this.polsl_agatek_bdDataSet2;
            // 
            // polsl_agatek_bdDataSet2
            // 
            this.polsl_agatek_bdDataSet2.DataSetName = "polsl_agatek_bdDataSet2";
            this.polsl_agatek_bdDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(178, 67);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 10;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(23, 70);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(178, 32);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Imię";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullreservationBindingSource
            // 
            this.fullreservationBindingSource.DataMember = "full_reservation";
            this.fullreservationBindingSource.DataSource = this.polsl_agatek_bdDataSet2;
            // 
            // full_reservationTableAdapter
            // 
            this.full_reservationTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBoxQuestionMark
            // 
            this.pictureBoxQuestionMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuestionMark.BackgroundImage")));
            this.pictureBoxQuestionMark.Location = new System.Drawing.Point(707, 13);
            this.pictureBoxQuestionMark.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxQuestionMark.Name = "pictureBoxQuestionMark";
            this.pictureBoxQuestionMark.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxQuestionMark.TabIndex = 77;
            this.pictureBoxQuestionMark.TabStop = false;
            this.pictureBoxQuestionMark.Click += new System.EventHandler(this.pictureBoxQuestionMark_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 610);
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(699, 648);
            this.Name = "FormOrders";
            this.Text = "Zamówienia";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullreservationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polsl_agatek_bdDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullreservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRealize;
        private System.Windows.Forms.Button buttonNewCarOrder;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonNewServiceOrder;
        private polsl_agatek_bdDataSet2 polsl_agatek_bdDataSet2;
        private System.Windows.Forms.BindingSource fullreservationBindingSource;
        private polsl_agatek_bdDataSet2TableAdapters.full_reservationTableAdapter full_reservationTableAdapter;
        private System.Windows.Forms.BindingSource fullreservationBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereservationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datereservationexpiredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
    }
}