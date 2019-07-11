using System;

namespace calc
{
    public class Reverse : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            if (firstNumber == 0)
            {
                throw new Exception("Делить на ноль нельзя!");
            }
            return 1 / firstNumber;
        }
    }
}
