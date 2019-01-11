using System;
using Calculators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calculator = new Calculator(); 

        /* Unexpected changes
        [TestMethod]
        public void TestMethod1_Add()
        {
            Assert.IsTrue(7 == calculator.Add(3, 4));
        }
        */

        [TestMethod]
        public void TestMethod2_Multiply()
        {
            // Unexpected changes
            //Assert.IsTrue(12 == calculator.Multiply(3, 4));
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

        [TestMethod]
        public void TestMethod5_SquareRoot()
        {
            Assert.IsTrue(10 == calculator.SquareRoot(10));
        }
        
        [TestMethod]
        public void TestMethod6_Divide()
        {
            Assert.IsTrue(5 == calculator.Divide(10, 2));
            try
            {
                calculator.Divide(10, 0);
                Assert.Fail("No exception thrown");
            }
            catch(Exception ex)
            {
                Assert.AreEqual("denominator is zero", ex.Message);
            }
        }
    }
}
