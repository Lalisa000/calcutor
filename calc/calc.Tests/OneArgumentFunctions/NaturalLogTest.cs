namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class NaturalLogTest
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.693)]
        [TestCase(3, 1.098)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new NaturalLog();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
