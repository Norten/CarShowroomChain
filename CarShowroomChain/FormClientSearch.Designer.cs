namespace CarShowroomChain
{
    partial class FormClientSearch
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
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIDNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHouseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelephoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxIDNumber = new System.Windows.Forms.TextBox();
            this.labelIDNumber = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonAddNew);
            this.panelBackground.Controls.Add(this.buttonModify);
            this.panelBackground.Controls.Add(this.buttonChoose);
            this.panelBackground.Controls.Add(this.buttonFilter);
            this.panelBackground.Controls.Add(this.dataGridViewClients);
            this.panelBackground.Controls.Add(this.textBoxIDNumber);
            this.panelBackground.Controls.Add(this.labelIDNumber);
            this.panelBackground.Controls.Add(this.textBoxSurname);
            this.panelBackground.Controls.Add(this.labelSurname);
            this.panelBackground.Controls.Add(this.textBoxName);
            this.panelBackground.Controls.Add(this.labelName);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(882, 653);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(784, 587);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNew.AutoSize = true;
            this.buttonAddNew.Location = new System.Drawing.Point(625, 587);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(153, 27);
            this.buttonAddNew.TabIndex = 10;
            this.buttonAddNew.Text = "Dodaj nowego klienta";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModify.AutoSize = true;
            this.buttonModify.Location = new System.Drawing.Point(542, 587);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(77, 27);
            this.buttonModify.TabIndex = 9;
            this.buttonModify.Text = "Modyfikuj";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonChoose
            // 
            this.buttonChoose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChoose.AutoSize = true;
            this.buttonChoose.Location = new System.Drawing.Point(461, 587);
            this.buttonChoose.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 27);
            this.buttonChoose.TabIndex = 8;
            this.buttonChoose.Text = "Wybierz";
            this.buttonChoose.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.Location = new System.Drawing.Point(780, 100);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(79, 27);
            this.buttonFilter.TabIndex = 7;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnSurname,
            this.columnIDNum,
            this.columnCountry,
            this.columnState,
            this.columnCity,
            this.columnPostalCode,
            this.columnStreet,
            this.columnHouseNum,
            this.columnTelephoneNum,
            this.columnEmail});
            this.dataGridViewClients.Location = new System.Drawing.Point(23, 160);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 3, 3, 75);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(836, 409);
            this.dataGridViewClients.TabIndex = 6;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Imię";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // columnSurname
            // 
            this.columnSurname.HeaderText = "Nazwisko";
            this.columnSurname.Name = "columnSurname";
            this.columnSurname.ReadOnly = true;
            // 
            // columnIDNum
            // 
            this.columnIDNum.HeaderText = "Nr dowodu osobistego";
            this.columnIDNum.Name = "columnIDNum";
            this.columnIDNum.ReadOnly = true;
            // 
            // columnCountry
            // 
            this.columnCountry.HeaderText = "Kraj";
            this.columnCountry.Name = "columnCountry";
            this.columnCountry.ReadOnly = true;
            // 
            // columnState
            // 
            this.columnState.HeaderText = "Województwo";
            this.columnState.Name = "columnState";
            this.columnState.ReadOnly = true;
            // 
            // columnCity
            // 
            this.columnCity.HeaderText = "Miasto";
            this.columnCity.Name = "columnCity";
            this.columnCity.ReadOnly = true;
            // 
            // columnPostalCode
            // 
            this.columnPostalCode.HeaderText = "Kod pocztowy";
            this.columnPostalCode.Name = "columnPostalCode";
            this.columnPostalCode.ReadOnly = true;
            // 
            // columnStreet
            // 
            this.columnStreet.HeaderText = "Ulica";
            this.columnStreet.Name = "columnStreet";
            this.columnStreet.ReadOnly = true;
            // 
            // columnHouseNum
            // 
            this.columnHouseNum.HeaderText = "Nr domu/mieszkania";
            this.columnHouseNum.Name = "columnHouseNum";
            this.columnHouseNum.ReadOnly = true;
            // 
            // columnTelephoneNum
            // 
            this.columnTelephoneNum.HeaderText = "Nr telefonu";
            this.columnTelephoneNum.Name = "columnTelephoneNum";
            this.columnTelephoneNum.ReadOnly = true;
            // 
            // columnEmail
            // 
            this.columnEmail.HeaderText = "E-mail";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            // 
            // textBoxIDNumber
            // 
            this.textBoxIDNumber.Location = new System.Drawing.Point(249, 97);
            this.textBoxIDNumber.MaxLength = 9;
            this.textBoxIDNumber.Name = "textBoxIDNumber";
            this.textBoxIDNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDNumber.TabIndex = 5;
            // 
            // labelIDNumber
            // 
            this.labelIDNumber.AutoSize = true;
            this.labelIDNumber.Location = new System.Drawing.Point(25, 100);
            this.labelIDNumber.Name = "labelIDNumber";
            this.labelIDNumber.Size = new System.Drawing.Size(218, 17);
            this.labelIDNumber.TabIndex = 4;
            this.labelIDNumber.Text = "Seria i numer dowodu osobistego";
            this.labelIDNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(249, 62);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 3;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(25, 65);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(249, 27);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Imię";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormClientSearch";
            this.Text = "Wyszukiwanie klientów";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxIDNumber;
        private System.Windows.Forms.Label labelIDNumber;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnState;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHouseNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelephoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonChoose;
    }
}