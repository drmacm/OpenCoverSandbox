using IBll;
using NUnit.Framework;

namespace Bll.Tests
{
    [TestFixture]
    public class TestBllTests
    {
        private ITestBll testBll;

        [SetUp]
        public void SetUp()
        {
            testBll = new TestBll();
        }

        [Test]
        public void Method1_IdLessThan100_ShouldReturnIdMultipliedBy2()
        {
            var result = testBll.Method1(6);

            Assert.AreEqual(12, result);
        }
    }
}
