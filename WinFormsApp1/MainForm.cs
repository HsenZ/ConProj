using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConProj
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ed5alButton_Click(object sender, EventArgs e)
        {
            ed5alForm ed5alForm = new ed5alForm();
            ed5alForm.Show();
        }

        private void jara2emButton_Click(object sender, EventArgs e)
        {
            jara2emForm jara2EmForm = new jara2emForm();
            jara2EmForm.Show();
        }
    }
}
