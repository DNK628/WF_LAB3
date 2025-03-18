using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; 
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_Load);

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                button2.PerformClick(); 
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string email = textBox4.Text.Trim();

            int birthYear = (int)numericUpDown3.Value;
            int birthMonth = (int)numericUpDown2.Value;
            int birthDay = (int)numericUpDown1.Value;

            if (birthYear < 1900 || birthYear > DateTime.Now.Year)
            {
                MessageBox.Show("Некоректний рік народження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (birthMonth < 1 || birthMonth > 12)
            {
                MessageBox.Show("Некоректний місяць.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (birthDay < 1 || birthDay > 31)
            {
                MessageBox.Show("Некоректний день.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gender = radioButton1.Checked ? "Чоловік" : radioButton2.Checked ? "Жінка" : "Не вказано";

            string result = $"Ім’я: {firstName}\nПрізвище: {lastName}\nРік народження: {birthYear}\nМісяць: {birthMonth}\nДень: {birthDay}\nEmail: {email}\nСтать: {gender}";
            textBox5.Text = result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
