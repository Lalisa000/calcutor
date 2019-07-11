using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ArctanTest
    {
        [TestCase(1, 0.785)]
        [TestCase(0, 0.000)]
        [TestCase(-1, -0.785)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Arctan();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
