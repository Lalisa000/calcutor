using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
