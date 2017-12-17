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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            room();
        }
        public void room()
        {
            for(int i = 1; i <= 6; i++)
            {
                comboBox1.Items.Add("A0"+i);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = new string[4];
            data[0] = textBox2.Text;
            data[1] = textBox3.Text;
            data[2] = textBox4.Text;
            data[3] = textBox5.Text;
            System.IO.File.WriteAllLines(Application.StartupPath + @"\infomation\" + comboBox1.Text +".txt", data);
            MessageBox.Show("บันทึกเสร็จสิ้น");
        }
    }
}
