using System;

namespace calc
{
    public class NaturalLog : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            if (firstNumber <= 0)
            {
                throw new Exception("Х должен быть положитедьным");
            }
            return Math.Log(firstNumber, Math.E);
        }
    }
}
