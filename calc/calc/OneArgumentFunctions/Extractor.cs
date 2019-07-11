using System;

namespace calc
{
    public class Extractor : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            if (firstNumber < 0)
            {
                throw new Exception("Х не должен быть отрицательным");
            }
          return Math.Sqrt(firstNumber);
        }
    }
}
