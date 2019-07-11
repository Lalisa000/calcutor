using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class NegativeTest
    {
        [TestCase(1, -1)]
        [TestCase(10, -10)]
        [TestCase(2, -2)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Negative();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
