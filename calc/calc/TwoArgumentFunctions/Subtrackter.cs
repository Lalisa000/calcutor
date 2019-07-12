namespace calc
{
    public class Subtrackter : ITwoArgumentsCalculator
    {
        /// <summary>
        /// function to calculate the difference between two numbers
        /// </summary>
        /// <param name="firstNumber"> miniaturized </param>
        /// <param name="secondNumber"> subtracted </param>
        /// <returns> return difference </returns>
        public double calculate(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
