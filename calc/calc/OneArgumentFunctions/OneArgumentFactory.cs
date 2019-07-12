using System;

namespace calc
{
    public static class OneArgumentFactory
    {
        /// <summary>
        /// фабрика для функций с одним аргументом: логарифмические, тригонометрические и т.д.
        /// </summary>
        /// <param name="name"> выбор конпки </param>
        /// <returns> вовращение завершенных вычислений </returns>
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
                case "Degree10":
                    return new Degree10();
                case "Negative":
                    return new Negative();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
