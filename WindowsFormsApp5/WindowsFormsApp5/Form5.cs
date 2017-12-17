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
    
    public partial class Form5 : Form
    {
        int i = 1;
        public Form5()
        {
            
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(i <=3)
            {
                int s = i + 1;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\"+ s + ".jpg");
            i++;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i >= 2)
            {
                int s = i - 1;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\" + s + ".jpg");
                i--;
            }
        }
    }
}
