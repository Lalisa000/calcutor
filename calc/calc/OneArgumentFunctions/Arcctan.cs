using System;

namespace calc
{

    public class Arcctan : IOneArgumentCalculator
    {
        /// <summary>
        /// a function for computing the arctangent
        /// </summary>
        ///<<param name = "first Number" > function argument</param>
        /// <returns> the return value of the arccot </returns>
        public double calculate(double firstNumber)
        {
            return Math.PI / 2 - Math.Atan(firstNumber);
        }
    }
}
