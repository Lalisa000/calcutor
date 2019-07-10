using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Extractor : IOneArgumentCalculator
    {
        public double calculateE(double firstNumber)
        {
            return Math.Sqrt(firstNumber);
        }
    }
}
