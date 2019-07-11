using System;

namespace calc
{
    public class NaturalLog : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления значения натурального логарифма
        /// </summary>
        /// <param name="firstNumber"> число, которому равно значение логарифма </param>
        /// <returns> вовращение результата операции </returns>
        public double calculate(double firstNumber)
        {
            if (firstNumber <= 0)
            {
                throw new Exception("Х должен быть положитедьным");
            }
            return Math.Log(firstNumber, Math.E);
        }
    }
}
