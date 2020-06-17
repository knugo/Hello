using Hello;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello World!", Program.CreateMassage01());

            Assert.AreEqual("Hello World!", Program.CreateMassage01());

            Assert.AreEqual("Hello World!", Program.CreateMassage01());

            Assert.AreEqual("Hello World!", Program.CreateMassage01());

            Assert.AreEqual("Hello World!", Program.CreateMassage01());

            Assert.AreEqual("Hello World!", Program.CreateMassage01());

            Assert.AreEqual("Hello World!", Program.CreateMassage01());

        }
    }
}
