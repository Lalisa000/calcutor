﻿using System;

namespace calc
{
    public class Tan : IOneArgumentCalculator
    {
        /// <summary>
        /// a function to calculate the tangent
        /// </summary>
        /// <param name="firstNumber"> tangent argument value </param>
        /// <returns> return the result of the operation </returns>
        public double calculate(double firstNumber)
        {
            return Math.Tan(firstNumber);
        }
    }
}
