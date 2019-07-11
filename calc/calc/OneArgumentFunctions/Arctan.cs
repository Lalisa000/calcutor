using System;

namespace calc
{
    public class Arctan : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Atan(firstNumber);
        }
    }
}
