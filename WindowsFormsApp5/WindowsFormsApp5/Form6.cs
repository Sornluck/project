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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label8.Text == "A01")
            {
                string[] data = new string[5];
                double water, electric;
                water = Convert.ToDouble(textBox3.Text) * 10;
                electric = Convert.ToDouble(textBox4.Text) * 5;
                textBox1.Text = water.ToString();
                textBox7.Text = electric.ToString();
                data[0] = textBox2.Text;
                data[1] = textBox1.Text;
                data[2] = textBox7.Text;
                data[3] = textBox5.Text;
                data[4] = textBox6.Text;
                System.IO.File.WriteAllLines(Application.StartupPath + @"\room\A01.txt",data);
                MessageBox.Show("บันทึกเสร็จสิ้น");
            }
            else if (label8.Text == "A02")
            {
                string[] data = new string[5];
                double water, electric;
                water = Convert.ToDouble(textBox3.Text) * 10;
                electric = Convert.ToDouble(textBox4.Text) * 5;
                textBox1.Text = water.ToString();
                textBox7.Text = electric.ToString();
                data[0] = textBox2.Text;
                data[1] = textBox1.Text;
                data[2] = textBox7.Text;
                data[3] = textBox5.Text;
                data[4] = textBox6.Text;
                System.IO.File.WriteAllLines(Application.StartupPath + @"\room\A02.txt", data);
                MessageBox.Show("บันทึกเสร็จสิ้น");
            }
            else if (label8.Text == "A03")
            {
                string[] data = new string[5];
                double water, electric;
                water = Convert.ToDouble(textBox3.Text) * 10;
                electric = Convert.ToDouble(textBox4.Text) * 5;
                textBox1.Text = water.ToString();
                textBox7.Text = electric.ToString();
                data[0] = textBox2.Text;
                data[1] = textBox1.Text;
                data[2] = textBox7.Text;
                data[3] = textBox5.Text;
                data[4] = textBox6.Text;
                System.IO.File.WriteAllLines(Application.StartupPath + @"\room\A03.txt", data);
                MessageBox.Show("บันทึกเสร็จสิ้น");
            }
            else if (label8.Text == "A04")
            {
                string[] data = new string[5];
                double water, electric;
                water = Convert.ToDouble(textBox3.Text) * 10;
                electric = Convert.ToDouble(textBox4.Text) * 5;
                textBox1.Text = water.ToString();
                textBox7.Text = electric.ToString();
                data[0] = textBox2.Text;
                data[1] = textBox1.Text;
                data[2] = textBox7.Text;
                data[3] = textBox5.Text;
                data[4] = textBox6.Text;
                System.IO.File.WriteAllLines(Application.StartupPath + @"\room\A04.txt", data);
                MessageBox.Show("บันทึกเสร็จสิ้น");
            }
            else if (label8.Text == "A05")
            {
                string[] data = new string[5];
                double water, electric;
                water = Convert.ToDouble(textBox3.Text) * 10;
                electric = Convert.ToDouble(textBox4.Text) * 5;
                textBox1.Text = water.ToString();
                textBox7.Text = electric.ToString();
                data[0] = textBox2.Text;
                data[1] = textBox1.Text;
                data[2] = textBox7.Text;
                data[3] = textBox5.Text;
                data[4] = textBox6.Text;
                System.IO.File.WriteAllLines(Application.StartupPath + @"\room\A05.txt", data);
                MessageBox.Show("บันทึกเสร็จสิ้น");
            }
            else if (label8.Text == "A06")
            {
                string[] data = new string[5];
                double water, electric;
                water = Convert.ToDouble(textBox3.Text) * 10;
                electric = Convert.ToDouble(textBox4.Text) * 5;
                textBox1.Text = water.ToString();
                textBox7.Text = electric.ToString();
                data[0] = textBox2.Text;
                data[1] = textBox1.Text;
                data[2] = textBox7.Text;
                data[3] = textBox5.Text;
                data[4] = textBox6.Text;
                System.IO.File.WriteAllLines(Application.StartupPath + @"\room\A06.txt", data);
                MessageBox.Show("บันทึกเสร็จสิ้น");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
