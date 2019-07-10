using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class DivisionerTest
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Divisioner();
            double actual = calculator.calculate(6, 3);
            Assert.AreEqual(2, actual, 0.00);
        }
    }
}
