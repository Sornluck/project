using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ID()
        {
            if (textBox1.Text == "surapornb13" & textBox2.Text == "88889999")
            {
                this.Hide();
                Form f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("รหัสผิด");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ID();
        }
    }
}
