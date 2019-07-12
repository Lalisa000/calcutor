using System;

namespace calc
{
    public class LogXY : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function to calculate the logarithm value with base X
        /// </summary>
        /// <param name="firstNumber"> base value </param>
        /// <param name="secondNumber"> value of the log result </param>
        /// <returns> return the result of the operation </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            if (firstNumber <= 0 && firstNumber == 1)
            {
                throw new Exception("Х должен быть больше 0 и не равен 1!");
            }
            if (secondNumber <= 0)
            {
                throw new Exception("Y должен быть больше нуля");
            }
            return Math.Log(secondNumber, firstNumber);
        }
    }
}
