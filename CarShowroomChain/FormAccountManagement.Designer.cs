﻿namespace CarShowroomChain
{
    partial class FormAccountManagement
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
            this.splitContainerBackground = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1Background = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPersonalData = new System.Windows.Forms.Button();
            this.buttonLoginData = new System.Windows.Forms.Button();
            this.panel2BackgroundPersonalData = new System.Windows.Forms.Panel();
            this.panel2BackgroundLogin = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBoxNewPassword = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRepeatNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelLoginData = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPersonalData = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelephoneNum = new System.Windows.Forms.TextBox();
            this.textBoxHouseNum = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxIDNum = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelephoneNum = new System.Windows.Forms.Label();
            this.labelHouseNum = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelIDNum = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBackground)).BeginInit();
            this.splitContainerBackground.Panel1.SuspendLayout();
            this.splitContainerBackground.Panel2.SuspendLayout();
            this.splitContainerBackground.SuspendLayout();
            this.flowLayoutPanel1Background.SuspendLayout();
            this.panel2BackgroundPersonalData.SuspendLayout();
            this.panel2BackgroundLogin.SuspendLayout();
            this.groupBoxNewPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerBackground
            // 
            this.splitContainerBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBackground.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerBackground.IsSplitterFixed = true;
            this.splitContainerBackground.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBackground.Name = "splitContainerBackground";
            // 
            // splitContainerBackground.Panel1
            // 
            this.splitContainerBackground.Panel1.Controls.Add(this.flowLayoutPanel1Background);
            // 
            // splitContainerBackground.Panel2
            // 
            this.splitContainerBackground.Panel2.Controls.Add(this.panel2BackgroundPersonalData);
            this.splitContainerBackground.Size = new System.Drawing.Size(782, 553);
            this.splitContainerBackground.SplitterDistance = 91;
            this.splitContainerBackground.TabIndex = 0;
            // 
            // flowLayoutPanel1Background
            // 
            this.flowLayoutPanel1Background.Controls.Add(this.buttonPersonalData);
            this.flowLayoutPanel1Background.Controls.Add(this.buttonLoginData);
            this.flowLayoutPanel1Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1Background.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1Background.Name = "flowLayoutPanel1Background";
            this.flowLayoutPanel1Background.Size = new System.Drawing.Size(91, 553);
            this.flowLayoutPanel1Background.TabIndex = 0;
            // 
            // buttonPersonalData
            // 
            this.buttonPersonalData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPersonalData.Location = new System.Drawing.Point(3, 3);
            this.buttonPersonalData.Name = "buttonPersonalData";
            this.buttonPersonalData.Size = new System.Drawing.Size(85, 85);
            this.buttonPersonalData.TabIndex = 0;
            this.buttonPersonalData.Text = "Dane osobowe";
            this.buttonPersonalData.UseVisualStyleBackColor = true;
            this.buttonPersonalData.Click += new System.EventHandler(this.buttonPersonalData_Click);
            // 
            // buttonLoginData
            // 
            this.buttonLoginData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoginData.Location = new System.Drawing.Point(3, 94);
            this.buttonLoginData.Name = "buttonLoginData";
            this.buttonLoginData.Size = new System.Drawing.Size(85, 85);
            this.buttonLoginData.TabIndex = 1;
            this.buttonLoginData.Text = "Dane logowania";
            this.buttonLoginData.UseVisualStyleBackColor = true;
            this.buttonLoginData.Click += new System.EventHandler(this.buttonLoginData_Click);
            // 
            // panel2BackgroundPersonalData
            // 
            this.panel2BackgroundPersonalData.Controls.Add(this.panel2BackgroundLogin);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelPersonalData);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxEmail);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxTelephoneNum);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxHouseNum);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxStreet);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxCity);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxPostalCode);
            this.panel2BackgroundPersonalData.Controls.Add(this.comboBoxState);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxName);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxSurname);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxIDNum);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelEmail);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelTelephoneNum);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelHouseNum);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelStreet);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelCity);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelPostalCode);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelState);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelIDNum);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelSurname);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelName);
            this.panel2BackgroundPersonalData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2BackgroundPersonalData.Location = new System.Drawing.Point(0, 0);
            this.panel2BackgroundPersonalData.Name = "panel2BackgroundPersonalData";
            this.panel2BackgroundPersonalData.Size = new System.Drawing.Size(687, 553);
            this.panel2BackgroundPersonalData.TabIndex = 0;
            // 
            // panel2BackgroundLogin
            // 
            this.panel2BackgroundLogin.Controls.Add(this.buttonCancel);
            this.panel2BackgroundLogin.Controls.Add(this.buttonAccept);
            this.panel2BackgroundLogin.Controls.Add(this.groupBoxNewPassword);
            this.panel2BackgroundLogin.Controls.Add(this.labelLoginData);
            this.panel2BackgroundLogin.Controls.Add(this.textBoxPassword);
            this.panel2BackgroundLogin.Controls.Add(this.labelPassword);
            this.panel2BackgroundLogin.Controls.Add(this.textBoxLogin);
            this.panel2BackgroundLogin.Controls.Add(this.labelLogin);
            this.panel2BackgroundLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2BackgroundLogin.Location = new System.Drawing.Point(0, 0);
            this.panel2BackgroundLogin.Name = "panel2BackgroundLogin";
            this.panel2BackgroundLogin.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel2BackgroundLogin.Size = new System.Drawing.Size(687, 553);
            this.panel2BackgroundLogin.TabIndex = 66;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(589, 500);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 69;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(508, 500);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 27);
            this.buttonAccept.TabIndex = 68;
            this.buttonAccept.Text = "Akceptuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // groupBoxNewPassword
            // 
            this.groupBoxNewPassword.AutoSize = true;
            this.groupBoxNewPassword.Controls.Add(this.textBox1);
            this.groupBoxNewPassword.Controls.Add(this.labelRepeatNewPassword);
            this.groupBoxNewPassword.Controls.Add(this.textBoxNewPassword);
            this.groupBoxNewPassword.Controls.Add(this.labelNewPassword);
            this.groupBoxNewPassword.Location = new System.Drawing.Point(30, 135);
            this.groupBoxNewPassword.Name = "groupBoxNewPassword";
            this.groupBoxNewPassword.Size = new System.Drawing.Size(275, 105);
            this.groupBoxNewPassword.TabIndex = 67;
            this.groupBoxNewPassword.TabStop = false;
            this.groupBoxNewPassword.Text = "Zmiana hasła";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 62);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 71;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // labelRepeatNewPassword
            // 
            this.labelRepeatNewPassword.AutoSize = true;
            this.labelRepeatNewPassword.Location = new System.Drawing.Point(30, 65);
            this.labelRepeatNewPassword.Name = "labelRepeatNewPassword";
            this.labelRepeatNewPassword.Size = new System.Drawing.Size(133, 17);
            this.labelRepeatNewPassword.TabIndex = 70;
            this.labelRepeatNewPassword.Text = "Powtórz nowe hasło";
            this.labelRepeatNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(169, 32);
            this.textBoxNewPassword.MaxLength = 50;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewPassword.TabIndex = 69;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(30, 35);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(3);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(81, 17);
            this.labelNewPassword.TabIndex = 68;
            this.labelNewPassword.Text = "Nowe hasło";
            this.labelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoginData
            // 
            this.labelLoginData.AutoSize = true;
            this.labelLoginData.Location = new System.Drawing.Point(25, 30);
            this.labelLoginData.Margin = new System.Windows.Forms.Padding(3);
            this.labelLoginData.Name = "labelLoginData";
            this.labelLoginData.Size = new System.Drawing.Size(109, 17);
            this.labelLoginData.TabIndex = 66;
            this.labelLoginData.Text = "Dane logowania";
            this.labelLoginData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(110, 97);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 48;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(60, 100);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(44, 17);
            this.labelPassword.TabIndex = 47;
            this.labelPassword.Text = "Hasło";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(110, 62);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLogin.TabIndex = 46;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(60, 65);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(3);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 17);
            this.labelLogin.TabIndex = 45;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPersonalData
            // 
            this.labelPersonalData.AutoSize = true;
            this.labelPersonalData.Location = new System.Drawing.Point(25, 30);
            this.labelPersonalData.Margin = new System.Windows.Forms.Padding(3);
            this.labelPersonalData.Name = "labelPersonalData";
            this.labelPersonalData.Size = new System.Drawing.Size(122, 17);
            this.labelPersonalData.TabIndex = 65;
            this.labelPersonalData.Text = "Dane użytkownika";
            this.labelPersonalData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(523, 202);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 64;
            // 
            // textBoxTelephoneNum
            // 
            this.textBoxTelephoneNum.Location = new System.Drawing.Point(523, 167);
            this.textBoxTelephoneNum.MaxLength = 15;
            this.textBoxTelephoneNum.Name = "textBoxTelephoneNum";
            this.textBoxTelephoneNum.ReadOnly = true;
            this.textBoxTelephoneNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelephoneNum.TabIndex = 63;
            // 
            // textBoxHouseNum
            // 
            this.textBoxHouseNum.Location = new System.Drawing.Point(523, 132);
            this.textBoxHouseNum.MaxLength = 15;
            this.textBoxHouseNum.Name = "textBoxHouseNum";
            this.textBoxHouseNum.ReadOnly = true;
            this.textBoxHouseNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxHouseNum.TabIndex = 62;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(523, 97);
            this.textBoxStreet.MaxLength = 50;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.ReadOnly = true;
            this.textBoxStreet.Size = new System.Drawing.Size(100, 22);
            this.textBoxStreet.TabIndex = 61;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(523, 62);
            this.textBoxCity.MaxLength = 50;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxCity.TabIndex = 60;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(215, 202);
            this.textBoxPostalCode.MaxLength = 6;
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.ReadOnly = true;
            this.textBoxPostalCode.Size = new System.Drawing.Size(100, 22);
            this.textBoxPostalCode.TabIndex = 59;
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.Enabled = false;
            this.comboBoxState.Location = new System.Drawing.Point(215, 167);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 24);
            this.comboBoxState.TabIndex = 58;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(215, 62);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 55;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(215, 97);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 56;
            // 
            // textBoxIDNum
            // 
            this.textBoxIDNum.Location = new System.Drawing.Point(215, 132);
            this.textBoxIDNum.MaxLength = 9;
            this.textBoxIDNum.Name = "textBoxIDNum";
            this.textBoxIDNum.ReadOnly = true;
            this.textBoxIDNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDNum.TabIndex = 57;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(381, 205);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(87, 17);
            this.labelEmail.TabIndex = 54;
            this.labelEmail.Text = "Adres e-mail";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTelephoneNum
            // 
            this.labelTelephoneNum.AutoSize = true;
            this.labelTelephoneNum.Location = new System.Drawing.Point(381, 170);
            this.labelTelephoneNum.Name = "labelTelephoneNum";
            this.labelTelephoneNum.Size = new System.Drawing.Size(78, 17);
            this.labelTelephoneNum.TabIndex = 53;
            this.labelTelephoneNum.Text = "Nr telefonu";
            this.labelTelephoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHouseNum
            // 
            this.labelHouseNum.AutoSize = true;
            this.labelHouseNum.Location = new System.Drawing.Point(381, 135);
            this.labelHouseNum.Name = "labelHouseNum";
            this.labelHouseNum.Size = new System.Drawing.Size(136, 17);
            this.labelHouseNum.TabIndex = 52;
            this.labelHouseNum.Text = "Nr domu/mieszkania";
            this.labelHouseNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(381, 100);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(39, 17);
            this.labelStreet.TabIndex = 51;
            this.labelStreet.Text = "Ulica";
            this.labelStreet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(381, 65);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(49, 17);
            this.labelCity.TabIndex = 50;
            this.labelCity.Text = "Miasto";
            this.labelCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(60, 205);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(95, 17);
            this.labelPostalCode.TabIndex = 49;
            this.labelPostalCode.Text = "Kod pocztowy";
            this.labelPostalCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(60, 170);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(93, 17);
            this.labelState.TabIndex = 48;
            this.labelState.Text = "Województwo";
            this.labelState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIDNum
            // 
            this.labelIDNum.AutoSize = true;
            this.labelIDNum.Location = new System.Drawing.Point(60, 135);
            this.labelIDNum.Name = "labelIDNum";
            this.labelIDNum.Size = new System.Drawing.Size(149, 17);
            this.labelIDNum.TabIndex = 47;
            this.labelIDNum.Text = "Nr dowodu osobistego";
            this.labelIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(60, 100);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 46;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(60, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Imię";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.splitContainerBackground);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormAccountManagement";
            this.Text = "Zarządzanie kontem";
            this.splitContainerBackground.Panel1.ResumeLayout(false);
            this.splitContainerBackground.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBackground)).EndInit();
            this.splitContainerBackground.ResumeLayout(false);
            this.flowLayoutPanel1Background.ResumeLayout(false);
            this.panel2BackgroundPersonalData.ResumeLayout(false);
            this.panel2BackgroundPersonalData.PerformLayout();
            this.panel2BackgroundLogin.ResumeLayout(false);
            this.panel2BackgroundLogin.PerformLayout();
            this.groupBoxNewPassword.ResumeLayout(false);
            this.groupBoxNewPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerBackground;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1Background;
        private System.Windows.Forms.Button buttonPersonalData;
        private System.Windows.Forms.Button buttonLoginData;
        private System.Windows.Forms.Panel panel2BackgroundPersonalData;
        private System.Windows.Forms.Panel panel2BackgroundLogin;
        private System.Windows.Forms.Label labelPersonalData;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelephoneNum;
        private System.Windows.Forms.TextBox textBoxHouseNum;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxIDNum;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelephoneNum;
        private System.Windows.Forms.Label labelHouseNum;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelIDNum;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLoginData;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.GroupBox groupBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRepeatNewPassword;
    }
}