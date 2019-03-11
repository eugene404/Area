using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calc.unitTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var inst = new Program();
            inst.myCalculate(4, 6);
           
        }
    }
}
