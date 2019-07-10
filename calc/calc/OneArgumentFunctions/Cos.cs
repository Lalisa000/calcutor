using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Cos : IOneArgumentCalculator
    {
        double IOneArgumentCalculator.calculateE(double firstNumber)
        {
            return Math.Cos(firstNumber);
        }
    }
}
