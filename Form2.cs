using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LAB3
{
    public partial class Form1 : Form
    {
        const decimal LightBeerPrice = 30;
        const decimal DarkBeerPrice = 35;
        const decimal DiscountThreshold = 20;
        const decimal DiscountRate = 0.15m;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            textBox3.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lightBeerCount = (int)numericUpDown1.Value;
            int darkBeerCount = (int)numericUpDown2.Value;
            int totalBeers = lightBeerCount + darkBeerCount;

            decimal totalCost = (lightBeerCount * LightBeerPrice) + (darkBeerCount * DarkBeerPrice);

            if (totalBeers > DiscountThreshold)
            {
                totalCost -= totalCost * DiscountRate;
            }

            textBox3.Text = totalCost.ToString("0.00");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
