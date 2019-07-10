﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(String name)
        {
            switch (name)
            {
               
                case "extraction":
                    return new Extractor();
                case "exponentiating":
                    return new Exponentor();
                case "cos":
                    return new Cos();
                case "sin":
                    return new Sin();
                case "tan":
                    return new Tan();
                case "ctan":
                    return new Ctan();
                case "asin":
                    return new Arcsin();
                case "acos":
                    return new Arccos();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
