using System;

namespace calc
{
    public class Extractor : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления квадратного корня
        /// </summary>
        /// <param name="firstNumber"> подкоренное выражение </param>
        /// <returns> возвращение результата </returns>
        public double calculate(double firstNumber)
        {
            if (firstNumber < 0)
            {
                throw new Exception("Х не должен быть отрицательным");
            }
          return Math.Sqrt(firstNumber);
        }
    }
}
