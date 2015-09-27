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
    public partial class FormClientSearch : Form
    {
        public FormClientSearch()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormNewClient fNC = new FormNewClient();
            fNC.ShowDialog();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            FormNewClient fNC = new FormNewClient();
            fNC.ShowDialog();
        }

        private void FormClientSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'polsl_agatek_bdDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.polsl_agatek_bdDataSet.client);

        }
    }
}
