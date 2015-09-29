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
    public partial class FormCarSearch : Form
    {
        DataGridViewRow row;
        Action<DataGridViewRow> SelectCar;
        public FormCarSearch(Action<DataGridViewRow> SelectCar = null)
        {
            InitializeComponent();
            this.SelectCar = SelectCar;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCarSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'polsl_agatek_bdDataSet1.full_car' table. You can move, or remove it, as needed.
            this.full_carTableAdapter.Fill(this.polsl_agatek_bdDataSet1.full_car);

        }

        private void dataGridViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = this.dataGridViewCar.Rows[e.RowIndex];
        }

        private void buttonChoose_Click(object sender, EventArgs e) 
        {
            if (this.SelectCar == null) //?
            {
                this.Close();
                return;
            }
            if (row != null) 
            {
                this.SelectCar(row);
                this.Close();
                return;
            } else
                MessageBox.Show("Musisz najpierw wybrać samochód.");
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var model = this.comboBoxModel.Text;
            /*
            var name = this.textBoxName.Text;
            var surname = this.textBoxSurname.Text;
            var dbModel = new DatabaseModel();
            string wherePart = " WHERE";
            if (!String.IsNullOrWhiteSpace(name))
                wherePart += " first_name like '" + name + "'";
            if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(surname))
                wherePart += " AND";
            if (!String.IsNullOrWhiteSpace(surname))
                wherePart += " last_name like '" + surname + "'";
            if (wherePart.Equals(" WHERE"))
                wherePart = "";
            var db = dbModel.client.SqlQuery("SELECT * FROM client" + wherePart + ";").ToList();
            var source = new BindingSource();
            source.DataSource = db;
            this.dataGridViewClients.DataSource = source;*/
        }




    }
}
