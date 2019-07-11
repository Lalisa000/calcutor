using System;

namespace calc
{
    public class Degree : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber,secondNumber);
        }
    }
}
