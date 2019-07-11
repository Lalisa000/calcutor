using System;

namespace calc
{
    public class Arcsin : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Asin(firstNumber);
        }
    }
}
