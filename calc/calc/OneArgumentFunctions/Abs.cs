using System;

namespace calc
{
    public class Abs : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Abs(firstNumber);
        }
    }
}
