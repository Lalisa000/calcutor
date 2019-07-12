using System;

namespace calc
{
    public class NaturalLog : IOneArgumentCalculator
    {
        /// <summary>
        /// function to calculate the value of the natural logarithm
        /// </summary>
        /// <param name="firstNumber"> the number, which is set to log </param>
        /// < / / / <returns> returns the result of the operation </returns>
        public double calculate(double firstNumber)
        {
            if (firstNumber <= 0)
            {
                throw new Exception("Х должен быть положительным");
            }
            return Math.Log(firstNumber, Math.E);
        }
    }
}
