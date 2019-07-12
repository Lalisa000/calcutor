using System;

namespace calc
{
    public class Reverse : IOneArgumentCalculator
    {
        /// <summary>
        /// function to calculate the inverse of a number
        /// </summary>
        /// < /// <param name="first Number"> function argument </param>
        /// <returns> return the return value of the </returns>argument
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
