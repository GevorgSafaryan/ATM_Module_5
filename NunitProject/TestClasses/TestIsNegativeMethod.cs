using NUnit.Framework;

namespace NunitProject.TestClasses
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class TestIsNegativeMethod : BaseTest
    {
        [TestCase(3, false)]
        [TestCase(-5, true)]
        [TestCase(-(-10), false)]
        public void TestIsNegativeMethodForInteger(int input, bool expectedResult)
        {
            var actualResult = calculator.isNegative(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3.5, false)]
        [TestCase(-5.65, true)]
        [TestCase(-(-10.7), false)]
        public void TestIsNegativeMethodForDouble(double input, bool expectedResult)
        {
            var actualResult = calculator.isNegative(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(3.36598, false)]
        [TestCase(-5456987, true)]
        [TestCase(-(-10.336521), false)]
        public void TestIsNegativeMethodForDecimal(decimal input, bool expectedResult)
        {
            var actualResult = calculator.isNegative(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("3", false)]
        [TestCase("-5", true)]
        [TestCase("-(-10)", false)]
        [TestCase("-10 ", true)]
        [TestCase(" 10", false)]
        public void TestIsNegativeMethodForString(string input, bool expectedResult)
        {
            var actualResult = calculator.isNegative(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
