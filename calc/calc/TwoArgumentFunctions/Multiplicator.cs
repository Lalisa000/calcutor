namespace calc
{
    public class Multiplicator : ITwoArgumentsCalculator
    {
        /// <summary>
        /// a function of multiplying two numbers 
        /// </summary>
        /// <param name="firstNumber"> first multiplier </param>
        /// <param name="secondNumber"> second multiplier </param>
        /// <returns> return the result of the product of two numbers </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
