using System;

namespace calc
{
    public class Sin : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления синуса
        /// </summary>
        /// <param name="firstNumber"> значение аргумента синуса </param>
        /// <returns> возвращение результата вычислений </returns>
        public double calculate(double firstNumber)
        {
            return Math.Sin(firstNumber);
        }
    }
}
