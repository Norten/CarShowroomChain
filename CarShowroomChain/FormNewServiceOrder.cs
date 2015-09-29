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
    public partial class FormNewServiceOrder : Form
    {
        public FormNewServiceOrder()
        {
            InitializeComponent();
        }

        private void buttonChooseClient_Click(object sender, EventArgs e)
        {
            FormClientSearch fCS = new FormClientSearch(this.FillClientData);
            fCS.ShowDialog();
        }

        private void buttonChooseAdditionalOptions_Click(object sender, EventArgs e)
        {
            FormServiceOptions fSO = new FormServiceOptions(this.SetServices);
            fSO.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillClientData(DataGridViewRow selectedClient) {
            this.textBoxName.Text = selectedClient.Cells[0].Value.ToString();
            this.textBoxSurname.Text = selectedClient.Cells[1].Value.ToString();
            this.textBoxCity.Text = selectedClient.Cells[2].Value.ToString();
            this.textBoxTelephoneNum.Text = selectedClient.Cells[3].Value.ToString();
            this.textBoxEmail.Text = selectedClient.Cells[4].Value.ToString();
        }

        private void SetServices(string comment, UInt64 price) {
            if (this.textBoxComment.Text.Contains("Wybrane usługi/dodatki: ")) {
                var beginIndex = this.textBoxComment.Text.IndexOf("Wybrane usługi/dodatki: ");
                var endIndex = this.textBoxComment.Text.IndexOf("; .") + 3;
                this.textBoxComment.Text = this.textBoxComment.Text.Remove(beginIndex, endIndex - beginIndex);
            }
            this.textBoxComment.Text += comment + ".\n\n";
            this.textBoxServicesPrice.Text = price.ToString();
        }

        private void textBoxServicesPrice_TextChanged(object sender, EventArgs e) {
            var price = UInt64.Parse(this.textBoxServicesPrice.Text);
            var discount = Double.Parse(this.textBoxDiscount.Text)/100.0;
            var totalPrice = (UInt64)(price * (1 - discount));
            this.textBoxTotalPrice.Text = totalPrice.ToString();
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e) {
            if(!String.IsNullOrWhiteSpace(this.textBoxDiscount.Text)){
                UInt64 val;
                if (UInt64.TryParse(this.textBoxDiscount.Text, out val))
                    this.textBoxServicesPrice_TextChanged(new object(), new EventArgs());
                else {
                    this.textBoxDiscount.Text = this.textBoxDiscount.Text.Remove(this.textBoxDiscount.Text.Length - 1);
                }
                    
            }
        }
    }
}
