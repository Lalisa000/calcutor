using System;

namespace calc
{
    public class Degree10 : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления значения десяти в какой-лиюо степени
        /// </summary>
        /// <param name="firstNumber"> значения степени </param>
        /// <returns> возвращение значения результата </returns>
        public double calculate(double firstNumber)
        {
            return Math.Pow(10, firstNumber);
        }
    }
}

