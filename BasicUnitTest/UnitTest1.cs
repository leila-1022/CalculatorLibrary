using calculatorLibrary.formula;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Basic_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        private int subtraction;
        private int multiplication;
        private int division;

        [TestMethod]
        public void TestMethod1()
        {
            var addition = Basic.Addition(1, 1);
            Assert.AreEqual(2, addition);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var subtraction = Basic.Subtraction(1, 1);
            Assert.AreEqual(0, subtraction);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var multiplication = Basic.Multiplication(1, 1);
            Assert.AreEqual(1, multiplication);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var division = Basic.Division(1, 1);
            Assert.AreEqual(1, division);
        }
    }
}
