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
        public FormNewUser()
        {
            InitializeComponent();
            this.dbModel = new DatabaseModel();
            this.LoadData();
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
                var newUser = new user_data();
                var login = this.textBoxLogin.Text;
                var password = this.textBoxPassword.Text;
                var firstName = this.textBoxName.Text;
                var lastName = this.textBoxSurname.Text;
                var address = this.textBoxAddress.Text;
                var phone = this.textBoxTelephoneNum.Text;
                var email = this.textBoxEmail.Text;
                if (String.IsNullOrWhiteSpace(login) || String.IsNullOrWhiteSpace(password) ||
                    String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName) ||
                    String.IsNullOrWhiteSpace(address)) {
                    MessageBox.Show("Nie wszystkie wymagane dane zostały podane.\n" +
                                    "Wymagane dane:\n" +
                                    "Login\n" +
                                    "Hasło\n" +
                                    "Imię\n" +
                                    "Nazwisko\n" +
                                    "Adres\n");
                    return;
                }
                newUser.login = this.textBoxLogin.Text;
                newUser.password = this.textBoxPassword.Text;
                newUser.first_name = this.textBoxName.Text;
                newUser.last_name = this.textBoxSurname.Text;
                newUser.address = this.textBoxAddress.Text;
                newUser.phone = this.textBoxTelephoneNum.Text;
                newUser.email = this.textBoxEmail.Text;
                newUser.id_car_shop = this.keyValCarShop[this.comboBoxShowroomAssignment.Text];
                var dictRole = dbModel.role.SqlQuery("SELECT * FROM role;").ToList();
                if (this.checkBoxAdministrator.Checked)
                    newUser.role.Add(dictRole[3]);
                if (this.checkBoxSeller.Checked)
                    newUser.role.Add(dictRole[1]);
                if (this.checkBoxShowroomManager.Checked)
                    newUser.role.Add(dictRole[0]);
                if (this.checkBoxTechnician.Checked)
                    newUser.role.Add(dictRole[2]);
                newUser.is_active = 0;
                dbModel.user_data.Add(newUser);
                dbModel.SaveChanges();
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }
    }
}
