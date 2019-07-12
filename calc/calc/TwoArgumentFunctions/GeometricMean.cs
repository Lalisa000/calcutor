using System;

namespace calc
{
    public class GeometricMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function for calculating geometric mean
        /// </summary>
        /// <param name="firstNumber"> first multiplier </param>
        /// <param name="secondNumber"> second multiplier </param>
        /// <returns> return the result of the operation </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            if (firstNumber < 0 || secondNumber < 0)
            {
                throw new Exception("Число под корнем должно быть положительным!");
            }
            return Math.Sqrt(firstNumber * secondNumber);
        }
    }
}
