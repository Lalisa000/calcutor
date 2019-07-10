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


        private void Calculate(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(this.textBox1.Text);
            double secondNumber = Convert.ToDouble(this.textBox2.Text);
            double result;
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            result = calculator.calculate(firstNumber, secondNumber);
            this.textBox3.Text = result.ToString();
        }

        private void CalculateOne(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(this.textBox1.Text);
            double result;
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
            result = calculator.calculateE(firstNumber);
            this.textBox3.Text = result.ToString();
        }
    }
}
