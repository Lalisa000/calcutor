using System;

namespace calc
{
    public class Extractor : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Sqrt(firstNumber);
        }
    }
}
