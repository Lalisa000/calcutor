namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class PowerOfTwoTest
    {
        [TestCase(1, 2)]
        [TestCase(0, 1)]
        [TestCase(4, 16)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new PowerOfTwo();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
