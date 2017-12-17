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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            string[] data = System.IO.File.ReadAllLines(Application.StartupPath + @"\room\A01.txt");
            string[] data1 = System.IO.File.ReadAllLines(Application.StartupPath + @"\infomation\A01.txt");
            f6.label8.Text = "A01";
            f6.textBox2.Text = data1[0];
            f6.textBox1.Text = data[1];
            f6.textBox7.Text = data[2];
            f6.textBox5.Text = data[3];
            f6.textBox6.Text = data[4];
            f6.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            string[] data = System.IO.File.ReadAllLines(Application.StartupPath + @"\room\A02.txt");
            string[] data1 = System.IO.File.ReadAllLines(Application.StartupPath + @"\infomation\A02.txt");
            f6.textBox2.Text = data1[0];
            f6.textBox1.Text = data[1];
            f6.textBox7.Text = data[2];
            f6.textBox5.Text = data[3];
            f6.textBox6.Text = data[4];
            f6.label8.Text = "A02";
            f6.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            string[] data = System.IO.File.ReadAllLines(Application.StartupPath + @"\room\A03.txt");
            string[] data1 = System.IO.File.ReadAllLines(Application.StartupPath + @"\infomation\A03.txt");
            f6.textBox2.Text = data1[0];
            f6.textBox1.Text = data[1];
            f6.textBox7.Text = data[2];
            f6.textBox5.Text = data[3];
            f6.textBox6.Text = data[4];
            f6.label8.Text = "A03";
            f6.Show();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            string[] data = System.IO.File.ReadAllLines(Application.StartupPath + @"\room\A04.txt");
            string[] data1 = System.IO.File.ReadAllLines(Application.StartupPath + @"\infomation\A04.txt");
            f6.textBox2.Text = data1[0];
            f6.textBox1.Text = data[1];
            f6.textBox7.Text = data[2];
            f6.textBox5.Text = data[3];
            f6.textBox6.Text = data[4];
            f6.label8.Text = "A04";
            f6.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            string[] data = System.IO.File.ReadAllLines(Application.StartupPath + @"\room\A05.txt");
            string[] data1 = System.IO.File.ReadAllLines(Application.StartupPath + @"\infomation\A05.txt");
            f6.textBox2.Text = data1[0];
            f6.textBox1.Text = data[1];
            f6.textBox7.Text = data[2];
            f6.textBox5.Text = data[3];
            f6.textBox6.Text = data[4];
            f6.label8.Text = "A05";
            f6.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            string[] data = System.IO.File.ReadAllLines(Application.StartupPath + @"\room\A06.txt");
            string[] data1 = System.IO.File.ReadAllLines(Application.StartupPath + @"\infomation\A06.txt");
            f6.textBox2.Text = data1[0];
            f6.textBox1.Text = data[1];
            f6.textBox7.Text = data[2];
            f6.textBox5.Text = data[3];
            f6.textBox6.Text = data[4];
            f6.label8.Text = "A06";
            f6.Show();
            Close();
        }
    }
}
