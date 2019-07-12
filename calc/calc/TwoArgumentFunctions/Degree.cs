using System;

namespace calc
{
    public class Degree : ITwoArgumentsCalculator
    {
        /// <summary>
        /// функция для вычисления значения числа Х в степени Y
        /// </summary>
        /// <param name="firstNumber"> значение основания </param>
        /// <param name="secondNumber"> значение степени </param>
        /// <returns> вовращение результата операции </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }
    }
}
