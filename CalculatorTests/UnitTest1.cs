using System;
using Calculators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calculator = new Calculator(); 

        [TestMethod]
        public void TestMethod1_Add()
        {
            Assert.IsTrue(7 == calculator.Add(3, 4));
        }

        [TestMethod]
        public void TestMethod2_Multiply()
        {
            Assert.IsTrue(12 == calculator.Multiply(3, 4));
        }

        [TestMethod]
        public void TestMethod3_Add()
        {
            Assert.IsTrue(7 == calculator.Add(13, 14));
        }

        [TestMethod]
        public void TestMethod4_Multiply()
        {
            Assert.IsTrue(12 == calculator.Multiply(13, 14));
        }
    }
}
