using System;

namespace calc
{
    public class LogTwo : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления значения логарифма с основанием два 
        /// </summary>
        /// <param name="firstNumber"> число, которому будет равен логарифм </param>
        /// <returns> вовращение результата операции </returns>
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
