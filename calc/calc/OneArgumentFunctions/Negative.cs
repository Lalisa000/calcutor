namespace calc
{
    public class Negative : IOneArgumentCalculator
    {
        /// <summary>
        /// function to calculate the opposite value of a number
        /// </summary>
        /// < /// <param name="first Number"> function argument </param>
        /// <returns> return a number with the opposite sign </returns>
        public double calculate(double firstNumber)
        {
            return (-firstNumber);
        }
    }
}
