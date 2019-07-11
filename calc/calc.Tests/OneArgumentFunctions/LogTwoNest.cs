namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class LogTwoTest
    {
        [TestCase(2, 1)]
        [TestCase(4, 2)]
        [TestCase(8, 3)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new LogTwo();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
