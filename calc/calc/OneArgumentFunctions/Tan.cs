using System;

namespace calc
{
    public class Tan : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Tan(firstNumber);
        }
    }
}
