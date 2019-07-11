using System;

namespace calc
{
    public class Cos : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления значения косинуса
        /// </summary>
        /// <param name="firstNumber"> аргумент функции </param>
        /// <returns> возвращение значения косинуса </returns>
        public double calculate(double firstNumber)
        {
            return Math.Cos(firstNumber);
        }
    }
}
