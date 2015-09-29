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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent(); 
        }

        private void buttonNewCarOrder_Click(object sender, EventArgs e)
        {
            FormNewCarOrder fNCO = new FormNewCarOrder();
            fNCO.ShowDialog();
        }

        private void buttonNewServiceOrder_Click(object sender, EventArgs e)
        {
            FormNewServiceOrder fNSO = new FormNewServiceOrder();
            fNSO.ShowDialog();
        }

        private void FormOrders_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'polsl_agatek_bdDataSet.reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.polsl_agatek_bdDataSet.reservation);

        }
    }
}
