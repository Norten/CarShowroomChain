namespace CarShowroomChain
{
    partial class FormCarSearch
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.labelCashTo = new System.Windows.Forms.Label();
            this.labelCashFrom = new System.Windows.Forms.Label();
            this.comboBoxShop = new System.Windows.Forms.ComboBox();
            this.labelShop = new System.Windows.Forms.Label();
            this.comboBoxEngine = new System.Windows.Forms.ComboBox();
            this.comboBoxSeries = new System.Windows.Forms.ComboBox();
            this.labelSeries = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gearboxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullcarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polsl_agatek_bdDataSet1 = new CarShowroomChain.polsl_agatek_bdDataSet1();
            this.labelPriceTo = new System.Windows.Forms.Label();
            this.labelPriceFrom = new System.Windows.Forms.Label();
            this.comboBoxCarBody = new System.Windows.Forms.ComboBox();
            this.comboBoxGearbox = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCarBody = new System.Windows.Forms.Label();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.labelGearbox = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelEngine = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.full_carTableAdapter = new CarShowroomChain.polsl_agatek_bdDataSet1TableAdapters.full_carTableAdapter();
            this.maskedTextBoxPriceFrom = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPriceTo = new System.Windows.Forms.MaskedTextBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullcarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polsl_agatek_bdDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.maskedTextBoxPriceTo);
            this.panelBackground.Controls.Add(this.maskedTextBoxPriceFrom);
            this.panelBackground.Controls.Add(this.labelCashTo);
            this.panelBackground.Controls.Add(this.labelCashFrom);
            this.panelBackground.Controls.Add(this.comboBoxShop);
            this.panelBackground.Controls.Add(this.labelShop);
            this.panelBackground.Controls.Add(this.comboBoxEngine);
            this.panelBackground.Controls.Add(this.comboBoxSeries);
            this.panelBackground.Controls.Add(this.labelSeries);
            this.panelBackground.Controls.Add(this.comboBoxColor);
            this.panelBackground.Controls.Add(this.comboBoxModel);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonChoose);
            this.panelBackground.Controls.Add(this.buttonFilter);
            this.panelBackground.Controls.Add(this.dataGridViewCar);
            this.panelBackground.Controls.Add(this.labelPriceTo);
            this.panelBackground.Controls.Add(this.labelPriceFrom);
            this.panelBackground.Controls.Add(this.comboBoxCarBody);
            this.panelBackground.Controls.Add(this.comboBoxGearbox);
            this.panelBackground.Controls.Add(this.labelPrice);
            this.panelBackground.Controls.Add(this.labelCarBody);
            this.panelBackground.Controls.Add(this.comboBoxFuel);
            this.panelBackground.Controls.Add(this.labelGearbox);
            this.panelBackground.Controls.Add(this.labelFuel);
            this.panelBackground.Controls.Add(this.labelEngine);
            this.panelBackground.Controls.Add(this.labelColor);
            this.panelBackground.Controls.Add(this.labelModel);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.panelBackground.Size = new System.Drawing.Size(550, 524);
            this.panelBackground.TabIndex = 0;
            // 
            // labelCashTo
            // 
            this.labelCashTo.AutoSize = true;
            this.labelCashTo.Location = new System.Drawing.Point(438, 111);
            this.labelCashTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCashTo.Name = "labelCashTo";
            this.labelCashTo.Size = new System.Drawing.Size(28, 13);
            this.labelCashTo.TabIndex = 51;
            this.labelCashTo.Text = "PLN";
            this.labelCashTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCashFrom
            // 
            this.labelCashFrom.AutoSize = true;
            this.labelCashFrom.Location = new System.Drawing.Point(438, 82);
            this.labelCashFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCashFrom.Name = "labelCashFrom";
            this.labelCashFrom.Size = new System.Drawing.Size(28, 13);
            this.labelCashFrom.TabIndex = 50;
            this.labelCashFrom.Text = "PLN";
            this.labelCashFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxShop
            // 
            this.comboBoxShop.FormattingEnabled = true;
            this.comboBoxShop.Location = new System.Drawing.Point(366, 136);
            this.comboBoxShop.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxShop.Name = "comboBoxShop";
            this.comboBoxShop.Size = new System.Drawing.Size(140, 21);
            this.comboBoxShop.TabIndex = 48;
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(272, 139);
            this.labelShop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(34, 13);
            this.labelShop.TabIndex = 47;
            this.labelShop.Text = "Sklep";
            this.labelShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxEngine
            // 
            this.comboBoxEngine.FormattingEnabled = true;
            this.comboBoxEngine.Location = new System.Drawing.Point(113, 108);
            this.comboBoxEngine.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEngine.Name = "comboBoxEngine";
            this.comboBoxEngine.Size = new System.Drawing.Size(140, 21);
            this.comboBoxEngine.TabIndex = 46;
            // 
            // comboBoxSeries
            // 
            this.comboBoxSeries.FormattingEnabled = true;
            this.comboBoxSeries.Location = new System.Drawing.Point(113, 50);
            this.comboBoxSeries.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSeries.Name = "comboBoxSeries";
            this.comboBoxSeries.Size = new System.Drawing.Size(140, 21);
            this.comboBoxSeries.TabIndex = 45;
            // 
            // labelSeries
            // 
            this.labelSeries.AutoSize = true;
            this.labelSeries.Location = new System.Drawing.Point(19, 53);
            this.labelSeries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSeries.Name = "labelSeries";
            this.labelSeries.Size = new System.Drawing.Size(31, 13);
            this.labelSeries.TabIndex = 44;
            this.labelSeries.Text = "Seria";
            this.labelSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(113, 79);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(140, 21);
            this.comboBoxColor.TabIndex = 22;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(113, 21);
            this.comboBoxModel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(140, 21);
            this.comboBoxModel.TabIndex = 21;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(477, 469);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoose.AutoSize = true;
            this.buttonChoose.Location = new System.Drawing.Point(416, 469);
            this.buttonChoose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(56, 23);
            this.buttonChoose.TabIndex = 36;
            this.buttonChoose.Text = "Wybierz";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.Location = new System.Drawing.Point(477, 167);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(56, 23);
            this.buttonFilter.TabIndex = 35;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.AllowUserToAddRows = false;
            this.dataGridViewCar.AllowUserToDeleteRows = false;
            this.dataGridViewCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCar.AutoGenerateColumns = false;
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.seriesDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.engineDataGridViewTextBoxColumn,
            this.gearboxDataGridViewTextBoxColumn,
            this.fuelDataGridViewTextBoxColumn,
            this.bodyDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridViewCar.DataSource = this.fullcarBindingSource;
            this.dataGridViewCar.Location = new System.Drawing.Point(17, 215);
            this.dataGridViewCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 61);
            this.dataGridViewCar.MultiSelect = false;
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.ReadOnly = true;
            this.dataGridViewCar.RowTemplate.Height = 24;
            this.dataGridViewCar.Size = new System.Drawing.Size(515, 231);
            this.dataGridViewCar.TabIndex = 34;
            this.dataGridViewCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCar_CellClick);
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seriesDataGridViewTextBoxColumn
            // 
            this.seriesDataGridViewTextBoxColumn.DataPropertyName = "series";
            this.seriesDataGridViewTextBoxColumn.HeaderText = "Seria";
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
            // engineDataGridViewTextBoxColumn
            // 
            this.engineDataGridViewTextBoxColumn.DataPropertyName = "engine";
            this.engineDataGridViewTextBoxColumn.HeaderText = "Silnik";
            this.engineDataGridViewTextBoxColumn.Name = "engineDataGridViewTextBoxColumn";
            this.engineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gearboxDataGridViewTextBoxColumn
            // 
            this.gearboxDataGridViewTextBoxColumn.DataPropertyName = "gearbox";
            this.gearboxDataGridViewTextBoxColumn.HeaderText = "Skrzynia biegów";
            this.gearboxDataGridViewTextBoxColumn.Name = "gearboxDataGridViewTextBoxColumn";
            this.gearboxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuelDataGridViewTextBoxColumn
            // 
            this.fuelDataGridViewTextBoxColumn.DataPropertyName = "fuel";
            this.fuelDataGridViewTextBoxColumn.HeaderText = "Paliwo";
            this.fuelDataGridViewTextBoxColumn.Name = "fuelDataGridViewTextBoxColumn";
            this.fuelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodyDataGridViewTextBoxColumn
            // 
            this.bodyDataGridViewTextBoxColumn.DataPropertyName = "body";
            this.bodyDataGridViewTextBoxColumn.HeaderText = "Nadwozie";
            this.bodyDataGridViewTextBoxColumn.Name = "bodyDataGridViewTextBoxColumn";
            this.bodyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Numer identyfikacyjny";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullcarBindingSource
            // 
            this.fullcarBindingSource.DataMember = "full_car";
            this.fullcarBindingSource.DataSource = this.polsl_agatek_bdDataSet1;
            // 
            // polsl_agatek_bdDataSet1
            // 
            this.polsl_agatek_bdDataSet1.DataSetName = "polsl_agatek_bdDataSet1";
            this.polsl_agatek_bdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelPriceTo
            // 
            this.labelPriceTo.AutoSize = true;
            this.labelPriceTo.Location = new System.Drawing.Point(343, 111);
            this.labelPriceTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceTo.Name = "labelPriceTo";
            this.labelPriceTo.Size = new System.Drawing.Size(19, 13);
            this.labelPriceTo.TabIndex = 32;
            this.labelPriceTo.Text = "do";
            this.labelPriceTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPriceFrom
            // 
            this.labelPriceFrom.AutoSize = true;
            this.labelPriceFrom.Location = new System.Drawing.Point(343, 82);
            this.labelPriceFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriceFrom.Name = "labelPriceFrom";
            this.labelPriceFrom.Size = new System.Drawing.Size(19, 13);
            this.labelPriceFrom.TabIndex = 30;
            this.labelPriceFrom.Text = "od";
            this.labelPriceFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCarBody
            // 
            this.comboBoxCarBody.FormattingEnabled = true;
            this.comboBoxCarBody.Location = new System.Drawing.Point(366, 50);
            this.comboBoxCarBody.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCarBody.Name = "comboBoxCarBody";
            this.comboBoxCarBody.Size = new System.Drawing.Size(140, 21);
            this.comboBoxCarBody.TabIndex = 29;
            // 
            // comboBoxGearbox
            // 
            this.comboBoxGearbox.FormattingEnabled = true;
            this.comboBoxGearbox.Location = new System.Drawing.Point(113, 136);
            this.comboBoxGearbox.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxGearbox.Name = "comboBoxGearbox";
            this.comboBoxGearbox.Size = new System.Drawing.Size(140, 21);
            this.comboBoxGearbox.TabIndex = 28;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(272, 82);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(32, 13);
            this.labelPrice.TabIndex = 27;
            this.labelPrice.Text = "Cena";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCarBody
            // 
            this.labelCarBody.AutoSize = true;
            this.labelCarBody.Location = new System.Drawing.Point(272, 53);
            this.labelCarBody.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarBody.Name = "labelCarBody";
            this.labelCarBody.Size = new System.Drawing.Size(54, 13);
            this.labelCarBody.TabIndex = 26;
            this.labelCarBody.Text = "Nadwozie";
            this.labelCarBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(366, 21);
            this.comboBoxFuel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(140, 21);
            this.comboBoxFuel.TabIndex = 25;
            // 
            // labelGearbox
            // 
            this.labelGearbox.AutoSize = true;
            this.labelGearbox.Location = new System.Drawing.Point(19, 138);
            this.labelGearbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGearbox.Name = "labelGearbox";
            this.labelGearbox.Size = new System.Drawing.Size(84, 13);
            this.labelGearbox.TabIndex = 20;
            this.labelGearbox.Text = "Skrzynia biegów";
            this.labelGearbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(272, 24);
            this.labelFuel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(38, 13);
            this.labelFuel.TabIndex = 19;
            this.labelFuel.Text = "Paliwo";
            this.labelFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEngine
            // 
            this.labelEngine.AutoSize = true;
            this.labelEngine.Location = new System.Drawing.Point(19, 111);
            this.labelEngine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEngine.Name = "labelEngine";
            this.labelEngine.Size = new System.Drawing.Size(32, 13);
            this.labelEngine.TabIndex = 17;
            this.labelEngine.Text = "Silnik";
            this.labelEngine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(19, 81);
            this.labelColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(31, 13);
            this.labelColor.TabIndex = 16;
            this.labelColor.Text = "Kolor";
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(19, 24);
            this.labelModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 15;
            this.labelModel.Text = "Model";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // full_carTableAdapter
            // 
            this.full_carTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBoxPriceFrom
            // 
            this.maskedTextBoxPriceFrom.AsciiOnly = true;
            this.maskedTextBoxPriceFrom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxPriceFrom.Location = new System.Drawing.Point(366, 79);
            this.maskedTextBoxPriceFrom.Mask = "999 999 999";
            this.maskedTextBoxPriceFrom.Name = "maskedTextBoxPriceFrom";
            this.maskedTextBoxPriceFrom.PromptChar = ' ';
            this.maskedTextBoxPriceFrom.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxPriceFrom.TabIndex = 52;
            this.maskedTextBoxPriceFrom.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxPriceFrom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxPriceFrom_MouseDown);
            // 
            // maskedTextBoxPriceTo
            // 
            this.maskedTextBoxPriceTo.AsciiOnly = true;
            this.maskedTextBoxPriceTo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxPriceTo.Location = new System.Drawing.Point(366, 108);
            this.maskedTextBoxPriceTo.Mask = "999 999 999";
            this.maskedTextBoxPriceTo.Name = "maskedTextBoxPriceTo";
            this.maskedTextBoxPriceTo.PromptChar = ' ';
            this.maskedTextBoxPriceTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBoxPriceTo.Size = new System.Drawing.Size(67, 20);
            this.maskedTextBoxPriceTo.TabIndex = 54;
            this.maskedTextBoxPriceTo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedTextBoxPriceTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxPriceTo_MouseDown);
            // 
            // FormCarSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 524);
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(566, 495);
            this.Name = "FormCarSearch";
            this.Text = "Wyszukiwanie samochodu";
            this.Load += new System.EventHandler(this.FormCarSearch_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullcarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polsl_agatek_bdDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelPriceFrom;
        private System.Windows.Forms.ComboBox comboBoxCarBody;
        private System.Windows.Forms.ComboBox comboBoxGearbox;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCarBody;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.Label labelGearbox;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.Label labelPriceTo;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxSeries;
        private System.Windows.Forms.Label labelSeries;
        private System.Windows.Forms.ComboBox comboBoxShop;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.ComboBox comboBoxEngine;
        private System.Windows.Forms.Label labelEngine;
        private polsl_agatek_bdDataSet1 polsl_agatek_bdDataSet1;
        private System.Windows.Forms.BindingSource fullcarBindingSource;
        private polsl_agatek_bdDataSet1TableAdapters.full_carTableAdapter full_carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gearboxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelCashTo;
        private System.Windows.Forms.Label labelCashFrom;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPriceFrom;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPriceTo;
    }
}