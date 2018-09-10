using Exam532Libs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exam532Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly RateManager manager = new RateManager();

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var expect = 2;

            // Action
            var result = 1 + 1;

            // Assert
            Assert.AreEqual(result, expect);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void ThrowExceptionWhenArgumentIsNull()
        {
            // Arrange
            string region = null;

            // Action
            var result = manager.LookupTaxRate(region);

            // Assert
        }
    }
}
