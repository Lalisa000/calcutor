using System;

namespace calc
{
    public class GeometricMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// функция для вычисления среднего геометрического
        /// </summary>
        /// <param name="firstNumber"> первый множитель </param>
        /// <param name="secondNumber"> второй множитель </param>
        /// <returns> возвращение результата операции </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            if (firstNumber < 0 || secondNumber < 0)
            {
                throw new Exception("Число под корнем должно быть положительным!");
            }
            return Math.Sqrt(firstNumber*secondNumber);
        }
    }
}
