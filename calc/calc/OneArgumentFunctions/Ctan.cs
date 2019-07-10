using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Ctan : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return 1/Math.Tan(firstNumber);
        }
    }
}
