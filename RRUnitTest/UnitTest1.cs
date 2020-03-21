using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RRUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RussianRoulette.GameClass test = new RussianRoulette.GameClass();

            int testResult = test.SpinLogic();

            Assert.IsTrue(testResult < 7 && testResult > 0);

        }

        [TestMethod]
        public void TestMethod2()
        {
            RussianRoulette.GameClass testshoot = new RussianRoulette.GameClass();

            int testResultshoot = testshoot.ShootLogic();

            Assert.IsTrue(testResultshoot <= 4 && testResultshoot > 0);

        }
        [TestMethod]
        public void TestMethod3()
        {
            RussianRoulette.GameClass testShootAway = new RussianRoulette.GameClass();

            int testResultShootAway = testShootAway.SpinLogic();

            Assert.IsTrue(testResultShootAway < 7 && testResultShootAway > 0);

        }
    }
}
