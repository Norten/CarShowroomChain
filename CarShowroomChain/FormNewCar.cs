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
    public partial class FormNewCar : Form
    {
        DatabaseModel dbModel = new DatabaseModel();
        Dictionary<string, int>
            keyValBody = new Dictionary<string, int>(),
            keyValColor = new Dictionary<string, int>(),
            keyValEngine = new Dictionary<string, int>(),
            keyValFuel = new Dictionary<string, int>(),
            keyValGearbox = new Dictionary<string, int>(),
            keyValSeries = new Dictionary<string, int>(),
            keyValModel = new Dictionary<string, int>(),
            keyValShop = new Dictionary<string, int>();
        public FormNewCar()
        {
            InitializeComponent();
            loadData();
        }
        
        void loadData()
        {
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
            foreach (dict_body item in dictBody) 
            { 
                listBody.Add(item.body);
                keyValBody.Add(item.body, item.id);
            }
            foreach (dict_color item in dictColor) 
            { 
                listColor.Add(item.color);
                keyValColor.Add(item.color, item.id);
            }
            foreach (dict_engine item in dictEngine) 
            { 
                listEngine.Add(item.engine);
                keyValEngine.Add(item.engine, item.id);
            }
            foreach (dict_fuel item in dictFuel) 
            { 
                listFuel.Add(item.fuel);
                keyValFuel.Add(item.fuel, item.id);
            }
            foreach (dict_gearbox item in dictGearbox) 
            { 
                listGearbox.Add(item.gearbox);
                keyValGearbox.Add(item.gearbox, item.id);
            }
            foreach (dict_series item in dictSeries) 
            { 
                listSeries.Add(item.series);
                keyValSeries.Add(item.series, item.id);
            }
            foreach (model item in dictModel) 
            { 
                listModel.Add(item.name);
                keyValModel.Add(item.name, item.id);
            }
            foreach (car_shop item in dictShop) 
            { 
                listShop.Add(item.name);
                keyValShop.Add(item.name, item.id);
            }
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

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            car newCar = new car();
            newCar.id_body = keyValBody[this.comboBoxCarBody.Text];
            newCar.id_color = keyValColor[this.comboBoxColor.Text];
            newCar.id_engine = keyValEngine[this.comboBoxEngine.Text];
            newCar.id_fuel = keyValFuel[this.comboBoxFuel.Text];
            newCar.id_gearbox = keyValGearbox[this.comboBoxGearbox.Text];
            newCar.id_series = keyValSeries[this.comboBoxSeries.Text];
            newCar.id_model = keyValModel[this.comboBoxModel.Text];
            newCar.id_car_shop = keyValShop[this.comboBoxShop.Text];
            newCar.cost = this.textBoxPrice.Text;
            dbModel.car.Add(newCar);
            dbModel.SaveChanges();
            this.Close();
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wypełnij wszystkie pola aby dodac nowy samochód do bazy danych.");
        }
    }
}