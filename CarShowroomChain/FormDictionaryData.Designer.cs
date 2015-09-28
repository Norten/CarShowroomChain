namespace CarShowroomChain
{
    partial class FormDictionaryData
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
            this.labelNewValue = new System.Windows.Forms.Label();
            this.labelDictionaryNewWord = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSaveAndQuit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNewDictionaryData = new System.Windows.Forms.TextBox();
            this.labelDictionaryData = new System.Windows.Forms.Label();
            this.listBoxDictionaryData = new System.Windows.Forms.ListBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.polsl_agatek_bdDataSet = new CarShowroomChain.polsl_agatek_bdDataSet();
            this.polslagatekbdDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictbodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dict_bodyTableAdapter = new CarShowroomChain.polsl_agatek_bdDataSetTableAdapters.dict_bodyTableAdapter();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polsl_agatek_bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polslagatekbdDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictbodyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.labelNewValue);
            this.panelBackground.Controls.Add(this.labelDictionaryNewWord);
            this.panelBackground.Controls.Add(this.textBox1);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonSaveAndQuit);
            this.panelBackground.Controls.Add(this.buttonAdd);
            this.panelBackground.Controls.Add(this.textBoxNewDictionaryData);
            this.panelBackground.Controls.Add(this.labelDictionaryData);
            this.panelBackground.Controls.Add(this.listBoxDictionaryData);
            this.panelBackground.Controls.Add(this.labelCategory);
            this.panelBackground.Controls.Add(this.listBoxCategories);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.panelBackground.Size = new System.Drawing.Size(400, 342);
            this.panelBackground.TabIndex = 0;
            // 
            // labelNewValue
            // 
            this.labelNewValue.AutoSize = true;
            this.labelNewValue.Location = new System.Drawing.Point(314, 201);
            this.labelNewValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewValue.Name = "labelNewValue";
            this.labelNewValue.Size = new System.Drawing.Size(47, 13);
            this.labelNewValue.TabIndex = 10;
            this.labelNewValue.Text = "Wartość";
            // 
            // labelDictionaryNewWord
            // 
            this.labelDictionaryNewWord.AutoSize = true;
            this.labelDictionaryNewWord.Location = new System.Drawing.Point(194, 201);
            this.labelDictionaryNewWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDictionaryNewWord.Name = "labelDictionaryNewWord";
            this.labelDictionaryNewWord.Size = new System.Drawing.Size(122, 13);
            this.labelDictionaryNewWord.TabIndex = 9;
            this.labelDictionaryNewWord.Text = "Nowa dana słownikowa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 217);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 8;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(327, 287);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveAndQuit
            // 
            this.buttonSaveAndQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAndQuit.AutoSize = true;
            this.buttonSaveAndQuit.Location = new System.Drawing.Point(240, 287);
            this.buttonSaveAndQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.buttonSaveAndQuit.Name = "buttonSaveAndQuit";
            this.buttonSaveAndQuit.Size = new System.Drawing.Size(82, 23);
            this.buttonSaveAndQuit.TabIndex = 6;
            this.buttonSaveAndQuit.Text = "Zapisz i wyjdź";
            this.buttonSaveAndQuit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.Location = new System.Drawing.Point(195, 245);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(183, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj daną słownikową";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxNewDictionaryData
            // 
            this.textBoxNewDictionaryData.Location = new System.Drawing.Point(195, 217);
            this.textBoxNewDictionaryData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNewDictionaryData.MaxLength = 200;
            this.textBoxNewDictionaryData.Name = "textBoxNewDictionaryData";
            this.textBoxNewDictionaryData.Size = new System.Drawing.Size(116, 20);
            this.textBoxNewDictionaryData.TabIndex = 4;
            // 
            // labelDictionaryData
            // 
            this.labelDictionaryData.AutoSize = true;
            this.labelDictionaryData.Location = new System.Drawing.Point(194, 24);
            this.labelDictionaryData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelDictionaryData.Name = "labelDictionaryData";
            this.labelDictionaryData.Size = new System.Drawing.Size(93, 13);
            this.labelDictionaryData.TabIndex = 3;
            this.labelDictionaryData.Text = "Dane słownikowe";
            this.labelDictionaryData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxDictionaryData
            // 
            this.listBoxDictionaryData.FormattingEnabled = true;
            this.listBoxDictionaryData.Location = new System.Drawing.Point(195, 43);
            this.listBoxDictionaryData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxDictionaryData.Name = "listBoxDictionaryData";
            this.listBoxDictionaryData.Size = new System.Drawing.Size(184, 147);
            this.listBoxDictionaryData.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(19, 24);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Kategoria";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Items.AddRange(new object[] {
            "Nadwozie",
            "Kolor",
            "Silnik",
            "Paliwo",
            "Skrzynia biegów",
            "Seria",
            "Usługi"});
            this.listBoxCategories.Location = new System.Drawing.Point(19, 43);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(128, 225);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxCategories_SelectedIndexChanged);
            // 
            // polsl_agatek_bdDataSet
            // 
            this.polsl_agatek_bdDataSet.DataSetName = "polsl_agatek_bdDataSet";
            this.polsl_agatek_bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polslagatekbdDataSetBindingSource
            // 
            this.polslagatekbdDataSetBindingSource.DataSource = this.polsl_agatek_bdDataSet;
            this.polslagatekbdDataSetBindingSource.Position = 0;
            // 
            // dictbodyBindingSource
            // 
            this.dictbodyBindingSource.DataMember = "dict_body";
            this.dictbodyBindingSource.DataSource = this.polslagatekbdDataSetBindingSource;
            // 
            // dict_bodyTableAdapter
            // 
            this.dict_bodyTableAdapter.ClearBeforeFill = true;
            // 
            // FormDictionaryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 342);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(416, 381);
            this.Name = "FormDictionaryData";
            this.Text = "Dane słownikowe";
            this.Load += new System.EventHandler(this.FormDictionaryData_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polsl_agatek_bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polslagatekbdDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictbodyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.TextBox textBoxNewDictionaryData;
        private System.Windows.Forms.Label labelDictionaryData;
        private System.Windows.Forms.ListBox listBoxDictionaryData;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSaveAndQuit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelNewValue;
        private System.Windows.Forms.Label labelDictionaryNewWord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource polslagatekbdDataSetBindingSource;
        private polsl_agatek_bdDataSet polsl_agatek_bdDataSet;
        private System.Windows.Forms.BindingSource dictbodyBindingSource;
        private polsl_agatek_bdDataSetTableAdapters.dict_bodyTableAdapter dict_bodyTableAdapter;
    }
}