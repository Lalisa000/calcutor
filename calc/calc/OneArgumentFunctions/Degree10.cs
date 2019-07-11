using System;

namespace calc
{
    public class Degree10 : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Pow(10, firstNumber);
        }
    }
}

