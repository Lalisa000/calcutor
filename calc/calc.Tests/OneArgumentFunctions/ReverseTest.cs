﻿using System;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ReverseTest
    {
        [TestCase(1, 1)]
        [TestCase(2, 0.5)]
        [TestCase(100, 0.01)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Reverse();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }

        [Test]
        public void NegativeReverseTest()
        {
            var calculator = new Reverse();
            Assert.Throws<Exception>(() => calculator.calculate(0));
        }
    }
}
