namespace calc
{
    public class Subtrackter : ITwoArgumentsCalculator
    {
        /// <summary>
        /// функция для вычисления разности двух чисел
        /// </summary>
        /// <param name="firstNumber"> уменьшаемое </param>
        /// <param name="secondNumber"> вычитаемое </param>
        /// <returns> возвращение разности </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
