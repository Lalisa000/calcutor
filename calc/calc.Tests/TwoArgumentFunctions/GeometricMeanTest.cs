﻿using System;

namespace calc.Tests.TwoArgumentFunctions
{
    using NUnit.Framework;

    [TestFixture]
    public class GeometricMeanTest
    {
        [TestCase(1, 9, 3)]
        [TestCase(1, 0, 0)]
        [TestCase(2, 2, 2)]
        public void CalculationTest(double value, double value2, double answer)
        {
            var calculator = new GeometricMean();
            double actual = calculator.calculate(value, value2);
            Assert.AreEqual(answer, actual, 0.001);
        }

        [Test]
        public void NegativeGeometricMeanTest()
        {
            var calculator = new GeometricMean();
            Assert.Throws<Exception>(() => calculator.calculate(-1, 1));
        }
    }
}
