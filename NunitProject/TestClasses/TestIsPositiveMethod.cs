using NUnit.Framework;

namespace NunitProject.TestClasses
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class TestIsPositiveMethod : BaseTest
    {
        [TestCase(3, true)]
        [TestCase(-5, false)]
        [TestCase(-(-10), true)]
        [TestCase((-10), false)]
        public void TestIsPositiveMethodForInteger(int input, bool expectedResult)
        {
            var actualResult = calculator.isPositive(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3.5, true)]
        [TestCase(-5.65, false)]
        [TestCase(-(-10.7), true)]
        [TestCase((-10.7), false)]
        public void TestIsPositiveMethodForDouble(double input, bool expectedResult)
        {
            var actualResult = calculator.isPositive(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3.36598, true)]
        [TestCase(-5456987, false)]
        [TestCase(-(-10.336521), true)]
        [TestCase((-10.336521), false)]
        public void TestIsPositiveMethodForDecimal(decimal input, bool expectedResult)
        {
            var actualResult = calculator.isPositive(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("3", true)]
        [TestCase("-5", false)]
        [TestCase("-(-10)", true)]
        [TestCase(" 10)", true)]
        [TestCase("-10 ", false)]
        public void TestIsPositiveMethodForString(string input, bool expectedResult)
        {
            var actualResult = calculator.isPositive(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
