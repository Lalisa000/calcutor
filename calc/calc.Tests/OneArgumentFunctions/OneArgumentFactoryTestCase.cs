using NUnit.Framework;
using System;

namespace calc.Tests
{
    [TestFixture]
    public class OneArgumentFactoryTestCase
    {
        [TestCase("abs", typeof(Abs))]
        [TestCase("acos", typeof(Arccos))]
        [TestCase("arcctg", typeof(Arcctan))]
        [TestCase("asin", typeof(Arcsin))]
        [TestCase("arctg", typeof(Arctan))]
        [TestCase("cos", typeof(Cos))]
        [TestCase("ctan", typeof(Ctan))]
        [TestCase("Degree10", typeof(Degree10))]
        [TestCase("exp", typeof(Exp))]
        [TestCase("exponentiating", typeof(Exponentor))]
        [TestCase("extraction", typeof(Extractor))]
        [TestCase("logtwo", typeof(LogTwo))]
        [TestCase("ln", typeof(NaturalLog))]
        [TestCase("Negative", typeof(Negative))]
        [TestCase("reverse", typeof(Reverse))]
        [TestCase("sin", typeof(Sin))]
        [TestCase("tan", typeof(Tan))]
        [TestCase("two", typeof(PowerOfTwo))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }

    }
}
