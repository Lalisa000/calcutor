using System;

namespace calc
{
    public class Ctan : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return 1/Math.Tan(firstNumber);
        }
    }
}
