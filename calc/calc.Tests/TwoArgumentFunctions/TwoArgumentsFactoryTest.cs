using NUnit.Framework;
using System;

namespace calc.Tests
{
    [TestFixture]
    public class TwoArgumentFactoryTestCase
    {
        [TestCase("summary", typeof(Additioner))]
        [TestCase("arithmMean", typeof(ArithmeticMean))]
        [TestCase("Degree", typeof(Degree))]
        [TestCase("division", typeof(Divisioner))]
        [TestCase("geomMean", typeof(GeometricMean))]
        [TestCase("LogXY", typeof(LogXY))]
        [TestCase("multiplication", typeof(Multiplicator))]
        [TestCase("subtraction", typeof(Subtrackter))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}
