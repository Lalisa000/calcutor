using System;

namespace calc
{
    
    public class Arcctan : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления арккотангенса
        /// </summary>
        /// <param name="firstNumber"> аргумент функции </param>
        /// <returns> возвращение значения арккотангенса </returns>
        public double calculate(double firstNumber)
        {
            return Math.PI/2 - Math.Atan(firstNumber);
        }
    }
}
