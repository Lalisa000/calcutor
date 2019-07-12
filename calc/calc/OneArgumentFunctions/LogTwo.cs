using System;

namespace calc
{
    public class LogTwo : IOneArgumentCalculator
    {
        /// <summary>
        /// a function to compute the value of the logarithm with base two 
        /// </summary>
        /// < /// <param name="first Number"> the number to be equal to the logarithm </param>
        /// < / / / <returns> returns the result of the operation </returns>
        public double calculate(double firstNumber)
        {
            if (firstNumber < 1)
            {
                throw new Exception("Х должен быть больше единицы!");
            }
            return Math.Log(firstNumber, 2);
        }
    }
}
