using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroomChain {
    public partial class FormClientModify : Form {
        int clientId;
        public FormClientModify(int id) {
            clientId = id;
            InitializeComponent();
            var dbModel = new DatabaseModel();
            var result = dbModel.client.Find(clientId);
            if (result != null)
            {
                this.textBoxName.Text = result.first_name;
                this.textBoxSurname.Text = result.last_name;
                this.textBoxAddress.Text = result.address;
                this.textBoxTelephoneNum.Text = result.phone;
                this.textBoxEmail.Text = result.email;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            var dbModel = new DatabaseModel();
            var result = dbModel.client.Find(clientId);
            if (result != null)
            {
                result.first_name = this.textBoxName.Text;
                result.last_name = this.textBoxSurname.Text;
                result.address = this.textBoxAddress.Text;
                result.phone = this.textBoxTelephoneNum.Text;
                result.email = this.textBoxEmail.Text;
                dbModel.SaveChanges();
                this.Close();
            }
        }
    }
}
