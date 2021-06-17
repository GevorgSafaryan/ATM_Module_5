using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject.TestClases
{
    [TestClass]
    public class TestSqrtMethod
    {
        public static Calculator calculator;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(16, 4)]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(-5, double.NaN)]
        public void TestSqrtMethodForInteger(int input, double expectedResult)
        {
            var actualResult = calculator.Sqrt(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(6.25, 2.5)]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(-5, double.NaN)]
        [DataRow(double.NaN, double.NaN)]
        [DataRow(double.PositiveInfinity, double.PositiveInfinity)]
        public void TestSqrtMethodForDouble(double input, double expectedResult)
        {
            var actualResult = calculator.Sqrt(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow("16", 4)]
        [DataRow("0", 0)]
        [DataRow("1", 1)]
        [DataRow("-5", double.NaN)]
        public void TestSqrtMethodForString(string input, double expectedResult)
        {
            var actualResult = calculator.Sqrt(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
