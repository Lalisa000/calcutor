using System;

namespace calc
{
    public class Divisioner : ITwoArgumentsCalculator
    {
        /// <summary>
        /// функция для вычисления частного двух чисел
        /// </summary>
        /// <param name="firstNumber"> делимое </param>
        /// <param name="secondNumber"> делитель </param>
        /// <returns> вовращение значения частного </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new Exception("Деление на ноль запрещено!");
            }
            return firstNumber / secondNumber;
        }
    }
}
