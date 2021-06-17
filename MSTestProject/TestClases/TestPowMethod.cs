using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject.TestClases
{
    [TestClass]
    public class TestPowMethod
    {
        public static Calculator calculator;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(3, 0, 1)]
        [DataRow(-3, 3, -27)]
        [DataRow(0, 100, 0)]
        [DataRow(3, -1, (1 / 3))]
        public void TestPowMethodForInteger(int number, int power, double expectedResult)
        {
            var actualResult = calculator.Pow(number, power);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(2.5, 2, 6.25)]
        [DataRow(-2.5, 2, 6.25)]
        [DataRow(3.33, 0, 1)]
        [DataRow(10.5, -1, (1 / 10.5))]
        public void TestPowMethodForDouble(double number, double power, double expectedResult)
        {
            var actualResult = calculator.Pow(number, power);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow("2", "2", 4)]
        [DataRow("3", "0", 1)]
        [DataRow("-3", "3", -27)]
        [DataRow("0", "100", 0)]
        [DataRow("3", "-1", "(1 / 3)")]
        public void TestPowMethodForString(string number, string power, double expectedResult)
        {
            var actualResult = calculator.Pow(number, power);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
