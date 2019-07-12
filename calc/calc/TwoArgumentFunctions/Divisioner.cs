using System;

namespace calc
{
    public class Divisioner : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function to calculate the quotient of two numbers
        /// </summary>
        /// <param name="firstNumber"> divisible </param>
        /// <param name="secondNumber"> divider </param>
        /// < /// <returns> return private value </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new Exception("Деление на ноль запрещено!");
            }
            return firstNumber / secondNumber;
        }
    }
}
