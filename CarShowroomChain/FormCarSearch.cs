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
            loadData();
        }
        public void loadData ()
        {
            DatabaseModel dbModel = new DatabaseModel();
            var dictBody = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();
            var dictColor = dbModel.dict_color.SqlQuery("SELECT * FROM dict_color;").ToList();
            var dictEngine = dbModel.dict_engine.SqlQuery("SELECT * FROM dict_engine;").ToList();
            var dictFuel = dbModel.dict_fuel.SqlQuery("SELECT * FROM dict_fuel;").ToList();
            var dictGearbox = dbModel.dict_gearbox.SqlQuery("SELECT * FROM dict_gearbox;").ToList();
            var dictSeries = dbModel.dict_series.SqlQuery("SELECT * FROM dict_series;").ToList();
            var dictModel = dbModel.model.SqlQuery("SELECT * FROM model;").ToList();
            var dictShop = dbModel.car_shop.SqlQuery("SELECT * FROM car_shop;").ToList();
            var listBody = new List<string>();
            var listColor = new List<string>();
            var listEngine = new List<string>();
            var listFuel = new List<string>();
            var listGearbox = new List<string>();
            var listSeries = new List<string>();
            var listModel = new List<string>();
            var listShop = new List<string>();
            listBody.Add("");
            listColor.Add("");
            listEngine.Add("");
            listFuel.Add("");
            listGearbox.Add("");
            listSeries.Add("");
            listModel.Add("");
            listShop.Add("");
            foreach (dict_body item in dictBody) { listBody.Add(item.body); }
            foreach (dict_color item in dictColor) { listColor.Add(item.color); }
            foreach (dict_engine item in dictEngine) { listEngine.Add(item.engine); }
            foreach (dict_fuel item in dictFuel) { listFuel.Add(item.fuel); }
            foreach (dict_gearbox item in dictGearbox) { listGearbox.Add(item.gearbox); }
            foreach (dict_series item in dictSeries) { listSeries.Add(item.series); }
            foreach (model item in dictModel) { listModel.Add(item.name); }
            foreach (car_shop item in dictShop) { listShop.Add(item.name); }
            this.comboBoxCarBody.DataSource = listBody;
            this.comboBoxColor.DataSource = listColor;
            this.comboBoxEngine.DataSource = listEngine;
            this.comboBoxFuel.DataSource = listFuel;
            this.comboBoxGearbox.DataSource = listGearbox;
            this.comboBoxSeries.DataSource = listSeries;
            this.comboBoxModel.DataSource = listModel;
            this.comboBoxShop.DataSource = listShop;
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

        private void maskedTextBoxPriceFrom_MouseDown(object sender, MouseEventArgs e)
        {
            maskedTextBoxPriceFrom.SelectionStart = 0;
        }

        private void maskedTextBoxPriceTo_MouseDown(object sender, MouseEventArgs e)
        {
            maskedTextBoxPriceTo.SelectionStart = 0;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var dbModel = new DatabaseModel();
            var model = this.comboBoxModel.Text;
            var series = this.comboBoxSeries.Text;
            var color = this.comboBoxColor.Text;
            var engine = this.comboBoxEngine.Text;
            var gearbox = this.comboBoxGearbox.Text;
            var fuel = this.comboBoxFuel.Text;
            var body = this.comboBoxCarBody.Text;
            var priceF = this.maskedTextBoxPriceFrom.Text;
            var priceT = this.maskedTextBoxPriceTo.Text;
            var priceFrom = 0; 
            Int32.TryParse(priceF, out priceFrom);
            var priceTo = 0; 
            Int32.TryParse(priceT, out priceTo);
            var shop = this.comboBoxShop.Text;
            var next = false;
            string wherePart = " WHERE";
            if (!String.IsNullOrWhiteSpace(model))
            {
                wherePart += " model like '" + model + "'";
                next = true;
            }
            if (!String.IsNullOrWhiteSpace(series)) 
            {
                if (next) wherePart += " AND";
                wherePart += " series like '" + series + "'";
                next = true;
            }  
            if (!String.IsNullOrWhiteSpace(color))
            {
                if (next) wherePart += " AND";
                wherePart += " color like '" + color + "'";
                next = true;
            } 
            if (!String.IsNullOrWhiteSpace(engine))
            {
                if (next) wherePart += " AND";
                wherePart += " engine like '" + engine + "'";
                next = true;
            }
            if (!String.IsNullOrWhiteSpace(gearbox))
            {
                if (next) wherePart += " AND";
                wherePart += " gearbox like '" + gearbox + "'";
                next = true;
            }
            if (!String.IsNullOrWhiteSpace(fuel))
            {
                if (next) wherePart += " AND";
                wherePart += " fuel like '" + fuel + "'";
                next = true;
            }
            if (!String.IsNullOrWhiteSpace(body))
            {
                if (next) wherePart += " AND";
                wherePart += " body like '" + body + "'";
                next = true;
            }
            if (!String.IsNullOrWhiteSpace(priceF))
            {
                if (next) wherePart += " AND";
                wherePart += " cost > " + priceFrom;
                next = true;
            }
            if (!String.IsNullOrWhiteSpace(priceT))
            {
                if (next) wherePart += " AND";
                wherePart += " cost > " + priceTo;
                next = true;
            }
            if (!String.IsNullOrWhiteSpace(shop))
            {
                if (next) wherePart += " AND";
                wherePart += " name like '" + shop + "'";
                next = true;
            }
            if (wherePart.Equals(" WHERE"))
                wherePart = "";
            var db = dbModel.full_car.SqlQuery("SELECT * FROM full_car" + wherePart + ";").ToList();
            var source = new BindingSource();
            source.DataSource = db;
            this.dataGridViewCar.DataSource = source;
        }



    }
}
