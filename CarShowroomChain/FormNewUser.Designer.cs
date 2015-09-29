namespace CarShowroomChain
{
    partial class FormNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewUser));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelephoneNum = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelephoneNum = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.comboBoxShowroomAssignment = new System.Windows.Forms.ComboBox();
            this.labelShowroomAssignment = new System.Windows.Forms.Label();
            this.groupBoxUserRoles = new System.Windows.Forms.GroupBox();
            this.checkBoxSeller = new System.Windows.Forms.CheckBox();
            this.checkBoxTechnician = new System.Windows.Forms.CheckBox();
            this.checkBoxShowroomManager = new System.Windows.Forms.CheckBox();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.labelPersonalData = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureBoxQuestionMark = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            this.groupBoxUserRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(507, 167);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 39;
            // 
            // textBoxTelephoneNum
            // 
            this.textBoxTelephoneNum.Location = new System.Drawing.Point(507, 132);
            this.textBoxTelephoneNum.MaxLength = 15;
            this.textBoxTelephoneNum.Name = "textBoxTelephoneNum";
            this.textBoxTelephoneNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelephoneNum.TabIndex = 38;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(507, 62);
            this.textBoxAddress.MaxLength = 50;
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 57);
            this.textBoxAddress.TabIndex = 35;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(215, 132);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 30;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(215, 167);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 31;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(365, 170);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(87, 17);
            this.labelEmail.TabIndex = 29;
            this.labelEmail.Text = "Adres e-mail";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTelephoneNum
            // 
            this.labelTelephoneNum.AutoSize = true;
            this.labelTelephoneNum.Location = new System.Drawing.Point(365, 135);
            this.labelTelephoneNum.Name = "labelTelephoneNum";
            this.labelTelephoneNum.Size = new System.Drawing.Size(78, 17);
            this.labelTelephoneNum.TabIndex = 28;
            this.labelTelephoneNum.Text = "Nr telefonu";
            this.labelTelephoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(365, 65);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 17);
            this.labelAddress.TabIndex = 25;
            this.labelAddress.Text = "Adres";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(60, 170);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 21;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(60, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Imię";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(215, 97);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(60, 100);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(44, 17);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Hasło";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(215, 62);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 22);
            this.textBoxLogin.TabIndex = 1;
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.pictureBoxQuestionMark);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonAccept);
            this.panelBackground.Controls.Add(this.comboBoxShowroomAssignment);
            this.panelBackground.Controls.Add(this.labelShowroomAssignment);
            this.panelBackground.Controls.Add(this.groupBoxUserRoles);
            this.panelBackground.Controls.Add(this.labelPersonalData);
            this.panelBackground.Controls.Add(this.textBoxEmail);
            this.panelBackground.Controls.Add(this.textBoxTelephoneNum);
            this.panelBackground.Controls.Add(this.textBoxAddress);
            this.panelBackground.Controls.Add(this.textBoxName);
            this.panelBackground.Controls.Add(this.textBoxSurname);
            this.panelBackground.Controls.Add(this.labelEmail);
            this.panelBackground.Controls.Add(this.labelTelephoneNum);
            this.panelBackground.Controls.Add(this.labelAddress);
            this.panelBackground.Controls.Add(this.labelSurname);
            this.panelBackground.Controls.Add(this.labelName);
            this.panelBackground.Controls.Add(this.textBoxPassword);
            this.panelBackground.Controls.Add(this.labelPassword);
            this.panelBackground.Controls.Add(this.textBoxLogin);
            this.panelBackground.Controls.Add(this.labelLogin);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(632, 553);
            this.panelBackground.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(534, 487);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 45;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(453, 487);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 27);
            this.buttonAccept.TabIndex = 44;
            this.buttonAccept.Text = "Akceptuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // comboBoxShowroomAssignment
            // 
            this.comboBoxShowroomAssignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowroomAssignment.FormattingEnabled = true;
            this.comboBoxShowroomAssignment.Location = new System.Drawing.Point(482, 303);
            this.comboBoxShowroomAssignment.Name = "comboBoxShowroomAssignment";
            this.comboBoxShowroomAssignment.Size = new System.Drawing.Size(121, 24);
            this.comboBoxShowroomAssignment.TabIndex = 43;
            // 
            // labelShowroomAssignment
            // 
            this.labelShowroomAssignment.AutoSize = true;
            this.labelShowroomAssignment.Location = new System.Drawing.Point(365, 306);
            this.labelShowroomAssignment.Name = "labelShowroomAssignment";
            this.labelShowroomAssignment.Size = new System.Drawing.Size(111, 17);
            this.labelShowroomAssignment.TabIndex = 42;
            this.labelShowroomAssignment.Text = "Przydział salonu";
            this.labelShowroomAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxUserRoles
            // 
            this.groupBoxUserRoles.AutoSize = true;
            this.groupBoxUserRoles.Controls.Add(this.checkBoxSeller);
            this.groupBoxUserRoles.Controls.Add(this.checkBoxTechnician);
            this.groupBoxUserRoles.Controls.Add(this.checkBoxShowroomManager);
            this.groupBoxUserRoles.Controls.Add(this.checkBoxAdministrator);
            this.groupBoxUserRoles.Location = new System.Drawing.Point(25, 275);
            this.groupBoxUserRoles.Name = "groupBoxUserRoles";
            this.groupBoxUserRoles.Size = new System.Drawing.Size(184, 177);
            this.groupBoxUserRoles.TabIndex = 41;
            this.groupBoxUserRoles.TabStop = false;
            this.groupBoxUserRoles.Text = "Role użytkownika";
            // 
            // checkBoxSeller
            // 
            this.checkBoxSeller.AutoSize = true;
            this.checkBoxSeller.Location = new System.Drawing.Point(25, 135);
            this.checkBoxSeller.Name = "checkBoxSeller";
            this.checkBoxSeller.Size = new System.Drawing.Size(107, 21);
            this.checkBoxSeller.TabIndex = 3;
            this.checkBoxSeller.Text = "Sprzedawca";
            this.checkBoxSeller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSeller.UseVisualStyleBackColor = true;
            // 
            // checkBoxTechnician
            // 
            this.checkBoxTechnician.AutoSize = true;
            this.checkBoxTechnician.Location = new System.Drawing.Point(25, 100);
            this.checkBoxTechnician.Name = "checkBoxTechnician";
            this.checkBoxTechnician.Size = new System.Drawing.Size(91, 21);
            this.checkBoxTechnician.TabIndex = 2;
            this.checkBoxTechnician.Text = "Serwisant";
            this.checkBoxTechnician.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTechnician.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowroomManager
            // 
            this.checkBoxShowroomManager.AutoSize = true;
            this.checkBoxShowroomManager.Location = new System.Drawing.Point(25, 65);
            this.checkBoxShowroomManager.Name = "checkBoxShowroomManager";
            this.checkBoxShowroomManager.Size = new System.Drawing.Size(136, 21);
            this.checkBoxShowroomManager.TabIndex = 1;
            this.checkBoxShowroomManager.Text = "Kierownik salonu";
            this.checkBoxShowroomManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxShowroomManager.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.AutoSize = true;
            this.checkBoxAdministrator.Location = new System.Drawing.Point(25, 30);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(113, 21);
            this.checkBoxAdministrator.TabIndex = 0;
            this.checkBoxAdministrator.Text = "Administrator";
            this.checkBoxAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxAdministrator.UseVisualStyleBackColor = true;
            // 
            // labelPersonalData
            // 
            this.labelPersonalData.AutoSize = true;
            this.labelPersonalData.Location = new System.Drawing.Point(25, 30);
            this.labelPersonalData.Margin = new System.Windows.Forms.Padding(3);
            this.labelPersonalData.Name = "labelPersonalData";
            this.labelPersonalData.Size = new System.Drawing.Size(122, 17);
            this.labelPersonalData.TabIndex = 40;
            this.labelPersonalData.Text = "Dane użytkownika";
            this.labelPersonalData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(60, 65);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(3);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(43, 17);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxQuestionMark
            // 
            this.pictureBoxQuestionMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuestionMark.BackgroundImage")));
            this.pictureBoxQuestionMark.Location = new System.Drawing.Point(586, 13);
            this.pictureBoxQuestionMark.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxQuestionMark.Name = "pictureBoxQuestionMark";
            this.pictureBoxQuestionMark.Size = new System.Drawing.Size(33, 30);
            this.pictureBoxQuestionMark.TabIndex = 78;
            this.pictureBoxQuestionMark.TabStop = false;
            this.pictureBoxQuestionMark.Click += new System.EventHandler(this.pictureBoxQuestionMark_Click);
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 553);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "FormNewUser";
            this.Text = "Nowy użytkownik";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.groupBoxUserRoles.ResumeLayout(false);
            this.groupBoxUserRoles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestionMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelephoneNum;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelephoneNum;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ComboBox comboBoxShowroomAssignment;
        private System.Windows.Forms.Label labelShowroomAssignment;
        private System.Windows.Forms.GroupBox groupBoxUserRoles;
        private System.Windows.Forms.CheckBox checkBoxSeller;
        private System.Windows.Forms.CheckBox checkBoxTechnician;
        private System.Windows.Forms.CheckBox checkBoxShowroomManager;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.Label labelPersonalData;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.PictureBox pictureBoxQuestionMark;
    }
}