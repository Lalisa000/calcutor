using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class AbsTest
    {
        [TestCase(-2, 2)]
        [TestCase(-3, 3)]
        [TestCase(-4, 4)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Abs();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.00);
        }
    }
}
