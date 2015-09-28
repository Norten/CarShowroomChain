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
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChoose_Click(object sender, EventArgs e) {
            if (this.SelectCar == null) {
                this.Close();
                return;
            }
            if (row != null) {
                this.SelectCar(row);
                this.Close();
                return;
            } else
                MessageBox.Show("Musisz najpierw wybrać samochód.");
        }
    }
}
