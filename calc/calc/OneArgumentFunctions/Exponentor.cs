using System;

namespace calc
{
    public class Exponentor : IOneArgumentCalculator
    {
        /// <summary>
        /// function to calculate the square of a number
        /// </summary>
        /// <param name="firstNumber"> base value </param>
        /// <returns> returns the result of the operation </returns>
        public double calculate(double firstNumber)
        {
            return Math.Pow(firstNumber, 2);
        }
    }
}
