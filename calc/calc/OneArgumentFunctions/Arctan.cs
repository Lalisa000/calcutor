using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Arctan : IOneArgumentCalculator
    {
        public double calculateE(double firstNumber)
        {
            return 1/Math.Atan(firstNumber);
        }
    }
}
