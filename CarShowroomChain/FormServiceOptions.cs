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
    public partial class FormServiceOptions : Form
    {
        Action<ListBox.ObjectCollection, decimal> SetServices;
        public FormServiceOptions(Action<ListBox.ObjectCollection, decimal> SetServices)
        {
            InitializeComponent();
            this.SetServices = SetServices;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormServiceOptions_Load(object sender, EventArgs e) {
            var dbModel = new DatabaseModel();
            var services = dbModel.dict_service.SqlQuery("SELECT * FROM dict_service;").ToList();
            foreach (var service in services) {
                this.listBoxAvailableOptions.Items.Add(service.name);
                this.listBoxPriceAvailable.Items.Add(service.cost);
            }
        }

        private void buttonChoose_Click(object sender, EventArgs e) {
            if (this.listBoxAvailableOptions.SelectedIndex != -1) {
                var selectedItem = this.listBoxAvailableOptions.SelectedItem;
                var selectedPrice = this.listBoxPriceAvailable.SelectedItem;
                this.listBoxChoosen.Items.Add(selectedItem);
                this.listBoxPriceChoosen.Items.Add(selectedPrice);
                this.listBoxAvailableOptions.Items.Remove(selectedItem);
                this.listBoxPriceAvailable.Items.Remove(selectedPrice);
            }
        }

        private void listBoxAvailableOptions_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.listBoxPriceAvailable.SelectedIndex != this.listBoxAvailableOptions.SelectedIndex)
                this.listBoxPriceAvailable.SelectedIndex = this.listBoxAvailableOptions.SelectedIndex;
        }

        private void listBoxPriceAvailable_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.listBoxPriceAvailable.SelectedIndex != this.listBoxAvailableOptions.SelectedIndex)
                this.listBoxAvailableOptions.SelectedIndex = this.listBoxPriceAvailable.SelectedIndex;
        }

        private void listBoxChoosen_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.listBoxPriceChoosen.SelectedIndex != this.listBoxChoosen.SelectedIndex)
                this.listBoxPriceChoosen.SelectedIndex = this.listBoxChoosen.SelectedIndex;
        }

        private void listBoxPriceChoosen_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.listBoxPriceChoosen.SelectedIndex != this.listBoxChoosen.SelectedIndex)
                this.listBoxChoosen.SelectedIndex = this.listBoxPriceChoosen.SelectedIndex;
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            if (this.listBoxChoosen.SelectedIndex != -1) {
                var selectedItem = this.listBoxChoosen.SelectedItem;
                var selectedPrice = this.listBoxPriceChoosen.SelectedItem;
                this.listBoxAvailableOptions.Items.Add(selectedItem);
                this.listBoxPriceAvailable.Items.Add(selectedPrice);
                this.listBoxChoosen.Items.Remove(selectedItem);
                this.listBoxPriceChoosen.Items.Remove(selectedPrice);
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e) {
            decimal price = 0;
            foreach (string servicePrice in this.listBoxPriceChoosen.Items)
                price += Decimal.Parse(servicePrice);
            var comment = "Wybrane usługi/dodatki: ";
            for (int i=0; i<this.listBoxChoosen.Items.Count && i<this.listBoxPriceChoosen.Items.Count; ++i)
                comment += this.listBoxChoosen.Items[i] + ", cena: " + this.listBoxPriceChoosen.Items[i] + "; ";
            this.SetServices(this.listBoxChoosen.Items, price);
            this.Close();
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e) {
            MessageBox.Show("Po lewej stronie znajdują się opcje dostępne w ofercie.\n" +
                "Aby wybrać usługi i/lub dodatki musisz wybrać interesujący element oraz kliknąć przycisk" + 
                "\"Wybierz\".\n" +
                "Po prawej stronie znajdują się wybrane dodatki/usługi. Elementy te również można" +
                "usunąć poprzez wybranie odpowiedniego elementu i wciśnięcie przycisku \"Usuń\".");
        }
    }
}
