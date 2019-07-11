using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests.TwoArgumentFunctions
{
    using NUnit.Framework;

    [TestFixture]
    public class DegreeTest
    {
        [TestCase(1, 10, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(2, 2, 4)]
        public void CalculationTest(double value, double value2, double answer)
        {
            var calculator = new Degree();
            double actual = calculator.calculate(value, value2);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
