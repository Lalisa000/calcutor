using System;

namespace calc
{
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// фабрика для функций с двумя аргументами: сложение, вычитание, деление, умножение и т.д.
        /// </summary>
        /// <param name="name"> выбор кнопки </param>
        /// <returns> вовращение завершенных вычислений </returns>
        public static ITwoArgumentsCalculator CreateCalculator(String name)
        {
            switch (name)
            {
                case "summary":
                    return new Additioner();
                case "subtraction":
                    return new Subtrackter();
                case "multiplication":
                    return new Multiplicator();
                case "division":
                    return new Divisioner();
                case "geomMean":
                    return new GeometricMean();
                case "arithmMean":
                    return new ArithmeticMean();
                case "Degree":
                    return new Degree();
                case "LogXY":
                    return new LogXY();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
