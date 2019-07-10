using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Arcctan : IOneArgumentCalculator
    {
        public double calculateE(double firstNumber)
        {
            return Math.Atan(firstNumber);
        }
    }
}
