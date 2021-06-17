using NUnit.Framework;

namespace NunitProject.TestClasses
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class TestAbsMethod : BaseTest
    {
        [TestCase(-5, 5)]
        [TestCase(3, 3)]
        public void TestAbsMethodForInteger(int input, double expectedResult)
        {
            var actualResult = calculator.Abs(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-5.57, 5.57)]
        [TestCase(3.45, 3.45)]
        [TestCase(-45.33, 45.33)]
        public void TestAbsMethodForDouble(double input, double expectedResult)
        {
            var actualResult = calculator.Abs(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-10.321654, 10.321654)]
        [TestCase(6.5496, 6.5496)]
        public void TestAbsMethodForDecimal(decimal input, double expectedResult)
        {
            var actualResult = calculator.Abs(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("-5.57", 5.57)]
        [TestCase("3", 3d)]
        [TestCase(" 3", 3d)]
        [TestCase("-53", 53d)]
        [TestCase("-534 ", 534d)]
        public void TestAbsMethodForString(string input, double expectedResult)
        {
            var actualResult = calculator.Abs(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
