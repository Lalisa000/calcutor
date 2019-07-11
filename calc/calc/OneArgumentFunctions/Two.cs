using System;

namespace calc
{
    public class Two : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Pow(2, firstNumber);
        }
    }
}
