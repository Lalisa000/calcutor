using System;

namespace calc
{
    public class Abs : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления модуля числа
        /// </summary>
        /// <param name="firstNumber"> аргумент функции </param>
        /// <returns> возвращение модуля числа </returns>
        public double calculate(double firstNumber)
        {
            return Math.Abs(firstNumber);
        }
    }
}
