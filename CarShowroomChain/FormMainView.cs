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
    public partial class FormMainView : Form
    {
        public FormMainView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUsers fU = new FormUsers();
            fU.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReports fR = new FormReports();
            fR.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormOrders fO = new FormOrders();
            fO.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNewCar fNC = new FormNewCar();
            fNC.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormDictionaryData fDD = new FormDictionaryData();
            fDD.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormClientSearch fCS = new FormClientSearch();
            fCS.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormAccountManagement fAM = new FormAccountManagement();
            fAM.ShowDialog();
        }

        private void pictureBoxQuestionMark_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kliknij w którykolwiek przycisk z menu aby otworzyło Ci się nowe okienko z odpowiednimi opcjami.");
        }
    }
}
