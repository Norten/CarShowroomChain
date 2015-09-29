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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDictionaryData));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.textBoxAddedCost = new System.Windows.Forms.TextBox();
            this.textBoxAddedValue = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.listBoxCost = new System.Windows.Forms.ListBox();
            this.labelNewValue = new System.Windows.Forms.Label();
            this.labelDictionaryNewWord = new System.Windows.Forms.Label();
            this.textBoxNewValue = new System.Windows.Forms.TextBox();
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
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polsl_agatek_bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polslagatekbdDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictbodyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.pictureBoxQuestionMark);
            this.panelBackground.Controls.Add(this.textBoxAddedCost);
            this.panelBackground.Controls.Add(this.textBoxAddedValue);
            this.panelBackground.Controls.Add(this.labelCost);
            this.panelBackground.Controls.Add(this.listBoxCost);
            this.panelBackground.Controls.Add(this.labelNewValue);
            this.panelBackground.Controls.Add(this.labelDictionaryNewWord);
            this.panelBackground.Controls.Add(this.textBoxNewValue);
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
            this.panelBackground.Margin = new System.Windows.Forms.Padding(2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.panelBackground.Size = new System.Drawing.Size(541, 342);
            this.panelBackground.TabIndex = 0;
            // 
            // textBoxAddedCost
            // 
            this.textBoxAddedCost.Location = new System.Drawing.Point(315, 283);
            this.textBoxAddedCost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddedCost.Name = "textBoxAddedCost";
            this.textBoxAddedCost.Size = new System.Drawing.Size(64, 20);
            this.textBoxAddedCost.TabIndex = 16;
            // 
            // textBoxAddedValue
            // 
            this.textBoxAddedValue.Location = new System.Drawing.Point(195, 283);
            this.textBoxAddedValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddedValue.MaxLength = 200;
            this.textBoxAddedValue.Name = "textBoxAddedValue";
            this.textBoxAddedValue.Size = new System.Drawing.Size(116, 20);
            this.textBoxAddedValue.TabIndex = 15;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(391, 24);
            this.labelCost.Margin = new System.Windows.Forms.Padding(2);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(33, 13);
            this.labelCost.TabIndex = 12;
            this.labelCost.Text = "Koszt";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxCost
            // 
            this.listBoxCost.FormattingEnabled = true;
            this.listBoxCost.Location = new System.Drawing.Point(394, 41);
            this.listBoxCost.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCost.Name = "listBoxCost";
            this.listBoxCost.Size = new System.Drawing.Size(97, 147);
            this.listBoxCost.TabIndex = 11;
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
            // textBoxNewValue
            // 
            this.textBoxNewValue.Location = new System.Drawing.Point(315, 217);
            this.textBoxNewValue.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(64, 20);
            this.textBoxNewValue.TabIndex = 8;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(468, 287);
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
            this.buttonSaveAndQuit.Location = new System.Drawing.Point(382, 287);
            this.buttonSaveAndQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.buttonSaveAndQuit.Name = "buttonSaveAndQuit";
            this.buttonSaveAndQuit.Size = new System.Drawing.Size(82, 23);
            this.buttonSaveAndQuit.TabIndex = 6;
            this.buttonSaveAndQuit.Text = "Zapisz i wyjdź";
            this.buttonSaveAndQuit.UseVisualStyleBackColor = true;
            this.buttonSaveAndQuit.Click += new System.EventHandler(this.buttonSaveAndQuit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.Location = new System.Drawing.Point(195, 247);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 8, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(183, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj daną słownikową";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNewDictionaryData
            // 
            this.textBoxNewDictionaryData.Location = new System.Drawing.Point(195, 217);
            this.textBoxNewDictionaryData.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewDictionaryData.MaxLength = 200;
            this.textBoxNewDictionaryData.Name = "textBoxNewDictionaryData";
            this.textBoxNewDictionaryData.Size = new System.Drawing.Size(116, 20);
            this.textBoxNewDictionaryData.TabIndex = 4;
            // 
            // labelDictionaryData
            // 
            this.labelDictionaryData.AutoSize = true;
            this.labelDictionaryData.Location = new System.Drawing.Point(194, 24);
            this.labelDictionaryData.Margin = new System.Windows.Forms.Padding(2);
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
            this.listBoxDictionaryData.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDictionaryData.Name = "listBoxDictionaryData";
            this.listBoxDictionaryData.Size = new System.Drawing.Size(184, 147);
            this.listBoxDictionaryData.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(19, 24);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(2);
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
            "Usługi",
            "Model"});
            this.listBoxCategories.Location = new System.Drawing.Point(19, 43);
            this.listBoxCategories.Margin = new System.Windows.Forms.Padding(2);
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
            // pictureBoxQuestionMark
            // 
            this.pictureBoxQuestionMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuestionMark.BackgroundImage")));
            this.pictureBoxQuestionMark.Location = new System.Drawing.Point(504, 12);
            this.pictureBoxQuestionMark.Name = "pictureBoxQuestionMark";
            this.pictureBoxQuestionMark.Size = new System.Drawing.Size(25, 24);
            this.pictureBoxQuestionMark.TabIndex = 76;
            this.pictureBoxQuestionMark.TabStop = false;
            this.pictureBoxQuestionMark.Click += new System.EventHandler(this.pictureBoxQuestionMark_Click);
            // 
            // FormDictionaryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 342);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(416, 381);
            this.Name = "FormDictionaryData";
            this.Text = "Dane słownikowe";
            this.Load += new System.EventHandler(this.FormDictionaryData_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polsl_agatek_bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polslagatekbdDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictbodyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxNewValue;
        private System.Windows.Forms.BindingSource polslagatekbdDataSetBindingSource;
        private polsl_agatek_bdDataSet polsl_agatek_bdDataSet;
        private System.Windows.Forms.BindingSource dictbodyBindingSource;
        private polsl_agatek_bdDataSetTableAdapters.dict_bodyTableAdapter dict_bodyTableAdapter;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.ListBox listBoxCost;
        private System.Windows.Forms.TextBox textBoxAddedCost;
        private System.Windows.Forms.TextBox textBoxAddedValue;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
    }
}