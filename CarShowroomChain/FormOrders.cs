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
    public partial class FormOrders : Form
    {
        DataGridViewRow row;
        public FormOrders()
        {
            InitializeComponent(); 
        }

        private void buttonNewCarOrder_Click(object sender, EventArgs e)
        {
            FormNewCarOrder fNCO = new FormNewCarOrder();
            fNCO.ShowDialog();
        }

        private void buttonNewServiceOrder_Click(object sender, EventArgs e)
        {
            FormNewServiceOrder fNSO = new FormNewServiceOrder();
            fNSO.ShowDialog();
        }

        private void FormOrders_Load(object sender, EventArgs e) 
        {
            // TODO: This line of code loads data into the 'polsl_agatek_bdDataSet2.full_reservation' table. You can move, or remove it, as needed.
            this.full_reservationTableAdapter.Fill(this.polsl_agatek_bdDataSet2.full_reservation);

        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            var dbModel = new DatabaseModel();
            var name = this.textBoxName.Text;
            var surname = this.textBoxSurname.Text;
            var next = false;
            string wherePart = " WHERE";
            if (!String.IsNullOrWhiteSpace(name)) {
                wherePart += " first_name like '" + name + "'";
                next = true;
            }
            if (!String.IsNullOrWhiteSpace(surname)) {
                if (next) wherePart += " AND";
                wherePart += " last_name like '" + surname + "'";
            }
            if (wherePart.Equals(" WHERE"))
                wherePart = "";
            var db = dbModel.full_reservation.SqlQuery("SELECT * FROM full_reservation" + wherePart + ";").ToList();
            var source = new BindingSource();
            source.DataSource = db;
            this.dataGridViewOrders.DataSource = source;
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e) {
            row = this.dataGridViewOrders.Rows[e.RowIndex];
        }

        private void buttonRealize_Click(object sender, EventArgs e) {
            if(row != null){
                var dbModel = new DatabaseModel();
                var reservation = dbModel.reservation.Find((int)row.Cells["idDataGridViewTextBoxColumn"].Value);
                var carSell = new car_sell();
                carSell.id_car = reservation.id_car;
                carSell.id_client = reservation.id_client;
                carSell.id_user = UserSingleton.Instance.userId;
                carSell.sell_date = DateTime.Now;
                carSell.cost = Decimal.Parse(dbModel.car.Find(carSell.id_car).cost);
                dbModel.car_sell.Add(carSell);
                dbModel.reservation.Remove(reservation);
                dbModel.SaveChanges();
                this.buttonFilter_Click(new object(), new EventArgs());
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            if(row != null){
                var dbModel = new DatabaseModel();
                var reservation = dbModel.reservation.Find((int)row.Cells["idDataGridViewTextBoxColumn"].Value);
                dbModel.reservation.Remove(reservation);
                dbModel.SaveChanges();
                this.buttonFilter_Click(new object(), new EventArgs());
            }
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e) {
            MessageBox.Show("W tabelce są wyświetlane aktualne rezerwacje samochodów.\n" + 
                "Możesz zawęzić wyniki wyszukiwania poprzez wytypowanie imienia i/lub nazwiska klienta.\n" + 
                "Aby ponownie wyświetlić wszystkie rezerwacje wyczyść wszystkie warunki " + 
                "i kliknij przycisk 'Filtruj'.\n" + 
                "Gdy klikniesz na konkretną rezerwację w tabelce, możesz kliknąć w przycisk 'Realizuj' lub 'Wycofaj'.\n" + 
                "Realizacja rezerwacji oznacza zakup samochodu, natomiast jej wycofanie anulowanie rezerwacji.\n" +
                "Gdy klikniesz w przycisk 'Nowe zamówienie usługi' będziesz mógł sprzedać usługę lub dodatek.\n" +
                "Gdy klikniesz w przycisk 'Nowe zamówienie samochodu' przejdziesz do okienka sprzedaży samochodu.");
        }
    }
}
