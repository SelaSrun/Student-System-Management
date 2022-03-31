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
    public partial class Department_info : Form
    {
        public Department_info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bk1 = new Form1();
            bk1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
