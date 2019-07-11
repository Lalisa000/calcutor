using System;

namespace calc
{
    public class Arctan : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления значения арктангенса
        /// </summary>
        /// <param name="firstNumber"> аргумент функции </param>
        /// <returns> возвращение значения арктангенса </returns>
        public double calculate(double firstNumber)
        {
            return Math.Atan(firstNumber);
        }
    }
}
