namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ArcsinTest
    {
        [TestCase(1, 1.570)]
        [TestCase(0, 0.000)]
        [TestCase(-1, -1.570)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Arcsin();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
