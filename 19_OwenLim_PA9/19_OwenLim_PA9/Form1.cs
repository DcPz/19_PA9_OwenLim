using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_OwenLim_PA9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            const decimal us = 0.74M, yen = 81.97M, ringgit = 3.01M;

            try
            {

                decimal Amount = Convert.ToDecimal(txt_Amount.Text);
                if (rb_US.Checked)
                {
                    decimal answer = Amount * us;
                    txt_Converted.Text = answer.ToString();
                }
                if (rb_Yen.Checked)
                {
                    decimal answer = Amount * yen;
                    txt_Converted.Text = answer.ToString();
                }
                else
                {
                    txt_Amount.Text = "Choose one of the currencies";
                }

            }
            catch (FormatException)
            {
                txt_Amount.Text = "Please enter a valid amount";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Amount.Clear();
            txt_Converted.Clear();
        }
    }
}
