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
    public partial class FormNewCarOrder : Form
    {
        public FormNewCarOrder()
        {
            InitializeComponent();
        }

        private void buttonChooseClient_Click(object sender, EventArgs e)
        {
            FormClientSearch fCS = new FormClientSearch();
            fCS.ShowDialog();
        }

        private void buttonChooseCar_Click(object sender, EventArgs e)
        {
            FormCarSearch fCS = new FormCarSearch();
            fCS.ShowDialog();
        }

        private void buttonChooseAdditionalOptions_Click(object sender, EventArgs e)
        {
            FormServiceOptions fSO = new FormServiceOptions();
            fSO.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
