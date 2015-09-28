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
        DatabaseModel dbModelSave = new DatabaseModel();
        string valueAdded;
        string costAdded;
        public FormDictionaryData()
        {
            InitializeComponent();
            unvisibleAll();
        }

        public void unvisibleAll()
        {
            this.labelCost.Visible = false;
            this.listBoxCost.Visible = false;
            this.labelDictionaryNewWord.Visible = false;
            this.textBoxNewDictionaryData.Visible = false;
            this.labelNewValue.Visible = false;
            this.textBoxNewValue.Visible = false;
            this.buttonAdd.Visible = false;
            this.textBoxAddedValue.Visible = false;
            this.textBoxAddedCost.Visible = false;
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

        public void dictionarySettings (bool visible, List<string> list, List<string> cost)
        {
            this.labelCost.Visible = visible;
            this.listBoxCost.Visible = visible;
            this.labelNewValue.Visible = visible;
            this.textBoxNewValue.Visible = visible;
            list.Clear();
            cost.Clear();
        }
        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labelDictionaryNewWord.Visible = true;
            this.textBoxNewDictionaryData.Visible = true;
            this.buttonAdd.Visible = true;
            this.buttonSaveAndQuit.Visible = true;
            string[] tables = {"dict_body", "dict_color", "dict_engine", "dict_fuel", "dict_gearbox", "dict_series", "dict_service", "model"};
            var selectedTable = tables[this.listBoxCategories.SelectedIndex];
            List<string> list = new List<string>();
            List<string> cost = new List<string>();
            var dbModel = new DatabaseModel();
            switch (selectedTable)
            {
                case "dict_body":
                    dictionarySettings(false, list, cost);
                    var allBody = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();
                    foreach(dict_body item in allBody)
                    {
                        list.Add(item.body);
                    }
                    break;
                case "dict_color":
                    dictionarySettings(false, list, cost);
                    var allColor = dbModel.dict_color.SqlQuery("SELECT * FROM dict_color;").ToList();
                    foreach(dict_color item in allColor)
                    {
                        list.Add(item.color);
                    }
                    break;
                case "dict_engine":
                    dictionarySettings(false, list, cost);
                    var allEngine = dbModel.dict_engine.SqlQuery("SELECT * FROM dict_engine;").ToList();
                    foreach(dict_engine item in allEngine)
                    {
                        list.Add(item.engine);
                    }
                    break;
                case "dict_fuel":
                    dictionarySettings(false, list, cost);
                    var allFuel = dbModel.dict_fuel.SqlQuery("SELECT * FROM dict_fuel;").ToList();
                    foreach(dict_fuel item in allFuel)
                    {
                        list.Add(item.fuel);
                    }
                    break;
                case "dict_gearbox":
                    dictionarySettings(false, list, cost);
                    var allGearbox = dbModel.dict_gearbox.SqlQuery("SELECT * FROM dict_gearbox;").ToList();
                    foreach(dict_gearbox item in allGearbox)
                    {
                        list.Add(item.gearbox);
                    }
                    break;
                case "dict_series":
                    dictionarySettings(false, list, cost);
                    var allSeries = dbModel.dict_series.SqlQuery("SELECT * FROM dict_series;").ToList();
                    foreach(dict_series item in allSeries)
                    {
                        list.Add(item.series);
                    }
                    break;
                case "dict_service":
                    dictionarySettings(true, list, cost);
                    var allService = dbModel.dict_service.SqlQuery("SELECT * FROM dict_service;").ToList();
                    foreach(dict_service item in allService)
                    {
                        list.Add(item.name);
                        cost.Add(item.cost);
                    }
                    break;
                case "model":
                    dictionarySettings(false, list, cost);
                    var allModel = dbModel.model.SqlQuery("SELECT * FROM model;").ToList();
                    foreach (model item in allModel)
                    {
                        list.Add(item.name);
                    }
                    break;
                default:
                    list.Clear();
                    cost.Clear();
                    break;
            }   

            this.listBoxDictionaryData.DataSource = list;
            this.listBoxCost.DataSource = cost;
        }

        public void addToDatabase (string toValue, string toCost)
        {
            valueAdded = toValue;
            costAdded = toCost;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.textBoxAddedValue.Visible = true;
            this.textBoxAddedCost.Visible = false;
            string[] tables = { "dict_body", "dict_color", "dict_engine", "dict_fuel", "dict_gearbox", "dict_series", "dict_service", "model" };
            var selectedTable = tables[this.listBoxCategories.SelectedIndex];
            
            switch (selectedTable)
            {
                case "dict_body":
                    var newBody = new dict_body();
                    newBody.body = this.textBoxNewDictionaryData.Text;
                    dbModelSave.dict_body.Add(newBody);
                    break;
                case "dict_color":
                    var newColor = new dict_color();
                    newColor.color = this.textBoxNewDictionaryData.Text;
                    dbModelSave.dict_color.Add(newColor);
                    break;
                case "dict_engine":
                    var newEngine = new dict_engine();
                    newEngine.engine = this.textBoxNewDictionaryData.Text;
                    dbModelSave.dict_engine.Add(newEngine);
                    break;
                case "dict_fuel":
                    var newFuel = new dict_fuel();
                    newFuel.fuel = this.textBoxNewDictionaryData.Text;
                    dbModelSave.dict_fuel.Add(newFuel);
                    break;
                case "dict_gearbox":
                    var newGearbox = new dict_gearbox();
                    newGearbox.gearbox = this.textBoxNewDictionaryData.Text;
                    dbModelSave.dict_gearbox.Add(newGearbox);
                    break;
                case "dict_series":
                    var newSeries = new dict_series();
                    newSeries.series = this.textBoxNewDictionaryData.Text;
                    dbModelSave.dict_series.Add(newSeries);
                    break;
                case "dict_service":
                    this.textBoxAddedCost.Visible = true;
                    var newService = new dict_service();
                    newService.name = this.textBoxNewDictionaryData.Text;
                    newService.cost = this.textBoxNewValue.Text;
                    dbModelSave.dict_service.Add(newService);
                    break;
                case "model":
                    var newModel = new model();
                    newModel.name = this.textBoxNewDictionaryData.Text;
                    dbModelSave.model.Add(newModel);
                    break;
                default:
                    
                    break;
            }
            addToDatabase(this.textBoxNewDictionaryData.Text, this.textBoxNewValue.Text);
            this.textBoxAddedValue.Text = valueAdded;
            this.textBoxAddedCost.Text = costAdded;
            this.textBoxNewDictionaryData.Clear();
            this.textBoxNewValue.Clear();
            
        }

        private void buttonSaveAndQuit_Click(object sender, EventArgs e)
        {
            dbModelSave.SaveChanges();
            this.Close();
        }
    }
}
