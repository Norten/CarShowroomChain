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
    public partial class FormNewCarOrder : Form
    {
        DataGridViewRow client;
        DataGridViewRow car;
        public FormNewCarOrder()
        {
            InitializeComponent();
        }

        private void buttonChooseClient_Click(object sender, EventArgs e)
        {
            FormClientSearch fCS = new FormClientSearch(this.FillClientData);
            fCS.ShowDialog();
        }

        private void buttonChooseCar_Click(object sender, EventArgs e)
        {
            FormCarSearch fCS = new FormCarSearch(this.FillCarData);
            fCS.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillClientData(DataGridViewRow selectedClient) {
            this.client = selectedClient;
            this.textBoxName.Text = selectedClient.Cells[0].Value.ToString();
            this.textBoxSurname.Text = selectedClient.Cells[1].Value.ToString();
            this.textBoxCity.Text = selectedClient.Cells[2].Value.ToString();
            this.textBoxTelephoneNum.Text = selectedClient.Cells[3].Value.ToString();
            this.textBoxEmail.Text = selectedClient.Cells[4].Value.ToString();
        }

        private void FillCarData(DataGridViewRow selectedCar) {
            this.car = selectedCar;
            this.textBoxCarSeries.Text = selectedCar.Cells[0].Value.ToString();
            this.textBoxCarModel.Text = selectedCar.Cells[1].Value.ToString();
            this.textBoxCarColor.Text = selectedCar.Cells[2].Value.ToString();
            this.textBoxEngineVolume.Text = selectedCar.Cells[3].Value.ToString();
            this.textBoxEnginePower.Text = selectedCar.Cells[4].Value.ToString();
            this.textBoxCarFuel.Text = selectedCar.Cells[5].Value.ToString();
            this.textBoxCarGearbox.Text = selectedCar.Cells[6].Value.ToString();
            this.textBoxCarBody.Text = selectedCar.Cells[7].Value.ToString();
            this.textBoxCarPrice.Text = selectedCar.Cells["costDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void SetServices(string comment, UInt64 price) {
            if (this.textBoxComment.Text.Contains("Wybrane usługi/dodatki: ")) {
                var beginIndex = this.textBoxComment.Text.IndexOf("Wybrane usługi/dodatki: ");
                var endIndex = this.textBoxComment.Text.IndexOf("; .") + 3;
                this.textBoxComment.Text = this.textBoxComment.Text.Remove(beginIndex, endIndex - beginIndex);
            }
            this.textBoxComment.Text += comment + ".\n\n";
        }

        private void textBoxServicesPrice_TextChanged(object sender, EventArgs e) {
            this.SetTotalPrice();
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e) {
            if (!String.IsNullOrWhiteSpace(this.textBoxDiscount.Text)) {
                UInt64 val;
                if (UInt64.TryParse(this.textBoxDiscount.Text, out val))
                    this.SetTotalPrice();
                else {
                    this.textBoxDiscount.Text = this.textBoxDiscount.Text.Remove(this.textBoxDiscount.Text.Length - 1);
                }
            }
        }

        private void textBoxCarPrice_TextChanged(object sender, EventArgs e) {
            this.SetTotalPrice();
        }

        private void SetTotalPrice() {
            var carPrice = UInt64.Parse(this.textBoxCarPrice.Text);
            var discount = Double.Parse(this.textBoxDiscount.Text)/100.0;
            var totalPrice = (UInt64)(carPrice * (1 - discount));
            this.textBoxTotalPrice.Text = totalPrice.ToString();
        }

        private void buttonAccept_Click(object sender, EventArgs e) {
            if (this.client != null && this.car != null) {
                var dbModel = new DatabaseModel();
                var newReservation = new reservation();
                newReservation.date_reservation = this.dateTimePickerPurchaseDate.Value;
                newReservation.date_reservation_expired = this.dateTimePickerPurchaseDate.Value.AddDays(14);
                newReservation.id_user = UserSingleton.Instance.userId;
                newReservation.id_client = (int)this.client.Cells["idDataGridViewTextBoxColumn"].Value;
                newReservation.id_car = (int)this.car.Cells["idDataGridViewTextBoxColumn"].Value;
                dbModel.reservation.Add(newReservation);
                dbModel.SaveChanges();
            } else {
                MessageBox.Show("Musisz najpierw wybrać klienta oraz samochód.");
            }
            
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e) {
            MessageBox.Show("Wybierz klienta poprzez wciśnięcie przycisku \"Wybierz klienta\"\n" +
                "Określ date zakupu\n" +
                "Wybierz samochód poprzez wciśnięcie przycisku \"Wybierz samochód\"\n" +
                "Można podać wartość procentową rabatu oraz komentarz");
        }
    }
}
