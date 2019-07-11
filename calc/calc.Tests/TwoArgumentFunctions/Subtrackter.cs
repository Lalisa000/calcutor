﻿namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class SubtrackterTest
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Subtrackter();
            double actual = calculator.calculate(6, 3);
            Assert.AreEqual(3, actual, 0.00);
        }
    }
}
