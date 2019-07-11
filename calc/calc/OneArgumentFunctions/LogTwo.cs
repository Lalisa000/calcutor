using System;

namespace calc
{
    public class LogTwo : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Log(firstNumber, 2);
        }
    }
}
