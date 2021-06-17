using NUnit.Framework;
using CSharpCalculator;

namespace NunitProject.TestClasses
{
    public class BaseTest
    {
        public Calculator calculator;

        [OneTimeSetUp]
        public void Init()
        {
            calculator = new Calculator();
        }
    }
}
