namespace CarShowroomChain
{
    partial class FormNewCar
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
            this.comboBoxSeries = new System.Windows.Forms.ComboBox();
            this.labelSeries = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxColour = new System.Windows.Forms.ComboBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCarBody = new System.Windows.Forms.ComboBox();
            this.comboBoxGearBox = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCarBody = new System.Windows.Forms.Label();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.textBoxEnginePower = new System.Windows.Forms.TextBox();
            this.textBoxEngineVolume = new System.Windows.Forms.TextBox();
            this.labelGearBox = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelEnginePower = new System.Windows.Forms.Label();
            this.labelEngineVolume = new System.Windows.Forms.Label();
            this.labelColour = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.comboBoxSeries);
            this.panelBackground.Controls.Add(this.labelSeries);
            this.panelBackground.Controls.Add(this.comboBoxModel);
            this.panelBackground.Controls.Add(this.comboBoxColour);
            this.panelBackground.Controls.Add(this.buttonAccept);
            this.panelBackground.Controls.Add(this.buttonCancel);
            this.panelBackground.Controls.Add(this.textBoxPrice);
            this.panelBackground.Controls.Add(this.comboBoxCarBody);
            this.panelBackground.Controls.Add(this.comboBoxGearBox);
            this.panelBackground.Controls.Add(this.labelPrice);
            this.panelBackground.Controls.Add(this.labelCarBody);
            this.panelBackground.Controls.Add(this.comboBoxFuel);
            this.panelBackground.Controls.Add(this.textBoxEnginePower);
            this.panelBackground.Controls.Add(this.textBoxEngineVolume);
            this.panelBackground.Controls.Add(this.labelGearBox);
            this.panelBackground.Controls.Add(this.labelFuel);
            this.panelBackground.Controls.Add(this.labelEnginePower);
            this.panelBackground.Controls.Add(this.labelEngineVolume);
            this.panelBackground.Controls.Add(this.labelColour);
            this.panelBackground.Controls.Add(this.labelModel);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(632, 303);
            this.panelBackground.TabIndex = 0;
            // 
            // comboBoxSeries
            // 
            this.comboBoxSeries.FormattingEnabled = true;
            this.comboBoxSeries.Location = new System.Drawing.Point(151, 27);
            this.comboBoxSeries.Name = "comboBoxSeries";
            this.comboBoxSeries.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSeries.TabIndex = 19;
            // 
            // labelSeries
            // 
            this.labelSeries.AutoSize = true;
            this.labelSeries.Location = new System.Drawing.Point(25, 30);
            this.labelSeries.Name = "labelSeries";
            this.labelSeries.Size = new System.Drawing.Size(41, 17);
            this.labelSeries.TabIndex = 18;
            this.labelSeries.Text = "Seria";
            this.labelSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(151, 62);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxModel.TabIndex = 6;
            // 
            // comboBoxColour
            // 
            this.comboBoxColour.FormattingEnabled = true;
            this.comboBoxColour.Location = new System.Drawing.Point(151, 97);
            this.comboBoxColour.Name = "comboBoxColour";
            this.comboBoxColour.Size = new System.Drawing.Size(121, 24);
            this.comboBoxColour.TabIndex = 7;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.AutoSize = true;
            this.buttonAccept.Location = new System.Drawing.Point(453, 257);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 27);
            this.buttonAccept.TabIndex = 16;
            this.buttonAccept.Text = "Akceptuj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(534, 257);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 27);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(456, 132);
            this.textBoxPrice.MaxLength = 50;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 15;
            // 
            // comboBoxCarBody
            // 
            this.comboBoxCarBody.FormattingEnabled = true;
            this.comboBoxCarBody.Location = new System.Drawing.Point(456, 97);
            this.comboBoxCarBody.Name = "comboBoxCarBody";
            this.comboBoxCarBody.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCarBody.TabIndex = 14;
            // 
            // comboBoxGearBox
            // 
            this.comboBoxGearBox.FormattingEnabled = true;
            this.comboBoxGearBox.Location = new System.Drawing.Point(456, 62);
            this.comboBoxGearBox.Name = "comboBoxGearBox";
            this.comboBoxGearBox.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGearBox.TabIndex = 13;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(340, 135);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 17);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Cena";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCarBody
            // 
            this.labelCarBody.AutoSize = true;
            this.labelCarBody.Location = new System.Drawing.Point(340, 100);
            this.labelCarBody.Name = "labelCarBody";
            this.labelCarBody.Size = new System.Drawing.Size(69, 17);
            this.labelCarBody.TabIndex = 11;
            this.labelCarBody.Text = "Nadwozie";
            this.labelCarBody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Location = new System.Drawing.Point(456, 27);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFuel.TabIndex = 10;
            // 
            // textBoxEnginePower
            // 
            this.textBoxEnginePower.Location = new System.Drawing.Point(151, 167);
            this.textBoxEnginePower.MaxLength = 50;
            this.textBoxEnginePower.Name = "textBoxEnginePower";
            this.textBoxEnginePower.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnginePower.TabIndex = 9;
            // 
            // textBoxEngineVolume
            // 
            this.textBoxEngineVolume.Location = new System.Drawing.Point(151, 132);
            this.textBoxEngineVolume.MaxLength = 15;
            this.textBoxEngineVolume.Name = "textBoxEngineVolume";
            this.textBoxEngineVolume.Size = new System.Drawing.Size(100, 22);
            this.textBoxEngineVolume.TabIndex = 8;
            // 
            // labelGearBox
            // 
            this.labelGearBox.AutoSize = true;
            this.labelGearBox.Location = new System.Drawing.Point(340, 65);
            this.labelGearBox.Name = "labelGearBox";
            this.labelGearBox.Size = new System.Drawing.Size(110, 17);
            this.labelGearBox.TabIndex = 5;
            this.labelGearBox.Text = "Skrzynia biegów";
            this.labelGearBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(340, 30);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(48, 17);
            this.labelFuel.TabIndex = 4;
            this.labelFuel.Text = "Paliwo";
            this.labelFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEnginePower
            // 
            this.labelEnginePower.AutoSize = true;
            this.labelEnginePower.Location = new System.Drawing.Point(25, 170);
            this.labelEnginePower.Name = "labelEnginePower";
            this.labelEnginePower.Size = new System.Drawing.Size(77, 17);
            this.labelEnginePower.TabIndex = 3;
            this.labelEnginePower.Text = "Moc silnika";
            this.labelEnginePower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEngineVolume
            // 
            this.labelEngineVolume.AutoSize = true;
            this.labelEngineVolume.Location = new System.Drawing.Point(25, 135);
            this.labelEngineVolume.Name = "labelEngineVolume";
            this.labelEngineVolume.Size = new System.Drawing.Size(120, 17);
            this.labelEngineVolume.TabIndex = 2;
            this.labelEngineVolume.Text = "Pojemność silnika";
            this.labelEngineVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Location = new System.Drawing.Point(25, 100);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(41, 17);
            this.labelColour.TabIndex = 1;
            this.labelColour.Text = "Kolor";
            this.labelColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(25, 65);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(46, 17);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "Model";
            this.labelModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.panelBackground);
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "FormNewCar";
            this.Text = "Nowy samochód";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelEnginePower;
        private System.Windows.Forms.Label labelEngineVolume;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.TextBox textBoxEnginePower;
        private System.Windows.Forms.TextBox textBoxEngineVolume;
        private System.Windows.Forms.Label labelGearBox;
        private System.Windows.Forms.Label labelCarBody;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxCarBody;
        private System.Windows.Forms.ComboBox comboBoxGearBox;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxColour;
        private System.Windows.Forms.ComboBox comboBoxSeries;
        private System.Windows.Forms.Label labelSeries;
    }
}