using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool checkResult = IntegrationLab.Form1.checkAge(21);
            Assert.AreEqual(true, checkResult);
                
        }
    }
}
