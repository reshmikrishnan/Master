using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using RPNCalculatorRefactor;

namespace RPNCalcualtionRefactor
{
    [TestClass]
    public class RPNCalculateFactorialTest
    {
        IRPNCalculator _rpnCalc = new RPNCalculator();
        [TestMethod]
        public void OneOperand()
        {
            string[] input = { "2", "!" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(2, f);
        }
    }
}
