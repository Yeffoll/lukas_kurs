using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kursach_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void test1()
        {
            int raz = 50;
            int dva = 50;
            int sum = 100;

            kursach.Form1 f = new kursach.Form1();

            int now = f.slojenie(raz, dva);

            Assert.AreEqual(sum, now);
          
        }
    }
}
