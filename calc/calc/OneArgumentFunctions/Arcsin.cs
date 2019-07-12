using System;

namespace calc
{
    public class Arcsin : IOneArgumentCalculator
    {
        /// <summary>
        /// the function for calculating the arc sine
        /// </summary>
        /// < /// <param name="first Number"> function argument </param>
        /// <returns> return the value of the arcsine </returns>

        public double calculate(double firstNumber)
        {
            if (firstNumber > 1 || firstNumber < -1)
            {
                throw new Exception("Х должен лежать в интервале (-1;1)");
            }
            return Math.Asin(firstNumber);
        }
    }
}
