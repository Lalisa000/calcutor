namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ExponentorTest
    {
        [TestCase(2, 4)]
        [TestCase(8, 64)]
        [TestCase(12, 144)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Exponentor();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
