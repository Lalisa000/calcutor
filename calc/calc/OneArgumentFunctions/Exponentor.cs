using System;

namespace calc
{
    public class Exponentor : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Pow(firstNumber, 2);
        }
    }
}
