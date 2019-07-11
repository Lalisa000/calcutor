using System;

namespace calc
{
    public class Two : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления значения двойки в какой-либо степени
        /// </summary>
        /// <param name="firstNumber"> значение степени </param>
        /// <returns> возвращение результата операции </returns>
        public double calculate(double firstNumber)
        {
            return Math.Pow(2, firstNumber);
        }
    }
}
