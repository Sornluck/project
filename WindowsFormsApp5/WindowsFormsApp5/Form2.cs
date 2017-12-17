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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Form1();
            f1.Show();
        }
        Form5 f5 = new Form5();
        Form3 f3 = new Form3();
        private void button2_Click(object sender, EventArgs e)
        {
           
            
            this.Hide();           
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f5.pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\1.jpg");
            this.Hide();
            f5.Show();
        }
    }
}
