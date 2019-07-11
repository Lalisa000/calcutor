namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class TanTest
    {
        [TestCase(1, 1.557)]
        [TestCase(0, 0.000)]
        [TestCase(-1, -1.557)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Tan();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
