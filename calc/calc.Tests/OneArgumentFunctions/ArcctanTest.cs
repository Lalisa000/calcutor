namespace calc.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ArcctanTest
    {
        [TestCase(1, 0.785)]
        [TestCase(0, 1.570)]
        [TestCase(-1, 2.356)]
        public void CalculationTest(double value, double answer)
        {
            var calculator = new Arcctan();
            double actual = calculator.calculate(value);
            Assert.AreEqual(answer, actual, 0.001);
        }
    }
}
