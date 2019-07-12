using System;

namespace calc
{
    public class Sin : IOneArgumentCalculator
    {
        /// <summary>
        /// a function to calculate the sine
        /// </summary>
        /// < /// <param name="first Number"> sine argument value </param>
        /// <returns> return calculation result </returns>
        public double calculate(double firstNumber)
        {
            return Math.Sin(firstNumber);
        }
    }
}
