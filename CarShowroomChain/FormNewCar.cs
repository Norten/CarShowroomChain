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
        List<dict_body> dictBody;
        List<dict_color> dictColor;
        List<dict_engine> dictEngine;
        List<dict_fuel> dictFuel;
        List<dict_gearbox> dictGearbox;
        List<dict_series> dictSeries;
        List<model> dictModel; 
        List<car_shop> dictShop;
        List<string> listBody, listColor, listEngine, listFuel, listGearbox, listSeries, listModel, listShop;
        car newCar;
        public FormNewCar()
        {
            InitializeComponent();
            loadData();
        }
        
        void loadData()
        {
            dictBody = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();
            dictColor = dbModel.dict_color.SqlQuery("SELECT * FROM dict_color;").ToList();
            dictEngine = dbModel.dict_engine.SqlQuery("SELECT * FROM dict_engine;").ToList();
            dictFuel = dbModel.dict_fuel.SqlQuery("SELECT * FROM dict_fuel;").ToList();
            dictGearbox = dbModel.dict_gearbox.SqlQuery("SELECT * FROM dict_gearbox;").ToList();
            dictSeries = dbModel.dict_series.SqlQuery("SELECT * FROM dict_series;").ToList();
            dictModel = dbModel.model.SqlQuery("SELECT * FROM model;").ToList();
            dictShop = dbModel.car_shop.SqlQuery("SELECT * FROM car_shop;").ToList();
            listBody = new List<string>();
            listColor = new List<string>();
            listEngine = new List<string>();
            listFuel = new List<string>();
            listGearbox = new List<string>();
            listSeries = new List<string>();
            listModel = new List<string>();
            listShop = new List<string>();
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

            //car.OPTION = this.VALUE.Text;
            //dbModel.car.Add(newCar);
            //dbModel.SaveChanges();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
