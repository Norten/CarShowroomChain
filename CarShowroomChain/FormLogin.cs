using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var dbConnection = new DBConnection();
            var login = textBoxLogin;
            var pass = textBoxPass;
            dbConnection.OpenConnection();
            
            dbConnection.CloseConnection();
            FormMainView fmv = new FormMainView();
            this.Hide();
            fmv.ShowDialog();
            fmv.Activate();

        }
    }
}
