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
            this.panelBackground.SuspendLayout();
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
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(532, 413);
            this.panelBackground.TabIndex = 0;
            // 
            // labelNewValue
            // 
            this.labelNewValue.AutoSize = true;
            this.labelNewValue.Location = new System.Drawing.Point(418, 247);
            this.labelNewValue.Name = "labelNewValue";
            this.labelNewValue.Size = new System.Drawing.Size(60, 17);
            this.labelNewValue.TabIndex = 10;
            this.labelNewValue.Text = "Wartość";
            // 
            // labelDictionaryNewWord
            // 
            this.labelDictionaryNewWord.AutoSize = true;
            this.labelDictionaryNewWord.Location = new System.Drawing.Point(259, 247);
            this.labelDictionaryNewWord.Name = "labelDictionaryNewWord";
            this.labelDictionaryNewWord.Size = new System.Drawing.Size(153, 17);
            this.labelDictionaryNewWord.TabIndex = 9;
            this.labelDictionaryNewWord.Text = "Nowa dana słownikowa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 22);
            this.textBox1.TabIndex = 8;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(434, 347);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSaveAndQuit
            // 
            this.buttonSaveAndQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAndQuit.AutoSize = true;
            this.buttonSaveAndQuit.Location = new System.Drawing.Point(323, 347);
            this.buttonSaveAndQuit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonSaveAndQuit.Name = "buttonSaveAndQuit";
            this.buttonSaveAndQuit.Size = new System.Drawing.Size(105, 27);
            this.buttonSaveAndQuit.TabIndex = 6;
            this.buttonSaveAndQuit.Text = "Zapisz i wyjdź";
            this.buttonSaveAndQuit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.Location = new System.Drawing.Point(260, 302);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(244, 27);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj daną słownikową";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxNewDictionaryData
            // 
            this.textBoxNewDictionaryData.Location = new System.Drawing.Point(260, 267);
            this.textBoxNewDictionaryData.MaxLength = 200;
            this.textBoxNewDictionaryData.Name = "textBoxNewDictionaryData";
            this.textBoxNewDictionaryData.Size = new System.Drawing.Size(154, 22);
            this.textBoxNewDictionaryData.TabIndex = 4;
            // 
            // labelDictionaryData
            // 
            this.labelDictionaryData.AutoSize = true;
            this.labelDictionaryData.Location = new System.Drawing.Point(259, 30);
            this.labelDictionaryData.Margin = new System.Windows.Forms.Padding(3);
            this.labelDictionaryData.Name = "labelDictionaryData";
            this.labelDictionaryData.Size = new System.Drawing.Size(116, 17);
            this.labelDictionaryData.TabIndex = 3;
            this.labelDictionaryData.Text = "Dane słownikowe";
            this.labelDictionaryData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxDictionaryData
            // 
            this.listBoxDictionaryData.FormattingEnabled = true;
            this.listBoxDictionaryData.ItemHeight = 16;
            this.listBoxDictionaryData.Location = new System.Drawing.Point(260, 53);
            this.listBoxDictionaryData.Name = "listBoxDictionaryData";
            this.listBoxDictionaryData.Size = new System.Drawing.Size(244, 180);
            this.listBoxDictionaryData.TabIndex = 2;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(25, 30);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(3);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(69, 17);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Kategoria";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.ItemHeight = 16;
            this.listBoxCategories.Location = new System.Drawing.Point(25, 53);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(170, 276);
            this.listBoxCategories.TabIndex = 0;
            // 
            // FormDictionaryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 413);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(550, 460);
            this.Name = "FormDictionaryData";
            this.Text = "Dane słownikowe";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
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
    }
}