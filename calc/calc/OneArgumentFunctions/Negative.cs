namespace calc
{
    public class Negative : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return (-firstNumber);
        }
    }
}
