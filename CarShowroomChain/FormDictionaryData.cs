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
            string[] tables = {"dict_body", "dict_color", "dict_engine", "dict_fuel", "dict_gearbox", "dict_series", "dict_service"};
            var selectedTable = tables[this.listBoxCategories.SelectedIndex];
            List<string> list = new List<string>();
            
            var dbModel = new DatabaseModel();
            switch (selectedTable)
            {
                case "dict_body":
                    var allDictionary = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();
                    break;
                case "dict_color":
                    Console.WriteLine("Case 2");
                    break;
                case "dict_engine":
                    Console.WriteLine("Case 1");
                    break;
                case "dict_fuel":
                    Console.WriteLine("Case 1");
                    break;
                case "dict_gearbox":
                    Console.WriteLine("Case 1");
                    break;
                case "dict_series":
                    Console.WriteLine("Case 1");
                    break;
                case "dict_service":
                    Console.WriteLine("Case 1");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            var allBody = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();

            
            foreach(dict_body item in allBody)
            {
                list.Add(item.body);
            }
            this.listBoxDictionaryData.DataSource = list;
            //var color = dbModel.dict_color.SqlQuery("SELECT * FROM dict_color;").ToList();
            //var body = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();
            //var body = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();
            //var body = dbModel.dict_body.SqlQuery("SELECT * FROM dict_body;").ToList();
        }
    }
}
