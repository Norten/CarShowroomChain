using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShowroomChain
{
    public partial class FormNewClient : Form
    {
        public FormNewClient()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            var newClient = new client();
            newClient.first_name = this.textBoxName.Text;
            newClient.last_name = this.textBoxSurname.Text;
            newClient.address = this.textBoxAddress.Text;
            newClient.phone = this.textBoxTelephoneNum.Text;
            newClient.email = this.textBoxEmail.Text;
            var dbModel = new DatabaseModel();
            dbModel.client.Add(newClient);
            dbModel.SaveChanges();
            this.Close();
            
        }
    }
}
