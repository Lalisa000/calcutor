﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Arcctan : IOneArgumentCalculator
    {
        public double calculate(double firstNumber)
        {
            return Math.PI/2 - Math.Atan(firstNumber);
        }
    }
}
