using DevOpsLearn.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevOpsLearn.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldReturnCorrectValueFromCalculator_Addition()
        {
            int num1 = 5;
            int num2 = 3;

            int total = Calculator.Addition(num1, num2);

            Assert.AreEqual(8, total);
        }
    }
}
