using System;

namespace calc
{
    public class Tan : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления тангенса
        /// </summary>
        /// <param name="firstNumber"> значение аргумента тангенса </param>
        /// <returns> вовращение результата операции </returns>
        public double calculate(double firstNumber)
        {
            return Math.Tan(firstNumber);
        }
    }
}
