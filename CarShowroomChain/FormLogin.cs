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
            var dbModel = new DatabaseModel();
            var db = dbModel.user_data.SqlQuery("SELECT * FROM user_data;").ToList();
            var login = textBoxLogin.Text;
            var pass = textBoxPass.Text;
            var resultLogin = db.Find(item => item.login == login);
            var resultPass = db.Find(item => item.password == pass);
            if (resultLogin != null && resultPass != null && resultLogin.id == resultPass.id)
            {
                id_user = resultLogin.id;
                FormMainView fmv = new FormMainView();
                this.Hide();
                fmv.ShowDialog();
                fmv.Activate();           
            } else
            {
                MessageBox.Show("Błędny login lub hasło");
            }
        }

        public int id_user { get; set; }
    }
}
