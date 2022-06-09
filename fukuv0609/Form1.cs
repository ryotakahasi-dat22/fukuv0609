using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("高橋涼");
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left + (int.Parse(textBox1.Text));
            label1.Top = label1.Top + (int.Parse(textBox2.Text));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "爆裂種トウモロコシ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "生トウモロコシ";
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = true;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "粒トウモロコシ";
            timer1.Enabled = false;
            timer2.Enabled = true;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "冷やしトウモロコシ";
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "爆裂種トウモロコシ";
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = true;
            timer5.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top - 5;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left - 5;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 5;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 5;
        }
    }
}
