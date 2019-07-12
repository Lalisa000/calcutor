using System;

namespace calc
{
    public class Arctan : IOneArgumentCalculator
    {
        /// <summary>
        /// function to calculate the arctangent value
        /// </summary>
        /// < /// <param name="first Number"> function argument </param>
        /// <returns> return the arctangent value </returns>
        public double calculate(double firstNumber)
        {
            return Math.Atan(firstNumber);
        }
    }
}
