using System;

namespace calc
{
    public class Arcctan : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.PI/2 - Math.Atan(firstNumber);
        }
    }
}
