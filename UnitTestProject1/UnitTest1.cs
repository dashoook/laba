using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 7;
            int[] x = { 2, -3, -4, 10, -8, 3, 4};
            int s = 10;
            int result = LABA2._3._1.Program.suma(x,n);
            Assert.AreEqual(s, result);
        }
    }
}
