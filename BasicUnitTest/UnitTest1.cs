using CalculatorLibrary.Formulas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicUnitTest
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
            var subtraction = Basic.Subtraction(3, 2);
            Assert.AreEqual(subtraction, 1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var multiplication = Basic.Multiplication(3, 2);
            Assert.AreEqual(multiplication, 6);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var division = Basic.Division(4, 2);
            Assert.AreEqual(division, 2);
        }
    }
}