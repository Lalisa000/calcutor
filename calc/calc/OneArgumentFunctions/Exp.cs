using System;

namespace calc
{
    public class Exp : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления степени экспоненты
        /// </summary>
        /// <param name="firstNumber"> значение степени </param>
        /// <returns> возвращение результата возведения экспоненты в степень </returns>
        public double calculate(double firstNumber)
        {
            return Math.Exp(firstNumber);
        }
    }
}
