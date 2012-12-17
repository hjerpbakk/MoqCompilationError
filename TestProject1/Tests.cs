using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestProject1
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IInterface>();

            mock.Setup(foo => foo.A(null)).Returns(1);
        }
    }
}
