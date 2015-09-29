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
    public partial class FormNewUser : Form
    {
        DatabaseModel dbModel;
        Dictionary<string, int>
            keyValCarShop = new Dictionary<string, int>(),
            keyValRole = new Dictionary<string, int>();
        int userId;
        public FormNewUser(int userId = -1)
        {
            InitializeComponent();
            this.userId = userId;
            this.dbModel = new DatabaseModel();
            this.LoadData();
            if (this.userId != -1) {
                var result = dbModel.user_data.Find(this.userId);
                if (result != null) {
                    this.textBoxLogin.Text = result.login;
                    this.textBoxPassword.Text = result.password;
                    this.textBoxName.Text = result.first_name;
                    this.textBoxSurname.Text = result.last_name;
                    this.textBoxAddress.Text = result.address;
                    this.textBoxTelephoneNum.Text = result.phone;
                    this.textBoxEmail.Text = result.email;
                    this.comboBoxShowroomAssignment.SelectedIndex = this.comboBoxShowroomAssignment.FindStringExact(result.car_shop.name);
                    foreach (var role in result.role) {
                        if (role.name.Equals("administrator"))
                            this.checkBoxAdministrator.Checked = true;
                        else if (role.name.Equals("sprzedawca"))
                            this.checkBoxSeller.Checked = true;
                        else if (role.name.Equals("serwisant"))
                            this.checkBoxTechnician.Checked = true;
                        else if (role.name.Equals("kierownik salonu"))
                            this.checkBoxShowroomManager.Checked = true;
                    }
                }
            }
        }

        private void LoadData() {
            var dictCarShop = dbModel.car_shop.SqlQuery("SELECT * FROM car_shop;").ToList();
            var listCarShop = new List<string>();
            foreach (var item in dictCarShop) {
                listCarShop.Add(item.name);
                keyValCarShop.Add(item.name, item.id);
            }
            this.comboBoxShowroomAssignment.DataSource = listCarShop;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e) {
            try {
                user_data user;
                if (this.userId == -1) {
                    user = new user_data();
                    user.is_active = 0;
                } else {
                    user = dbModel.user_data.Find(this.userId);
                    user.role.Clear();
                }
                user.login = this.textBoxLogin.Text;
                user.password = this.textBoxPassword.Text;
                user.first_name = this.textBoxName.Text;
                user.last_name = this.textBoxSurname.Text;
                user.address = this.textBoxAddress.Text;
                user.phone = this.textBoxTelephoneNum.Text;
                user.email = this.textBoxEmail.Text;
                if (String.IsNullOrWhiteSpace(user.login) || String.IsNullOrWhiteSpace(user.password) ||
                    String.IsNullOrWhiteSpace(user.first_name) || String.IsNullOrWhiteSpace(user.last_name) ||
                    String.IsNullOrWhiteSpace(user.address)) {
                    MessageBox.Show("Nie wszystkie wymagane dane zostały podane.\n" +
                                    "Wymagane dane:\n" +
                                    "Login\n" +
                                    "Hasło\n" +
                                    "Imię\n" +
                                    "Nazwisko\n" +
                                    "Adres\n");
                    return;
                }
                user.id_car_shop = this.keyValCarShop[this.comboBoxShowroomAssignment.Text];
                var dictRole = dbModel.role.SqlQuery("SELECT * FROM role;").ToList();
                if (this.checkBoxAdministrator.Checked)
                    user.role.Add(dictRole[3]);
                if (this.checkBoxSeller.Checked)
                    user.role.Add(dictRole[1]);
                if (this.checkBoxShowroomManager.Checked)
                    user.role.Add(dictRole[0]);
                if (this.checkBoxTechnician.Checked)
                    user.role.Add(dictRole[2]);
                if (this.userId == -1)
                    dbModel.user_data.Add(user);
                dbModel.SaveChanges();
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e) {
            MessageBox.Show("Wprowadź dane nowego użytkownika.\n" +
                "Wymagane dane:\n" +
                "Login\n" +
                "Hasło\n" +
                "Imię\n" +
                "Nazwisko\n" +
                "Adres\n" +
                "Możesz zdefiniować kilka ról nowego użytkownika");
        }
    }
}
