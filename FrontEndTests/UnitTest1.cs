using System;
using FrontEnd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FrontEndTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_Add()
        {
            FrontEnd.FrontEnd frontEnd = new FrontEnd.FrontEnd();

            frontEnd.Add();
        }
    }
}
