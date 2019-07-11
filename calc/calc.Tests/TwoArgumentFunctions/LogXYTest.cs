using System;

namespace calc.Tests.TwoArgumentFunctions
{
    using NUnit.Framework;

    [TestFixture]
    public class LogXYTest
    {
        [TestCase(3, 3, 1)]
        [TestCase(2, 4, 2)]
        [TestCase(2, 8, 3)]
        public void CalculationTest(double value, double value2, double answer)
        {
            var calculator = new LogXY();
            double actual = calculator.calculate(value, value2);
            Assert.AreEqual(answer, actual, 0.001);
        }

        [Test]
        public void NegativeLogXYTest()
        {
            var calculator = new LogXY();
            Assert.Throws<Exception>(() => calculator.calculate(0, -1));
        }
    }
}
