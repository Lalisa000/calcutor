using System;

namespace calc
{
    public class Exp : IOneArgumentCalculator
    {
        /// <summary>
        /// a function to calculate the degree exponent
        /// </summary>
        /// < / / / <param name="first Number"> power value </param>
        /// <returns> return the result of raising a to the power of exponent </returns>
        public double calculate(double firstNumber)
        {
            return Math.Exp(firstNumber);
        }
    }
}
