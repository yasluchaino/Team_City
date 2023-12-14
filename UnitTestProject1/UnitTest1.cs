using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Factorial;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFactorialOf7()
        {
            Fact f = new Fact();
            int result = f.Factorial(7);
            Assert.AreEqual(5040, result);
        }

        [TestMethod]
        public void TestFactorialOf8()
        {
            Fact f = new Fact();
            int result = f.Factorial(8);
            Assert.AreEqual(40320, result);
        }
        [TestMethod]
        public void TestFactorialOf0()
        {
            Fact f = new Fact();
            int result = f.Factorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestFactorialOf1()
        {
            Fact f = new Fact();
            int result = f.Factorial(1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestFactorialOf5()
        {
            Fact f = new Fact();
            int result = f.Factorial(5);
            Assert.AreEqual(120, result);
        }
    }
}
