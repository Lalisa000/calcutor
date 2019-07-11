namespace calc
{
    public class Multiplicator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// функция умножения двух чисел 
        /// </summary>
        /// <param name="firstNumber"> первый множитель </param>
        /// <param name="secondNumber"> второй множитель </param>
        /// <returns> возвращение результата произведения двух чисел </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
