using System;

namespace calc
{
    public class GeometricMean : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber)
        {
            return Math.Sqrt(firstNumber*secondNumber);
        }
    }
}
