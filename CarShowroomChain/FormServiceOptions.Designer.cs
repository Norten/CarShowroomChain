namespace CarShowroomChain
{
    partial class FormServiceOptions
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
            this.labelChoosen = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.listBoxChoosen = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.labelAvailableOptions = new System.Windows.Forms.Label();
            this.listBoxAvailableOptions = new System.Windows.Forms.ListBox();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.labelChoosen);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.buttonAccept);
            this.panelBackground.Controls.Add(this.listBoxChoosen);
            this.panelBackground.Controls.Add(this.buttonDelete);
            this.panelBackground.Controls.Add(this.buttonChoose);
            this.panelBackground.Controls.Add(this.labelAvailableOptions);
            this.panelBackground.Controls.Add(this.listBoxAvailableOptions);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(565, 454);
            this.panelBackground.TabIndex = 0;
            // 
            // labelChoosen
            // 
            this.labelChoosen.AutoSize = true;
            this.labelChoosen.Location = new System.Drawing.Point(324, 30);
            this.labelChoosen.Margin = new System.Windows.Forms.Padding(3);
            this.labelChoosen.Name = "labelChoosen";
            this.labelChoosen.Size = new System.Drawing.Size(65, 17);
            this.labelChoosen.TabIndex = 7;
            this.labelChoosen.Text = "Wybrane";
            this.labelChoosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(467, 388);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(386, 388);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 27);
            this.buttonAccept.TabIndex = 5;
            this.buttonAccept.Text = "Akceptuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // listBoxChoosen
            // 
            this.listBoxChoosen.FormattingEnabled = true;
            this.listBoxChoosen.ItemHeight = 16;
            this.listBoxChoosen.Location = new System.Drawing.Point(327, 53);
            this.listBoxChoosen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 75);
            this.listBoxChoosen.Name = "listBoxChoosen";
            this.listBoxChoosen.Size = new System.Drawing.Size(215, 324);
            this.listBoxChoosen.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.Location = new System.Drawing.Point(246, 86);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 27);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonChoose
            // 
            this.buttonChoose.AutoSize = true;
            this.buttonChoose.Location = new System.Drawing.Point(246, 53);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 27);
            this.buttonChoose.TabIndex = 2;
            this.buttonChoose.Text = "Wybierz";
            this.buttonChoose.UseVisualStyleBackColor = true;
            // 
            // labelAvailableOptions
            // 
            this.labelAvailableOptions.AutoSize = true;
            this.labelAvailableOptions.Location = new System.Drawing.Point(25, 30);
            this.labelAvailableOptions.Margin = new System.Windows.Forms.Padding(3);
            this.labelAvailableOptions.Name = "labelAvailableOptions";
            this.labelAvailableOptions.Size = new System.Drawing.Size(116, 17);
            this.labelAvailableOptions.TabIndex = 1;
            this.labelAvailableOptions.Text = "Lista opcji i usług";
            this.labelAvailableOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxAvailableOptions
            // 
            this.listBoxAvailableOptions.FormattingEnabled = true;
            this.listBoxAvailableOptions.ItemHeight = 16;
            this.listBoxAvailableOptions.Location = new System.Drawing.Point(25, 53);
            this.listBoxAvailableOptions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 75);
            this.listBoxAvailableOptions.Name = "listBoxAvailableOptions";
            this.listBoxAvailableOptions.Size = new System.Drawing.Size(215, 324);
            this.listBoxAvailableOptions.TabIndex = 0;
            // 
            // FormServiceOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 454);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormServiceOptions";
            this.Text = "Opcje serwisowe ";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.ListBox listBoxChoosen;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label labelAvailableOptions;
        private System.Windows.Forms.ListBox listBoxAvailableOptions;
        private System.Windows.Forms.Label labelChoosen;
    }
}