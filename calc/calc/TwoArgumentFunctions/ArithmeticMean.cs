namespace calc
{
    public class ArithmeticMean : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function for calculating the arithmetic root
        /// </summary>
        /// <param name="firstNumber"> first term </param>
        /// <param name="secondNumber"> second term </param>
        /// < / / / <returns> return operation value </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber) / 2;
        }
    }
}
