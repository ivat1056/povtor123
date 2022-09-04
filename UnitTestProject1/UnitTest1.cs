using Microsoft.VisualStudio.TestTools.UnitTesting;
using povtor;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] // юнит тестирование 
        public void TestMethod1()
        {
            double a = 20;
            double b = 5;
            double expected =25 ;
            win2 c = new win2();
            double d = c.testWin(b, a);
            Assert.AreEqual(expected,d);
        }
    }
}
