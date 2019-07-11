using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class TwoTest
    {
        [TestCase(1, 2)]
        [TestCase(0, 1)]
        [TestCase(4, 16)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Two();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
