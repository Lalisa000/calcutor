using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    using System.Runtime.Remoting.Messaging;

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
                case "arctg":
                    return new Arctan();
                case "arcctg":
                    return new Arcctan();
                case "abs":
                    return new Abs();
                case "reverse":
                    return new Reverse();
                case "ln":
                    return new NaturalLog();
                case "exp":
                    return new Exp();
                case "two":
                    return new Two();
                case "logtwo":
                    return new LogTwo();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
