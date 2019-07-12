using System;

namespace calc
{
    public class LogXY : ITwoArgumentsCalculator
    {
        /// <summary>
        /// функция для вычисления значения логарифма с основанием Х
        /// </summary>
        /// <param name="firstNumber"> значение основания </param>
        /// <param name="secondNumber"> значение результата логарифмирования </param>
        /// <returns> возвращение результата операции </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            if (firstNumber <= 0 && firstNumber == 1)
            {
                throw new Exception("Х должен быть больше 0 и не равен 1!");
            }
            if (secondNumber <= 0)
            {
                throw new Exception("Y должен быть больше нуля");
            }
            return Math.Log(secondNumber, firstNumber);
        }
    }
}
