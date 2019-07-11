namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class Degree10Test
    {
        [TestCase(1, 10)]
        [TestCase(0, 1)]
        [TestCase(2, 100)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Degree10();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
