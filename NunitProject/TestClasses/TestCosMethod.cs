using NUnit.Framework;
using System;

namespace NunitProject.TestClasses
{
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class TestCosMethod : BaseTest
    {
        [TestCase(0, 1)]
        [TestCase(60, 0.5)]
        [TestCase(-60, 0.5)]
        [TestCase(90, 0)]
        public void TestCosMethodForInteger(int input, double expectedResult)
        {
            var actualResult = Math.Round(calculator.Cos((input * Math.PI) / 180), 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 1)]
        [TestCase(60, 0.5)]
        [TestCase(90, 0)]
        [TestCase(-90, 0)]
        public void TestCosMethodForDouble(double input, double expectedResult)
        {
            var actualResult = Math.Round(calculator.Cos((input * Math.PI) / 180), 1);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("0", 1)]
        [TestCase("1.05", 0.5)]
        [TestCase(" 1.57", 0)]
        [TestCase("-1.57 ", 0)]
        public void TestCosMethodForString(string input, double expectedResult)
        {
            var actualResult = Math.Round(calculator.Cos(input), 1);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
