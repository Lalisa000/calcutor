namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class MultiplicatorTest
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Multiplicator();
            double actual = calculator.calculate(2, 3);
            Assert.AreEqual(6, actual, 0.00);
        }
    }
}
