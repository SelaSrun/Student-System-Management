using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_System_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void informationStudentToolStripMenuItem_Click(object sender, EventArgs e)
            
        {
            this.Hide();
            Student_info st = new Student_info();
            st.Show();
           
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department_info Depart = new Department_info();
            Depart.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
