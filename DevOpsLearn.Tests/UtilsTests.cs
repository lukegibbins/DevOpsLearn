using DevOpsLearn.Utils;
using NUnit.Framework;

namespace DevOpsLearn.Tests
{
    [TestFixture]
    public class UtilsTests
    {
        [Test]
        public void ShouldReturnCorrectValueFromCalculator_Addition()
        {
            int num1 = 5;
            int num2 = 3;

            int total = Calculator.Addition(num1, num2);

            Assert.AreEqual(8, total);
        }
    }
}