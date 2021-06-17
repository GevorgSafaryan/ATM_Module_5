using NUnit.Framework;

namespace NunitProject.TestClasses
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class TestDevideMethod : BaseTest
    {
        [TestCase(10, 2, 5)]
        [TestCase(35, -7, -5)]
        [TestCase(-20, -2, 10)]
        [TestCase(0, -2, 0)]
        [TestCase(15, 0, double.PositiveInfinity)]
        public void TestdevideMethodForInteger(int divident, int devider, double expectedResult)
        {
            var actualResult = calculator.Divide(divident, devider);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(21.6745, 3.35, 6.47)]
        [TestCase(-14.4, -3.2, 4.5)]
        [TestCase(14.4, -3.2, -4.5)]
        [TestCase(0.00, -3.2, 0.00)]
        [TestCase(12.32, 0, double.PositiveInfinity)]
        public void TestDevideMethodForDouble(double divident, double devider, double expectedResult)
        {
            var actualResult = calculator.Divide(divident, devider);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
