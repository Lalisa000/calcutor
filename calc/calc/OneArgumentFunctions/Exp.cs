using System;

namespace calc
{
    public class Exp : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Exp(firstNumber);
        }
    }
}
