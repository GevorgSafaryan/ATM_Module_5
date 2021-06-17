using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject.TestClases
{
    [TestClass]
    public class TestSubMethod
    {
        public static Calculator calculator;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(5, 1, 4)]
        [DataRow(5, 7, -2)]
        [DataRow(-5, -1, -4)]
        [DataRow(5, -1, 6)]
        public void TestSubMethodForInteger(int minuend, int subtrahend, double expectedResult)
        {
            var actualResult = calculator.Sub(minuend, subtrahend);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(5.45, 1.35, 4.1)]
        [DataRow(5.5, 7.4, -1.9)]
        [DataRow(-5.7, -1.5, -4.2)]
        [DataRow(5.95, -1.05, 7)]
        public void TestSubMethodForDouble(double minuend, double subtrahend, double expectedResult)
        {
            var actualResult = calculator.Sub(minuend, subtrahend);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(5.45659, 1.35987, 4.09672)]
        [DataRow(5.5556698, 7.4489567, -1.8932869)]
        public void TestSubMethodForDecimal(decimal minuend, decimal subtrahend, double expectedResult)
        {
            var actualResult = calculator.Sub(minuend, subtrahend);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow("5.45", "1.35", 4.1)]
        [DataRow("5.5", "7.4", -1.9)]
        [DataRow("-5.7", "-1.5", -4.2)]
        [DataRow("5.95", "-1.05", 7)]
        public void TestSubMethodForString(string minuend, string subtrahend, double expectedResult)
        {
            var actualResult = calculator.Sub(minuend, subtrahend);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
