using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CtanTest
    {
        [TestCase(1, 0.642)]
        [TestCase(0.5, 1.830)]
        [TestCase(-1, -0.642)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Ctan();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
