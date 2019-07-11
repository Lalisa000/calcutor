using System;

namespace calc
{
    public class Reverse : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления обратного значения числа
        /// </summary>
        /// <param name="firstNumber"> аргумент функции </param>
        /// <returns> возвращение обратного значения аргумента </returns>
        public double calculate(double firstNumber)
        {
            if (firstNumber == 0)
            {
                throw new Exception("Делить на ноль нельзя!");
            }
            return 1 / firstNumber;
        }
    }
}
