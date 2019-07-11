using System;

namespace calc
{
    public class Exponentor : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления квадрата числа
        /// </summary>
        /// <param name="firstNumber"> значение основания </param>
        /// <returns> возвращения результата операции </returns>
        public double calculate(double firstNumber)
        {
            return Math.Pow(firstNumber, 2);
        }
    }
}
