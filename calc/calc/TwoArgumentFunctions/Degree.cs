using System;

namespace calc
{
    public class Degree : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function to calculate the value of X to the power of Y
        /// </summary>
        /// <param name="firstNumber"> base value </param>
        /// <param name="secondNumber"> power value </param>
        /// < / / / <returns> returns the result of the operation </returns>

        public double calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}
