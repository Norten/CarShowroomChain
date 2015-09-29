namespace CarShowroomChain
{
    partial class FormNewServiceOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewServiceOrder));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxServicesPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelPurchaseDate = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonChooseClient = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxTelephoneNum = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.buttonChooseAdditionalOptions = new System.Windows.Forms.Button();
            this.labelAdditionalOptions = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelephoneNum = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.pictureBoxQuestionMark);
            this.panelBackground.Controls.Add(this.textBoxTotalPrice);
            this.panelBackground.Controls.Add(this.labelTotalPrice);
            this.panelBackground.Controls.Add(this.textBoxServicesPrice);
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.textBoxDiscount);
            this.panelBackground.Controls.Add(this.dateTimePickerPurchaseDate);
            this.panelBackground.Controls.Add(this.labelDiscount);
            this.panelBackground.Controls.Add(this.labelPurchaseDate);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonChooseClient);
            this.panelBackground.Controls.Add(this.buttonAccept);
            this.panelBackground.Controls.Add(this.textBoxEmail);
            this.panelBackground.Controls.Add(this.textBoxComment);
            this.panelBackground.Controls.Add(this.textBoxTelephoneNum);
            this.panelBackground.Controls.Add(this.labelComment);
            this.panelBackground.Controls.Add(this.textBoxCity);
            this.panelBackground.Controls.Add(this.buttonChooseAdditionalOptions);
            this.panelBackground.Controls.Add(this.labelAdditionalOptions);
            this.panelBackground.Controls.Add(this.textBoxName);
            this.panelBackground.Controls.Add(this.textBoxSurname);
            this.panelBackground.Controls.Add(this.labelEmail);
            this.panelBackground.Controls.Add(this.labelTelephoneNum);
            this.panelBackground.Controls.Add(this.labelCity);
            this.panelBackground.Controls.Add(this.labelSurname);
            this.panelBackground.Controls.Add(this.labelName);
            this.panelBackground.Controls.Add(this.labelClient);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.panelBackground.Size = new System.Drawing.Size(671, 563);
            this.panelBackground.TabIndex = 0;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(423, 307);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxTotalPrice.TabIndex = 82;
            this.textBoxTotalPrice.Text = "0";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(315, 310);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(102, 17);
            this.labelTotalPrice.TabIndex = 81;
            this.labelTotalPrice.Text = "Cena całkowita";
            // 
            // textBoxServicesPrice
            // 
            this.textBoxServicesPrice.Location = new System.Drawing.Point(181, 272);
            this.textBoxServicesPrice.Name = "textBoxServicesPrice";
            this.textBoxServicesPrice.ReadOnly = true;
            this.textBoxServicesPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxServicesPrice.TabIndex = 80;
            this.textBoxServicesPrice.Text = "0";
            this.textBoxServicesPrice.TextChanged += new System.EventHandler(this.textBoxServicesPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Cena usług i dodatków";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(181, 307);
            this.textBoxDiscount.MaxLength = 2;
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(100, 22);
            this.textBoxDiscount.TabIndex = 78;
            this.textBoxDiscount.Text = "0";
            this.textBoxDiscount.TextChanged += new System.EventHandler(this.textBoxDiscount_TextChanged);
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(119, 165);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerPurchaseDate.TabIndex = 66;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(25, 310);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(132, 17);
            this.labelDiscount.TabIndex = 77;
            this.labelDiscount.Text = "Rabat (procentowy)";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPurchaseDate
            // 
            this.labelPurchaseDate.AutoSize = true;
            this.labelPurchaseDate.Location = new System.Drawing.Point(25, 170);
            this.labelPurchaseDate.Margin = new System.Windows.Forms.Padding(3);
            this.labelPurchaseDate.Name = "labelPurchaseDate";
            this.labelPurchaseDate.Size = new System.Drawing.Size(88, 17);
            this.labelPurchaseDate.TabIndex = 65;
            this.labelPurchaseDate.Text = "Data zakupu";
            this.labelPurchaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(573, 497);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 76;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonChooseClient
            // 
            this.buttonChooseClient.AutoSize = true;
            this.buttonChooseClient.Location = new System.Drawing.Point(74, 25);
            this.buttonChooseClient.Name = "buttonChooseClient";
            this.buttonChooseClient.Size = new System.Drawing.Size(114, 27);
            this.buttonChooseClient.TabIndex = 64;
            this.buttonChooseClient.Text = "Wybierz klienta";
            this.buttonChooseClient.UseVisualStyleBackColor = true;
            this.buttonChooseClient.Click += new System.EventHandler(this.buttonChooseClient_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(492, 497);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 27);
            this.buttonAccept.TabIndex = 75;
            this.buttonAccept.Text = "Akceptuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(548, 132);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 63;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(23, 368);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(3, 3, 3, 75);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(625, 110);
            this.textBoxComment.TabIndex = 74;
            // 
            // textBoxTelephoneNum
            // 
            this.textBoxTelephoneNum.Location = new System.Drawing.Point(208, 132);
            this.textBoxTelephoneNum.MaxLength = 15;
            this.textBoxTelephoneNum.Name = "textBoxTelephoneNum";
            this.textBoxTelephoneNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelephoneNum.TabIndex = 62;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(25, 345);
            this.labelComment.Margin = new System.Windows.Forms.Padding(3);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(76, 17);
            this.labelComment.TabIndex = 73;
            this.labelComment.Text = "Komentarz";
            this.labelComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(548, 62);
            this.textBoxCity.MaxLength = 50;
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 57);
            this.textBoxCity.TabIndex = 59;
            // 
            // buttonChooseAdditionalOptions
            // 
            this.buttonChooseAdditionalOptions.AutoSize = true;
            this.buttonChooseAdditionalOptions.Location = new System.Drawing.Point(195, 200);
            this.buttonChooseAdditionalOptions.Name = "buttonChooseAdditionalOptions";
            this.buttonChooseAdditionalOptions.Size = new System.Drawing.Size(75, 27);
            this.buttonChooseAdditionalOptions.TabIndex = 70;
            this.buttonChooseAdditionalOptions.Text = "Wybierz";
            this.buttonChooseAdditionalOptions.UseVisualStyleBackColor = true;
            this.buttonChooseAdditionalOptions.Click += new System.EventHandler(this.buttonChooseAdditionalOptions_Click);
            // 
            // labelAdditionalOptions
            // 
            this.labelAdditionalOptions.AutoSize = true;
            this.labelAdditionalOptions.Location = new System.Drawing.Point(25, 205);
            this.labelAdditionalOptions.Margin = new System.Windows.Forms.Padding(3);
            this.labelAdditionalOptions.Name = "labelAdditionalOptions";
            this.labelAdditionalOptions.Size = new System.Drawing.Size(164, 17);
            this.labelAdditionalOptions.TabIndex = 69;
            this.labelAdditionalOptions.Text = "Dodatkowe opcje i usługi";
            this.labelAdditionalOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(208, 62);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 54;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(208, 97);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 55;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(406, 135);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(87, 17);
            this.labelEmail.TabIndex = 53;
            this.labelEmail.Text = "Adres e-mail";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTelephoneNum
            // 
            this.labelTelephoneNum.AutoSize = true;
            this.labelTelephoneNum.Location = new System.Drawing.Point(53, 135);
            this.labelTelephoneNum.Name = "labelTelephoneNum";
            this.labelTelephoneNum.Size = new System.Drawing.Size(78, 17);
            this.labelTelephoneNum.TabIndex = 52;
            this.labelTelephoneNum.Text = "Nr telefonu";
            this.labelTelephoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(406, 65);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(45, 17);
            this.labelCity.TabIndex = 49;
            this.labelCity.Text = "Adres";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(53, 100);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 45;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(53, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 44;
            this.labelName.Text = "Imię";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(25, 30);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(43, 17);
            this.labelClient.TabIndex = 43;
            this.labelClient.Text = "Klient";
            this.labelClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxQuestionMark
            // 
            this.pictureBoxQuestionMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuestionMark.BackgroundImage")));
            this.pictureBoxQuestionMark.Location = new System.Drawing.Point(625, 13);
            this.pictureBoxQuestionMark.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxQuestionMark.Name = "pictureBoxQuestionMark";
            this.pictureBoxQuestionMark.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxQuestionMark.TabIndex = 83;
            this.pictureBoxQuestionMark.TabStop = false;
            this.pictureBoxQuestionMark.Click += new System.EventHandler(this.pictureBoxQuestionMark_Click);
            // 
            // FormNewServiceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 563);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(689, 610);
            this.Name = "FormNewServiceOrder";
            this.Text = "Nowa zamówienie usługi";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.Label labelPurchaseDate;
        private System.Windows.Forms.Button buttonChooseClient;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelephoneNum;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelephoneNum;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonChooseAdditionalOptions;
        private System.Windows.Forms.Label labelAdditionalOptions;
        private System.Windows.Forms.TextBox textBoxServicesPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
    }
}