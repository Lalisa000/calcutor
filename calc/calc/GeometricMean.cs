using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class GeometricMean : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber)
        {
            return Math.Sqrt(firstNumber*secondNumber);
        }
    }
}
