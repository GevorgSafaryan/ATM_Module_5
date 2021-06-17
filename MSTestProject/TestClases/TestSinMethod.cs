using System;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject.TestClases
{
    [TestClass]
    public class TestSinMethod
    {
        public static Calculator calculator;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(30, 0.5)]
        [DataRow(90, 1)]
        [DataRow(-90, -1)]
        public void TestSinMethodForInteger(int input, double expectedResult)
        {
            var actualResult = Math.Round(calculator.Sin((input * Math.PI) / 180), 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(30, 0.5)]
        [DataRow(90, 1)]
        [DataRow(-90, -1)]
        public void TestSinMethodForDouble(double input, double expectedResult)
        {
            var actualResult = Math.Round(calculator.Sin((input * Math.PI) / 180), 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow("0", 0)]
        [DataRow("0.52", 0.5)]
        [DataRow(" 1.57", 1)]
        [DataRow("-1.57 ", -1)]
        public void TestSinMethodForString(string input, double expectedResult)
        {
            var actualResult = Math.Round(calculator.Sin(input), 1);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
