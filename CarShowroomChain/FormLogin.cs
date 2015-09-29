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
                if (resultLogin.is_active == 1)
                {
                    UserSingleton.Instance.userId = resultLogin.id;
                    FormMainView fmv = new FormMainView();
                    this.Hide();
                    fmv.ShowDialog();
                    fmv.Activate();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Jesteś nieaktywnym użytkownikiem.\nSkontaktuj się z administratorem systemu.");
                }
            } else
            {
                MessageBox.Show("Błędny login lub hasło.");
            }
        }

        private void textBoxPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                this.buttonLogin_Click(new object(), new EventArgs());
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wpisz poprawny login i hasło aby wejść do systemu.");
        }

    }
}
