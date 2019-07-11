using System;

namespace calc
{
    public class Arccos : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Acos(firstNumber);
        }
    }
}
