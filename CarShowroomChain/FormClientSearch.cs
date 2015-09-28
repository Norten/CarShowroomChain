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
    public partial class FormClientSearch : Form
    {
        DataGridViewRow row;
        Action<DataGridViewRow> SelectClient;
        public FormClientSearch(Action<DataGridViewRow> SelectClient = null)
        {
            InitializeComponent();
            this.SelectClient = SelectClient;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormNewClient fNC = new FormNewClient();
            fNC.ShowDialog();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (row != null)
            {
                var id = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                FormClientModify fCM = new FormClientModify(Int32.Parse(id));
                fCM.ShowDialog();
            }
        }

        private void FormClientSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'polsl_agatek_bdDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.polsl_agatek_bdDataSet.client);

        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = this.dataGridViewClients.Rows[e.RowIndex];
            Console.WriteLine("CLIENT ID: " + row.Cells["idDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void buttonChoose_Click(object sender, EventArgs e) {
            if (this.SelectClient == null) {
                this.Close();
                return;
            } 
            if (row != null) {
                this.SelectClient(row);
                this.Close();
                return;
            } else 
                MessageBox.Show("Musisz najpierw wybrać klienta.");
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            var name = this.textBoxName.Text;
            var surname = this.textBoxSurname.Text;
            var dbModel = new DatabaseModel();
            string wherePart = " WHERE";
            if (!String.IsNullOrWhiteSpace(name))
                wherePart += " first_name like '" + name + "'";
            if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(surname))
                wherePart += " AND";
            if (!String.IsNullOrWhiteSpace(surname))
                wherePart += " last_name like '" + surname + "' ";
            if (wherePart.Equals(" WHERE"))
                wherePart = "";
            var db = dbModel.client.SqlQuery("SELECT * FROM client" + wherePart +";").ToList();
            var source = new BindingSource();
            source.DataSource = db;
            this.dataGridViewClients.DataSource = source;
        }
    }
}
