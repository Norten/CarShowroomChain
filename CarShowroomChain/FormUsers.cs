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
    public partial class FormUsers : Form
    {
        DataGridViewRow row;
        public FormUsers()
        {
            InitializeComponent();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            FormNewUser fNU = new FormNewUser();
            fNU.ShowDialog();
        }

        private void FormUsers_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'polsl_agatek_bdDataSet.user_data' table. You can move, or remove it, as needed.
            this.user_dataTableAdapter.Fill(this.polsl_agatek_bdDataSet.user_data);

        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e) {
            row = this.dataGridViewUsers.Rows[e.RowIndex];
        }

        private void buttonModify_Click(object sender, EventArgs e) {
            if (row != null) {
                var id = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                var fCM = new FormNewUser(Int32.Parse(id));
                fCM.ShowDialog();
            }
        }
    }
}
