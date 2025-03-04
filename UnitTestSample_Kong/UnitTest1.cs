using CalculatorLibrary.Formulas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSample_Kong
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var addition = Basic.Addition(1, 1);
            Assert.AreEqual(addition, 2);

        }

        [TestMethod]
        public void TestMethod2()
        {
            var subtraction = Basic.Subtraction(2, 1);
            Assert.AreEqual(subtraction, 1);

        }

        [TestMethod]
        public void TestMethod3()
        {
            var multiplication = Basic.Multiplication(1, 1);
            Assert.AreEqual(multiplication, 1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var division = Basic.Division(1, 1);
            Assert.AreEqual(division, 1);
        }
    }
}