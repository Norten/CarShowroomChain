﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroomChain
{
    public partial class FormAccountManagement : Form
    {
        public FormAccountManagement()
        {
            InitializeComponent();
            this.panel2BackgroundLogin.Visible = false;
        }

        private void buttonLoginData_Click(object sender, EventArgs e)
        {
            this.panel2BackgroundLogin.Visible = true;
        }

        private void buttonPersonalData_Click(object sender, EventArgs e)
        {
            this.panel2BackgroundLogin.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
