using System;
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
                //case "summary":
                //    return new Additioner();
                //case "subtraction":
                //    return new Subtrackter();
                //case "multiplication":
                //    return new Multiplicator();
                //case "division":
                //    return new Divisioner();
                case "extraction":
                    return new Extractor();
                case "exponentiating":
                    return new Exponentor();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
