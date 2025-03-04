using CalculatorLibraryV2.Formulas;
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
            var addition = Basic.Addition(addition, 1);
            Assert.Equals(addition, 2);
        }
        public void TestMethod2()
        {
            var subtraction = Basic.Subtraction(subtraction, 1);
            Assert.Equals(subtraction, 0);
        }
        public void TestMethod3()
        {
            var multiplication = Basic.Multiplication(multiplication, 1);
            Assert.Equals(multiplication, 1);
        }
        public void TestMethod4()
        {
            var division = Basic.Division(division, 1);
            Assert.Equals(division, 1);
        }
    }
}