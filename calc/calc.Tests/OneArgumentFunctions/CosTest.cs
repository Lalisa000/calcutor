namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CosTest
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Cos();
            double actual = calculator.calculate(0);
            Assert.AreEqual(1, actual, 0.00);
        }
    }
}
