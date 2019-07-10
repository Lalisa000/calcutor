using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Arccos : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Acos(firstNumber);
        }
    }
}
