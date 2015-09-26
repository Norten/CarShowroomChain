namespace CarShowroomChain
{
    partial class FormUsers
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
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonDismiss = new System.Windows.Forms.Button();
            this.buttonHire = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxIDNum = new System.Windows.Forms.TextBox();
            this.labelIDNum = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.buttonFilter);
            this.panelBackground.Controls.Add(this.buttonDismiss);
            this.panelBackground.Controls.Add(this.buttonHire);
            this.panelBackground.Controls.Add(this.buttonModify);
            this.panelBackground.Controls.Add(this.buttonNewUser);
            this.panelBackground.Controls.Add(this.dataGridView1);
            this.panelBackground.Controls.Add(this.textBoxName);
            this.panelBackground.Controls.Add(this.textBoxSurname);
            this.panelBackground.Controls.Add(this.textBoxIDNum);
            this.panelBackground.Controls.Add(this.labelIDNum);
            this.panelBackground.Controls.Add(this.labelSurname);
            this.panelBackground.Controls.Add(this.labelName);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(632, 553);
            this.panelBackground.TabIndex = 0;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.AutoSize = true;
            this.buttonFilter.Location = new System.Drawing.Point(534, 100);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 27);
            this.buttonFilter.TabIndex = 38;
            this.buttonFilter.Text = "Filtruj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // buttonDismiss
            // 
            this.buttonDismiss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDismiss.AutoSize = true;
            this.buttonDismiss.Location = new System.Drawing.Point(534, 487);
            this.buttonDismiss.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonDismiss.Name = "buttonDismiss";
            this.buttonDismiss.Size = new System.Drawing.Size(75, 27);
            this.buttonDismiss.TabIndex = 37;
            this.buttonDismiss.Text = "Zwolnij";
            this.buttonDismiss.UseVisualStyleBackColor = true;
            // 
            // buttonHire
            // 
            this.buttonHire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHire.AutoSize = true;
            this.buttonHire.Location = new System.Drawing.Point(451, 487);
            this.buttonHire.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(77, 27);
            this.buttonHire.TabIndex = 36;
            this.buttonHire.Text = "Zatrudnij";
            this.buttonHire.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModify.AutoSize = true;
            this.buttonModify.Location = new System.Drawing.Point(368, 487);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(77, 27);
            this.buttonModify.TabIndex = 35;
            this.buttonModify.Text = "Modyfikuj";
            this.buttonModify.UseVisualStyleBackColor = true;
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewUser.AutoSize = true;
            this.buttonNewUser.Location = new System.Drawing.Point(232, 487);
            this.buttonNewUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(130, 27);
            this.buttonNewUser.TabIndex = 34;
            this.buttonNewUser.Text = "Nowy użytkownik";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLogin,
            this.ColumnPassword,
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnEmail,
            this.ColumnAddress,
            this.ColumnPhoneNum,
            this.ColumnIsActive});
            this.dataGridView1.Location = new System.Drawing.Point(23, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 309);
            this.dataGridView1.TabIndex = 33;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "Login";
            this.ColumnLogin.Name = "ColumnLogin";
            this.ColumnLogin.ReadOnly = true;
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Password";
            this.ColumnPassword.Name = "ColumnPassword";
            this.ColumnPassword.ReadOnly = true;
            this.ColumnPassword.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Imie";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "Nazwisko";
            this.ColumnSurname.Name = "ColumnSurname";
            this.ColumnSurname.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "E-mail";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Adres";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnPhoneNum
            // 
            this.ColumnPhoneNum.HeaderText = "Nr telefonu";
            this.ColumnPhoneNum.Name = "ColumnPhoneNum";
            this.ColumnPhoneNum.ReadOnly = true;
            // 
            // ColumnIsActive
            // 
            this.ColumnIsActive.HeaderText = "Aktywność";
            this.ColumnIsActive.Name = "ColumnIsActive";
            this.ColumnIsActive.ReadOnly = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(249, 27);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 30;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(249, 62);
            this.textBoxSurname.MaxLength = 50;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxSurname.TabIndex = 31;
            // 
            // textBoxIDNum
            // 
            this.textBoxIDNum.Location = new System.Drawing.Point(249, 97);
            this.textBoxIDNum.MaxLength = 9;
            this.textBoxIDNum.Name = "textBoxIDNum";
            this.textBoxIDNum.Size = new System.Drawing.Size(100, 22);
            this.textBoxIDNum.TabIndex = 32;
            // 
            // labelIDNum
            // 
            this.labelIDNum.AutoSize = true;
            this.labelIDNum.Location = new System.Drawing.Point(25, 100);
            this.labelIDNum.Name = "labelIDNum";
            this.labelIDNum.Size = new System.Drawing.Size(218, 17);
            this.labelIDNum.TabIndex = 22;
            this.labelIDNum.Text = "Seria i numer dowodu osobistego";
            this.labelIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(25, 65);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 21;
            this.labelSurname.Text = "Nazwisko";
            this.labelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Imię";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 553);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "FormUsers";
            this.Text = "Użytkownicy";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxIDNum;
        private System.Windows.Forms.Label labelIDNum;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsActive;
        private System.Windows.Forms.Button buttonDismiss;
        private System.Windows.Forms.Button buttonHire;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Button buttonFilter;
    }
}