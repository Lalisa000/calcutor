namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class SinTest
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Sin();
            double actual = calculator.calculate(0);
            Assert.AreEqual(0, actual, 0.00);
        }
    }
}
