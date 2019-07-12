using System;

namespace calc
{
    public class Extractor : IOneArgumentCalculator
    {
        /// <summary>
        /// function for calculating square root
        /// </summary>
        /// <param name="firstNumber"> subquery expression </param>
        /// <returns> return result </returns>
        public double calculate(double firstNumber)
        {
            if (firstNumber < 0)
            {
                throw new Exception("Х не должен быть отрицательным");
            }
            return Math.Sqrt(firstNumber);
        }
    }
}
