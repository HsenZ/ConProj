using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repositories.Controllers;
using WinFormsApp1.Repositories.Models;

namespace ConProj
{
    public partial class ed5alForm : Form
    {
        InvestController investController = new InvestController();

        public ed5alForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = investController.GetAllInvests();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ash5asButton_Click(object sender, EventArgs e)
        {
            PeopleForm PeopleForm = new PeopleForm();
            PeopleForm.Show();
        }

        private void syaratButton_Click(object sender, EventArgs e)
        {
            FormVehicles FormVehicles = new FormVehicles();
            FormVehicles.Show();
        }

        private void tahdethButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = investController.GetAllInvests();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newInvest = new Invest();
            


            investController.AddInvest(newInvest);
        }
    }
}
