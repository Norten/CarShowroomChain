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

        private void FillCarData(DataGridViewRow selectedCar) {
            this.comboBoxSeries.SelectedIndex = this.comboBoxSeries.FindStringExact(selectedCar.Cells[0].Value.ToString());
            this.comboBoxModel.SelectedIndex = this.comboBoxModel.FindStringExact(selectedCar.Cells[1].Value.ToString());
            this.comboBoxColour.SelectedIndex = this.comboBoxColour.FindStringExact(selectedCar.Cells[2].Value.ToString());
            this.textBoxEngineVolume.Text = selectedCar.Cells[3].Value.ToString();
            this.textBoxEnginePower.Text = selectedCar.Cells[4].Value.ToString();
            this.comboBoxFuel.SelectedIndex = this.comboBoxFuel.FindStringExact(selectedCar.Cells[5].Value.ToString());
            this.comboBoxGearBox.SelectedIndex = this.comboBoxGearBox.FindStringExact(selectedCar.Cells[6].Value.ToString());
            this.comboBoxCarBody.SelectedIndex = this.comboBoxCarBody.FindStringExact(selectedCar.Cells[7].Value.ToString());
        }

        private void SetServices(string comment, UInt64 price) {

        }
    }
}
