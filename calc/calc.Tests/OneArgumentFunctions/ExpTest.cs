namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ExpTest
    {
        [TestCase(1, 2.718)]
        [TestCase(0, 1)]
        [TestCase(2, 7.389)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Exp();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
