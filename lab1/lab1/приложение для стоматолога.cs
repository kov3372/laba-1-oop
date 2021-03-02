using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class приложение_для_стоматолога : Form
    {
       private int resultsum;

        public приложение_для_стоматолога()
        {
            InitializeComponent();
        }

        private void приложение_для_стоматолога_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            resultsum = resultsum + 150;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            resultsum = resultsum + 250;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            resultsum = resultsum + 140;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            resultsum = resultsum + 320;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            resultsum = resultsum + 250;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            resultsum = resultsum + 450;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = resultsum + "$" + " " + textBox1.Text ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
