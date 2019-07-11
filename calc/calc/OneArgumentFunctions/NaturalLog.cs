using System;

namespace calc
{
    public class NaturalLog : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Log(firstNumber, Math.E);
        }
    }
}
