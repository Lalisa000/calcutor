using System;

namespace calc
{
    public class Arcsin : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            if (firstNumber > 1 || firstNumber < -1)
            {
                throw new Exception("Х должен лежать в интервале (-1;1)");
            }
            return Math.Asin(firstNumber);
        }
    }
}
