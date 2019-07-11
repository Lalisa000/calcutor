namespace calc
{
    public class Negative : IOneArgumentCalculator
    {
        /// <summary>
        /// функция для вычисления противоположного значения числа
        /// </summary>
        /// <param name="firstNumber"> аргумент функции </param>
        /// <returns> возвращение числа с противоположным знаком </returns>
        public double calculate(double firstNumber)
        {
            return (-firstNumber);
        }
    }
}
