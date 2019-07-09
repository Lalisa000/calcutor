using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void unionsi(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(this.textBox1.Text);
            double secondNumber = Convert.ToDouble(this.textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "summary":
                    result = firstNumber + secondNumber;
                    break;
                case "subtraction":
                    result = firstNumber - secondNumber;
                    break;
                case "multiplication":
                    result = firstNumber * secondNumber;
                    break;
                case "division":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            this.textBox3.Text = result.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    double firstNumber = Convert.ToDouble(this.textBox1.Text);
        //    double secondNumber = Convert.ToDouble(this.textBox2.Text);
        //    double result = firstNumber + secondNumber;
        //    this.textBox3.Text = result.ToString();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    double firstNumber = Convert.ToDouble(this.textBox1.Text);
        //    double secondNumber = Convert.ToDouble(this.textBox2.Text);
        //    double result = firstNumber - secondNumber;
        //    this.textBox3.Text = result.ToString();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    double firstNumber = Convert.ToDouble(this.textBox1.Text);
        //    double secondNumber = Convert.ToDouble(this.textBox2.Text);
        //    double result = firstNumber * secondNumber;
        //    this.textBox3.Text = result.ToString();
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    double firstNumber = Convert.ToDouble(this.textBox1.Text);
        //    double secondNumber = Convert.ToDouble(this.textBox2.Text);
        //    double result = firstNumber / secondNumber;
        //    this.textBox3.Text = result.ToString();
        //}
    }
}
