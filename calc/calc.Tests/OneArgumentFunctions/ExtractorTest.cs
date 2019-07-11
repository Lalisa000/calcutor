namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
        public class ExtractorTest
    {
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(16, 4)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Extractor();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.00);
        }
    }
}

