using System;

namespace calc
{
    public class Ctan : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления котангенса
        /// </summary>
        /// <param name="firstNumber"> аргумент функции </param>
        /// <returns> возвращение значения котангенса </returns>
        public double calculate(double firstNumber)
        {
            return 1/Math.Tan(firstNumber);
        }
    }
}
