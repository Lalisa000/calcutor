using System;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ArccosTest
    {
        [TestCase(1, 0.000)]
        [TestCase(-1, 3.141)]
        [TestCase(0, Math.PI/2)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Arccos();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
