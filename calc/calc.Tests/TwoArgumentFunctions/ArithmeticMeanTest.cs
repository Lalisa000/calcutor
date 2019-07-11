 

namespace calc.Tests.TwoArgumentFunctions
{
    using NUnit.Framework;

    [TestFixture]
    public class ArithmeticMeanTest
    {
        [TestCase(1, 3, 2)]
        [TestCase(0, 2, 1)]
        [TestCase(2, -6, -2)]
        public void CalculationTest(double value, double value2, double answer)
        {
            var calculator = new ArithmeticMean();
            double actual = calculator.calculate(value, value2);
            Assert.AreEqual(answer, actual, 0.001);
        }

    }
}
