using System;

namespace calc
{
    public class Arccos : IOneArgumentCalculator
    {
        /// <summary>
        /// function to calculate the arccosine of a number
        /// </summary>
        /// <<param name="first Number"> function argument </param>
        /// <returns> returns the value of the arccos </returns>
        public double calculate(double firstNumber)
        {
            if (firstNumber > 1 || firstNumber < -1)
            {
                throw new Exception("Х должен лежать в интервале (-1;1)");
            }
            return Math.Acos(firstNumber);
        }
    }
}
