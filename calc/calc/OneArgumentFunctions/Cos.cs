using System;

namespace calc
{
    public class Cos : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Cos(firstNumber);
        }
    }
}
