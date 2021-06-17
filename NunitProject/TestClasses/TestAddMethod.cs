using NUnit.Framework;

namespace NunitProject.TestClasses
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class TestAddMethod : BaseTest
    {
        [TestCase(20, 45, 65)]
        [TestCase(-27, -50, -77)]
        [TestCase(1500, -500, 1000)]
        public void TestAddMethodForInteger(int firstAddendum, int secondAddendum, double expectedResult)
        {
            var actualResult = calculator.Add(firstAddendum, secondAddendum);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(10.45, 15.55, 26)]
        [TestCase(-100.00, 53.01, -46.99)]
        [TestCase(-1001.03, -58.44, -1059.47)]
        public void TestAddMethodForDouble(double firstAddendum, double secondAddendum, double expectedResult)
        {
            var actualResult = calculator.Add(firstAddendum, secondAddendum);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(205.3265, 65.6985, 271.0223)]
        [TestCase(-21.36521, 47.26598, 25.90077)]
        [TestCase(-100.0003, -90.32186, -190.32216)]
        public void TestAddMethodForDecimal(decimal firstAddendum, decimal secondAddendum, double expectedResult)
        {
            var actualResult = calculator.Add(firstAddendum, secondAddendum);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("20", "45", 65)]
        [TestCase("-27", "-50", -77)]
        [TestCase("1500", "-500", 1000)]
        [TestCase(" 1500", "-500 ", 1000)]
        public void TestAddMethodForString(string firstAddendum, string secondAddendum, double expectedResult)
        {
            var actualResult = calculator.Add(firstAddendum, secondAddendum);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
