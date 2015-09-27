namespace CarShowroomChain
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
            this.labelPersonalData = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panel2BackgroundLogin = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBoxNewPassword = new System.Windows.Forms.GroupBox();
            this.textBoxNewPassword2 = new System.Windows.Forms.TextBox();
            this.labelRepeatNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword1 = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelLoginData = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxTelephoneNum = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxShop = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelephoneNum = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelShop = new System.Windows.Forms.Label();
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
            this.splitContainerBackground.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerBackground.Name = "splitContainerBackground";
            // 
            // splitContainerBackground.Panel1
            // 
            this.splitContainerBackground.Panel1.Controls.Add(this.flowLayoutPanel1Background);
            // 
            // splitContainerBackground.Panel2
            // 
            this.splitContainerBackground.Panel2.Controls.Add(this.panel2BackgroundPersonalData);
            this.splitContainerBackground.Size = new System.Drawing.Size(588, 456);
            this.splitContainerBackground.SplitterDistance = 91;
            this.splitContainerBackground.SplitterWidth = 3;
            this.splitContainerBackground.TabIndex = 0;
            // 
            // flowLayoutPanel1Background
            // 
            this.flowLayoutPanel1Background.Controls.Add(this.buttonPersonalData);
            this.flowLayoutPanel1Background.Controls.Add(this.buttonLoginData);
            this.flowLayoutPanel1Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1Background.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1Background.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1Background.Name = "flowLayoutPanel1Background";
            this.flowLayoutPanel1Background.Size = new System.Drawing.Size(91, 456);
            this.flowLayoutPanel1Background.TabIndex = 0;
            // 
            // buttonPersonalData
            // 
            this.buttonPersonalData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPersonalData.Location = new System.Drawing.Point(2, 2);
            this.buttonPersonalData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPersonalData.Name = "buttonPersonalData";
            this.buttonPersonalData.Size = new System.Drawing.Size(64, 69);
            this.buttonPersonalData.TabIndex = 0;
            this.buttonPersonalData.Text = "Dane osobowe";
            this.buttonPersonalData.UseVisualStyleBackColor = true;
            this.buttonPersonalData.Click += new System.EventHandler(this.buttonPersonalData_Click);
            // 
            // buttonLoginData
            // 
            this.buttonLoginData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoginData.Location = new System.Drawing.Point(2, 75);
            this.buttonLoginData.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoginData.Name = "buttonLoginData";
            this.buttonLoginData.Size = new System.Drawing.Size(64, 69);
            this.buttonLoginData.TabIndex = 1;
            this.buttonLoginData.Text = "Dane logowania";
            this.buttonLoginData.UseVisualStyleBackColor = true;
            this.buttonLoginData.Click += new System.EventHandler(this.buttonLoginData_Click);
            // 
            // panel2BackgroundPersonalData
            // 
            this.panel2BackgroundPersonalData.Controls.Add(this.labelPersonalData);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxEmail);
            this.panel2BackgroundPersonalData.Controls.Add(this.panel2BackgroundLogin);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxTelephoneNum);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxAddress);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxRole);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxName);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxSurname);
            this.panel2BackgroundPersonalData.Controls.Add(this.textBoxShop);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelEmail);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelTelephoneNum);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelAddress);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelRole);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelShop);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelSurname);
            this.panel2BackgroundPersonalData.Controls.Add(this.labelName);
            this.panel2BackgroundPersonalData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2BackgroundPersonalData.Location = new System.Drawing.Point(0, 0);
            this.panel2BackgroundPersonalData.Margin = new System.Windows.Forms.Padding(2);
            this.panel2BackgroundPersonalData.Name = "panel2BackgroundPersonalData";
            this.panel2BackgroundPersonalData.Size = new System.Drawing.Size(494, 456);
            this.panel2BackgroundPersonalData.TabIndex = 0;
            // 
            // labelPersonalData
            // 
            this.labelPersonalData.AutoSize = true;
            this.labelPersonalData.Location = new System.Drawing.Point(19, 24);
            this.labelPersonalData.Margin = new System.Windows.Forms.Padding(2);
            this.labelPersonalData.Name = "labelPersonalData";
            this.labelPersonalData.Size = new System.Drawing.Size(95, 13);
            this.labelPersonalData.TabIndex = 65;
            this.labelPersonalData.Text = "Dane użytkownika";
            this.labelPersonalData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(354, 51);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(114, 20);
            this.textBoxEmail.TabIndex = 64;
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
            this.panel2BackgroundLogin.Margin = new System.Windows.Forms.Padding(2);
            this.panel2BackgroundLogin.Name = "panel2BackgroundLogin";
            this.panel2BackgroundLogin.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel2BackgroundLogin.Size = new System.Drawing.Size(494, 456);
            this.panel2BackgroundLogin.TabIndex = 66;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(421, 412);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 24);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 69;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(357, 412);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(59, 23);
            this.buttonAccept.TabIndex = 68;
            this.buttonAccept.Text = "Akceptuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // groupBoxNewPassword
            // 
            this.groupBoxNewPassword.AutoSize = true;
            this.groupBoxNewPassword.Controls.Add(this.textBoxNewPassword2);
            this.groupBoxNewPassword.Controls.Add(this.labelRepeatNewPassword);
            this.groupBoxNewPassword.Controls.Add(this.textBoxNewPassword1);
            this.groupBoxNewPassword.Controls.Add(this.labelNewPassword);
            this.groupBoxNewPassword.Location = new System.Drawing.Point(22, 110);
            this.groupBoxNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNewPassword.Name = "groupBoxNewPassword";
            this.groupBoxNewPassword.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNewPassword.Size = new System.Drawing.Size(207, 87);
            this.groupBoxNewPassword.TabIndex = 67;
            this.groupBoxNewPassword.TabStop = false;
            this.groupBoxNewPassword.Text = "Zmiana hasła";
            // 
            // textBoxNewPassword2
            // 
            this.textBoxNewPassword2.Location = new System.Drawing.Point(127, 50);
            this.textBoxNewPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewPassword2.MaxLength = 50;
            this.textBoxNewPassword2.Name = "textBoxNewPassword2";
            this.textBoxNewPassword2.Size = new System.Drawing.Size(76, 20);
            this.textBoxNewPassword2.TabIndex = 71;
            this.textBoxNewPassword2.UseSystemPasswordChar = true;
            // 
            // labelRepeatNewPassword
            // 
            this.labelRepeatNewPassword.AutoSize = true;
            this.labelRepeatNewPassword.Location = new System.Drawing.Point(22, 53);
            this.labelRepeatNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRepeatNewPassword.Name = "labelRepeatNewPassword";
            this.labelRepeatNewPassword.Size = new System.Drawing.Size(104, 13);
            this.labelRepeatNewPassword.TabIndex = 70;
            this.labelRepeatNewPassword.Text = "Powtórz nowe hasło";
            this.labelRepeatNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNewPassword1
            // 
            this.textBoxNewPassword1.Location = new System.Drawing.Point(127, 26);
            this.textBoxNewPassword1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewPassword1.MaxLength = 50;
            this.textBoxNewPassword1.Name = "textBoxNewPassword1";
            this.textBoxNewPassword1.Size = new System.Drawing.Size(76, 20);
            this.textBoxNewPassword1.TabIndex = 69;
            this.textBoxNewPassword1.UseSystemPasswordChar = true;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(22, 28);
            this.labelNewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(65, 13);
            this.labelNewPassword.TabIndex = 68;
            this.labelNewPassword.Text = "Nowe hasło";
            this.labelNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoginData
            // 
            this.labelLoginData.AutoSize = true;
            this.labelLoginData.Location = new System.Drawing.Point(19, 24);
            this.labelLoginData.Margin = new System.Windows.Forms.Padding(2);
            this.labelLoginData.Name = "labelLoginData";
            this.labelLoginData.Size = new System.Drawing.Size(84, 13);
            this.labelLoginData.TabIndex = 66;
            this.labelLoginData.Text = "Dane logowania";
            this.labelLoginData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(82, 79);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(76, 20);
            this.textBoxPassword.TabIndex = 48;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(45, 81);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(36, 13);
            this.labelPassword.TabIndex = 47;
            this.labelPassword.Text = "Hasło";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(82, 50);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(76, 20);
            this.textBoxLogin.TabIndex = 46;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(45, 53);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 45;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTelephoneNum
            // 
            this.textBoxTelephoneNum.Location = new System.Drawing.Point(124, 198);
            this.textBoxTelephoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelephoneNum.MaxLength = 15;
            this.textBoxTelephoneNum.Name = "textBoxTelephoneNum";
            this.textBoxTelephoneNum.ReadOnly = true;
            this.textBoxTelephoneNum.Size = new System.Drawing.Size(114, 20);
            this.textBoxTelephoneNum.TabIndex = 63;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(124, 107);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.MaxLength = 200;
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(114, 84);
            this.textBoxAddress.TabIndex = 60;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(354, 79);
            this.textBoxRole.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRole.MaxLength = 50;
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.ReadOnly = true;
            this.textBoxRole.Size = new System.Drawing.Size(114, 20);
            this.textBoxRole.TabIndex = 59;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 50);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(113, 20);
            this.textBoxName.TabIndex = 55;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(124, 79);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(113, 20);
            this.textBoxSurname.TabIndex = 56;
            // 
            // textBoxShop
            // 
            this.textBoxShop.Location = new System.Drawing.Point(354, 107);
            this.textBoxShop.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxShop.MaxLength = 200;
            this.textBoxShop.Multiline = true;
            this.textBoxShop.Name = "textBoxShop";
            this.textBoxShop.ReadOnly = true;
            this.textBoxShop.Size = new System.Drawing.Size(114, 84);
            this.textBoxShop.TabIndex = 57;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(272, 54);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 13);
            this.labelEmail.TabIndex = 54;
            this.labelEmail.Text = "Adres e-mail";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTelephoneNum
            // 
            this.labelTelephoneNum.AutoSize = true;
            this.labelTelephoneNum.Location = new System.Drawing.Point(45, 205);
            this.labelTelephoneNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelephoneNum.Name = "labelTelephoneNum";
            this.labelTelephoneNum.Size = new System.Drawing.Size(59, 13);
            this.labelTelephoneNum.TabIndex = 53;
            this.labelTelephoneNum.Text = "Nr telefonu";
            this.labelTelephoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(45, 107);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(34, 13);
            this.labelAddress.TabIndex = 50;
            this.labelAddress.Text = "Adres";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(272, 81);
            this.labelRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 49;
            this.labelRole.Text = "Rola";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(272, 110);
            this.labelShop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(34, 13);
            this.labelShop.TabIndex = 47;
            this.labelShop.Text = "Sklep";
            this.labelShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(45, 81);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 46;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(45, 50);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 45;
            this.labelName.Text = "Imię";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 456);
            this.Controls.Add(this.splitContainerBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(604, 495);
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
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxShop;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelephoneNum;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLoginData;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.GroupBox groupBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword1;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.TextBox textBoxNewPassword2;
        private System.Windows.Forms.Label labelRepeatNewPassword;
    }
}