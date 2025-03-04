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
    }
}
