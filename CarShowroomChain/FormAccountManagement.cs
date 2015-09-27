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

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int user_id = UserSingleton.Instance.userId;
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;
            var newPass1 = textBoxNewPassword1.Text;
            var newPass2 = textBoxNewPassword2.Text;
            if (newPass1 == newPass2)
            {
                var dbModel = new DatabaseModel();
                var db = dbModel.user_data.SqlQuery("SELECT * FROM user_data;").ToList();
                var resultLogin = db.Find(item => item.login == login);
                var resultPass = db.Find(item => item.password == pass);
                if (resultLogin != null && resultPass != null)
                {
                    if (login == resultLogin.login && pass == resultPass.password && resultLogin.id == resultPass.id && user_id == resultLogin.id)
                    {
                        dbModel.user_data.SqlQuery("UPDATE user_data SET password = '" + newPass1 + "' WHERE id = " + user_id + ";");
                        this.Hide();
                    } 
                    else
                    {
                        MessageBox.Show("Osoba zalogowana może zmienić hasło tylko sobie.");
                    }
                }
                else
                {
                    MessageBox.Show("Błędny login lub hasło.");
                }
            }
            else
            {
                MessageBox.Show("Nowe hasło w obu polach musi być jednakowe.");
            }

        }
    }
}
