using System;

namespace calc
{
    public class GeometricMean : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber)
        {
            if (firstNumber < 0 || secondNumber < 0)
            {
                throw new Exception("Число под корнем должно быть положительным!");
            }
            return Math.Sqrt(firstNumber*secondNumber);
        }
    }
}
