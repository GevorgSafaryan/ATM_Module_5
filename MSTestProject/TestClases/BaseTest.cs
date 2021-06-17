using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpCalculator;

namespace MSTestProject.TestClases
{
    public class BaseTest
    {
        public static Calculator calculator;

        [ClassInitialize]
        public static void Init(TestContext testContext)
        {
            calculator = new Calculator();
        }
    }
}
