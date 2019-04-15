using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Martin_G_Praktika_Forms;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestWriting()
        {
            int expected = 1; // Expected amount of nodes after adding one
            int got = TestMethods.testWriting1();
            Assert.AreEqual(got, expected);
            TestMethods.clean();
        }
        
        [TestMethod]
        public void TestReading()
        {
            string expected = "value";
            string got = TestMethods.testReading();
            Assert.AreEqual(got, expected);
            TestMethods.clean();

        }


    }
}
