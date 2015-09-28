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
            Console.WriteLine(selectedTable);
        }
    }
}
