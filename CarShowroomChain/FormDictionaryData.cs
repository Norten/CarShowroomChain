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
    public partial class FormDictionaryData : Form
    {
        public FormDictionaryData()
        {
            InitializeComponent(); 
            this.labelCost.Visible = false;
            this.listBoxCost.Visible = false;
            this.labelDictionaryNewWord.Visible = false;
            this.textBoxNewDictionaryData.Visible = false;
            this.labelNewValue.Visible = false;
            this.textBoxNewValue.Visible = false;
            this.buttonAdd.Visible = false;
            this.buttonSaveAndQuit.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDictionaryData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'polsl_agatek_bdDataSet.dict_body' table. You can move, or remove it, as needed.
            this.dict_bodyTableAdapter.Fill(this.polsl_agatek_bdDataSet.dict_body);

        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelDictionaryNewWord.Visible = true;
            this.textBoxNewDictionaryData.Visible = true;
            this.buttonAdd.Visible = true;
            this.buttonSaveAndQuit.Visible = true;
            string[] tables = {"dict_body", "dict_color", "dict_engine", "dict_fuel", "dict_gearbox", "dict_series", "dict_service"};
            var selectedTable = tables[this.listBoxCategories.SelectedIndex];
            List<string> list = new List<string>();
            List<decimal> cost = new List<decimal>();
            var dbModel = new DatabaseModel();
            switch (selectedTable)
            {
                case "dict_body":
                    this.labelCost.Visible = false;
                    this.listBoxCost.Visible = false;
                    this.labelNewValue.Visible = false;
                    this.textBoxNewValue.Visible = false;
                    var allBody = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();
                    list.Clear();
                    cost.Clear();
                    foreach(dict_body item in allBody)
                    {
                        list.Add(item.body);
                    }
                    break;
                case "dict_color":
                    this.labelCost.Visible = false;
                    this.listBoxCost.Visible = false;
                    this.labelNewValue.Visible = false;
                    this.textBoxNewValue.Visible = false;
                    var allColor = dbModel.dict_color.SqlQuery("SELECT * FROM dict_color;").ToList();
                    list.Clear();
                    cost.Clear();
                    foreach(dict_color item in allColor)
                    {
                        list.Add(item.color);
                    }
                    break;
                case "dict_engine":
                    this.labelCost.Visible = false;
                    this.listBoxCost.Visible = false;
                    this.labelNewValue.Visible = false;
                    this.textBoxNewValue.Visible = false;
                    var allEngine = dbModel.dict_engine.SqlQuery("SELECT * FROM dict_engine;").ToList();
                    list.Clear();
                    cost.Clear();
                    foreach(dict_engine item in allEngine)
                    {
                        list.Add(item.engine);
                    }
                    break;
                case "dict_fuel":
                    this.labelCost.Visible = false;
                    this.listBoxCost.Visible = false;
                    this.labelNewValue.Visible = false;
                    this.textBoxNewValue.Visible = false;
                    var allFuel = dbModel.dict_fuel.SqlQuery("SELECT * FROM dict_fuel;").ToList();
                    list.Clear();
                    cost.Clear();
                    foreach(dict_fuel item in allFuel)
                    {
                        list.Add(item.fuel);
                    }
                    break;
                case "dict_gearbox":
                    this.labelCost.Visible = false;
                    this.listBoxCost.Visible = false;
                    this.labelNewValue.Visible = false;
                    this.textBoxNewValue.Visible = false;
                    var allGearbox = dbModel.dict_gearbox.SqlQuery("SELECT * FROM dict_gearbox;").ToList();
                    list.Clear();
                    cost.Clear();
                    foreach(dict_gearbox item in allGearbox)
                    {
                        list.Add(item.gearbox);
                    }
                    break;
                case "dict_series":
                    this.labelCost.Visible = false;
                    this.listBoxCost.Visible = false;
                    this.labelNewValue.Visible = false;
                    this.textBoxNewValue.Visible = false;
                    var allSeries = dbModel.dict_series.SqlQuery("SELECT * FROM dict_series;").ToList();
                    list.Clear();
                    cost.Clear();
                    foreach(dict_series item in allSeries)
                    {
                        list.Add(item.series);
                    }
                    break;
                case "dict_service":
                    this.labelCost.Visible = true;
                    this.listBoxCost.Visible = true;
                    this.labelNewValue.Visible = true;
                    this.textBoxNewValue.Visible = true;
                    var allService = dbModel.dict_service.SqlQuery("SELECT * FROM dict_service;").ToList();
                    list.Clear();
                    cost.Clear();
                    foreach(dict_service item in allService)
                    {
                        list.Add(item.name);
                        cost.Add(item.cost);
                    }
                    break;
                default:
                    list.Clear();
                    cost.Clear();
                    break;
            }   

            this.listBoxDictionaryData.DataSource = list;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
