using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, OOP_lab_1_3_1.Program.C(3, 4));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(12, OOP_lab_1_3_1.Program.P(3, 4));
        }
    }
}
