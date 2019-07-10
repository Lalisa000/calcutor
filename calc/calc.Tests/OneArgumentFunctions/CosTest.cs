using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CosTest
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Cos();
            double actual = calculator.calculate(1);
            Assert.AreEqual(1, actual, 0.00);
        }
    }
}
