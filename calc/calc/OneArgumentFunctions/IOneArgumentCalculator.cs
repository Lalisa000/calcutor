namespace calc
{
    public interface IOneArgumentCalculator
    {
        /// <summary>
        /// calculate functions with one argument
        /// </summary>
        /// <param name="firstNumber"> argument of function </param>
        /// <returns></returns>
        double calculate(double firstNumber);
    }
}
