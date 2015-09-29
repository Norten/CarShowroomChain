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
                this.buttonFilter_Click(new object(), new EventArgs());
            }
        }

        private void buttonHire_Click(object sender, EventArgs e) {
            if (row != null) {
                var id = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                var dbModel = new DatabaseModel();
                var user = dbModel.user_data.Find(Int32.Parse(id));
                user.is_active = 1;
                dbModel.SaveChanges();
                this.buttonFilter_Click(new object(), new EventArgs());
            }
        }

        private void buttonDismiss_Click(object sender, EventArgs e) {
            if (row != null) {
                var id = row.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
                var dbModel = new DatabaseModel();
                var user = dbModel.user_data.Find(Int32.Parse(id));
                user.is_active = 0;
                dbModel.SaveChanges();
                this.buttonFilter_Click(new object(), new EventArgs());
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            var name = this.textBoxName.Text;
            var surname = this.textBoxSurname.Text;
            var dbModel = new DatabaseModel();
            string wherePart = " WHERE";
            if (!String.IsNullOrWhiteSpace(name))
                wherePart += " first_name like '" + name + "%'";
            if (!String.IsNullOrWhiteSpace(name) && !String.IsNullOrWhiteSpace(surname))
                wherePart += " AND";
            if (!String.IsNullOrWhiteSpace(surname))
                wherePart += " last_name like '" + surname + "%'";
            if (wherePart.Equals(" WHERE"))
                wherePart = "";
            var db = dbModel.user_data.SqlQuery("SELECT * FROM user_data" + wherePart +";").ToList();
            var source = new BindingSource();
            source.DataSource = db;
            this.dataGridViewUsers.DataSource = source;
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e) {
            MessageBox.Show("W tabelce są wyświetleni wszyscy użytkownicy systemu.\n" + 
                "Możesz zawęzić wyniki wyszukiwania poprzez wybranie konkretnych opcji.\n" + 
                "Aby ponownie wyświetlić wszystkich użytkowników wyczyść wszystkie warunki " + 
                "i kliknij przycisk 'Filtruj'.\n" + 
                "Gdy klikniesz na konkretnego użytkownika w tabelce, możesz kliknąć w przycisk 'Modyfikuj'.\n" + 
                "Gdy klikniesz w przycisk 'Dodaj nowego użytkownika' będziesz mógł dodac nowego użytkownika." +
                "Możesz także zatrudnić lub zwolnić pracownika (zwolniony użytkownik, nie będzie miał dostępu do systemu.");
        }
    }
}
