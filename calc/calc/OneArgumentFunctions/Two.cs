using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Two : IOneArgumentCalculator
    {
        double IOneArgumentCalculator.calculateE(double firstNumber)
        {
            return Math.Pow(2, firstNumber);
        }
    }
}
