using System;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class DivisionerTest
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Divisioner();
            double actual = calculator.calculate(6, 3);
            Assert.AreEqual(2, actual, 0.00);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            var calculator = new Divisioner();
            Assert.Throws<Exception>(() => calculator.calculate(1, 0));
        }
    }
}
