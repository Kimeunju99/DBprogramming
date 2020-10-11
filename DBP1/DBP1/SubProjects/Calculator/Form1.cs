using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }

        public void InitVariables() {
            comboBox1.Items.Clear();

            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.Items.Add("^");

            comboBox1.SelectedIndex = 0;

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void buttonComboBoxCalculator_Click(object sender, EventArgs e)
        {
            double oper1 = double.Parse(textBoxComboCalc_1.Text);
            double oper2 = double.Parse(textBoxComboCalc_2.Text);
            double result = 0;
            String oper = "";

            switch (comboBox1.SelectedIndex) {
                case 0:
                    oper = "+";
                    result = oper1 + oper2;
                    break;
                case 1:
                    oper = "-";
                    result = oper1 - oper2;
                    break;
                case 2:
                    oper = "*";
                    result = oper1 * oper2;
                    break;
                case 3:
                    oper = "/";
                    result = oper1 / oper2;
                    break;
                case 4:
                    oper = "^";
                    result = oper1;
                    for (int i=1; i<oper2;i++)
                        result *= oper1 ;
                    break;
            }

            textBoxComboCalc_3.Text = result.ToString();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBoxComboCalc_1_TextChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double oper1 = double.Parse(textBox_RC1.Text);
            double oper2 = double.Parse(textBox_RC2.Text);
            double result = 0;

            if (radioButton1.Checked)
                result = oper1 + oper2;
            if (radioButton2.Checked)
                result = oper1 - oper2;

            textBox_RC3.Text = result.ToString();
        }

        private void textBox_RC1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_RC2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
