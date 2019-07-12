using System;

namespace calc
{
    public class PowerOfTwo : IOneArgumentCalculator
    {
        /// <summary>
        /// function to calculate the value of two to any degree
        /// </summary>
        /// < / / / <param name="first Number"> power value </param>
        /// <returns> return the result of the operation </returns>
        public double calculate(double firstNumber)
        {
            return Math.Pow(2, firstNumber);
        }
    }
}
