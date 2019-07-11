namespace calc
{
    public class ArithmeticMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// функция для вычисления арифметического корня
        /// </summary>
        /// <param name="firstNumber"> первое слагаемое </param>
        /// <param name="secondNumber">  второе слагаемое </param>
        /// <returns> вовращение значения операции </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber) / 2;
        }
    }
}
