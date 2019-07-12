using System;

namespace calc
{
    public class Degree10 : IOneArgumentCalculator
    {
        /// <summary>
        /// / / / / function to calculate the value of ten to any degree
        /// </summary>
        /// <param name="firstNumber"> power values </param>
        /// <returns> return result value </returns>
        public double calculate(double firstNumber)
        {
            return Math.Pow(10, firstNumber);
        }
    }
}

