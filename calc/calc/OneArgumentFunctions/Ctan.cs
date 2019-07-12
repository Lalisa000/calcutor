using System;

namespace calc
{
    public class Ctan : IOneArgumentCalculator
    {
        /// <summary>
        /// a function to calculate the cotangent
        /// </summary>
        /// < /// <param name="first Number"> function argument </param>
        /// <returns> return the cotangent </returns>
        public double calculate(double firstNumber)
        {
            return 1 / Math.Tan(firstNumber);
        }
    }
}
