namespace calc
{
    public class ArithmeticMean : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber) / 2;
        }
    }
}
