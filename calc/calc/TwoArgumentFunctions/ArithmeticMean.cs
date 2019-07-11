﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class ArithmeticMean : ITwoArgumentsCalculator
    {
        public double calculate(double firstNumber, double secondNumber)
        {
            return (firstNumber + secondNumber) / 2;
        }
    }
}