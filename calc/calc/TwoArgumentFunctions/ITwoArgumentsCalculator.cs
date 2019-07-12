namespace calc
{
    public interface ITwoArgumentsCalculator
    {
        /// <summary>
        /// calculate functions with two arguments
        /// </summary>
        /// <param name="firstNumber"> first argument </param>
        /// <param name="secondNumber"> second argument </param>
        /// <returns></returns>
        double calculate(double firstNumber, double secondNumber);
    }
}
