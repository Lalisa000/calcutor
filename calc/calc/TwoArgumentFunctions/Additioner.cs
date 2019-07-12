namespace calc
{
    public class Additioner : ITwoArgumentsCalculator
    {
        /// <summary>
        /// функция для вычисления суммы
        /// </summary>
        /// <param name="firstNumber"> первое слагаемое </param>
        /// <param name="secondNumber"> второе слагаемое </param>
        /// <returns> вовращение результата суммы </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
