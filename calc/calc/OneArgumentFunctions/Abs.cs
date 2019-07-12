using System;

namespace calc
{
    public class Abs : IOneArgumentCalculator
    {
        /// <summary>
        /// module function
        /// </summary>
        /// <param name="firstNumber"> argument </param>
        /// <returns> number module return </returns>
        public double calculate(double firstNumber)
        {
            return Math.Abs(firstNumber);
        }
    }
}
