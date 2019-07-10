using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class NaturalLog : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Log(firstNumber, Math.E);
        }
    }
}
