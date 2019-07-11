﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Degree10 : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.Pow(10, firstNumber);
        }
    }
}
