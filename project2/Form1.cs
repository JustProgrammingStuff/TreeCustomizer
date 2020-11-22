using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            star.Location = new Point(397, 35);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            star.Location = new Point(17, 21);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(138, 21);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(407, 21);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(334, 234);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(17, 135);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(334, 234);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(17, 249);
        }
    }
}
