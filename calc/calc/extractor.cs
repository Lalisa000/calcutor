using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Extractor : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber)
        {
            return Math.Sqrt(firstNumber);
        }
    }
}
