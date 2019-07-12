namespace calc
{
    public class Additioner : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function to calculate the sum
        /// </summary>
        /// <param name="firstNumber"> first term </param>
        /// <param name="secondNumber"> second term </param>
        /// < /// <returns> return the result </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
