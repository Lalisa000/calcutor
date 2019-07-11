using System;

namespace calc
{
    public class Sin : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Sin(firstNumber);
        }
    }
}
