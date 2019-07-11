using System;

namespace calc
{
    public class Arccos : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления арккосинуса числа
        /// </summary>
        /// <param name="firstNumber"> аргумент функции </param>
        /// <returns> возвращения значения арккосинуса </returns>
        public double calculate(double firstNumber)
        {
            if (firstNumber > 1 || firstNumber < -1)
            {
                throw new Exception("Х должен лежать в интервале (-1;1)");
            }
            return Math.Acos(firstNumber);
        }
    }
}
