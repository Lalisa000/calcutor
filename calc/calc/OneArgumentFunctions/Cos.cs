using System;

namespace calc
{
    public class Cos : IOneArgumentCalculator
    {
        /// <summary>
        /// function to calculate the cosine value
        /// </summary>
        /// < /// <param name="first Number"> function argument </param>
        /// <returns> return the cosine value </returns>
        public double calculate(double firstNumber)
        {
            return Math.Cos(firstNumber);
        }
    }
}
