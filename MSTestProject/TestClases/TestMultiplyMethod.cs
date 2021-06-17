using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject.TestClases
{
    [TestClass]
    public class TestMultiplyMethod
    {
        public static Calculator calculator;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(3, 2, 6)]
        [DataRow(3, 0, 0)]
        [DataRow(-3, -4, 12)]
        [DataRow(-3, 4, -12)]
        public void TestMultiplyMethodForInteger(int firstMultiplier, int secondMultiplier, double expectedResult)
        {
            var actualResult = calculator.Multiply(firstMultiplier, secondMultiplier);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(3.5, 2.7, (3.5 * 2.7))]
        [DataRow(3.99, 0.00, 0)]
        [DataRow(-3.5, -2.7, 9.45)]
        [DataRow(-3.5, 2.7, 9.45)]
        [DataRow(double.MaxValue, 2.7, double.PositiveInfinity)]
        public void TestMultiplyMethodForDouble(double firstMultiplier, double secondMultiplier, double expectedResult)
        {
            double actualResult = calculator.Multiply(firstMultiplier, secondMultiplier);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
