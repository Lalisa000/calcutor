namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class AdditionerTest
    {
        [Test]
        public void CalculationTest()
        {
            var calculator = new Additioner();
            double actual = calculator.calculate(2, 3);
            Assert.AreEqual(5, actual, 0.00);
        }
    }
}
