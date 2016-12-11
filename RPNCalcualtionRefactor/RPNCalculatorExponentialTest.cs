using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculatorRefactor;

namespace RPNCalcualtionRefactor
{
    [TestClass]
    public class RPNCalculatorExponentialTest
    {
        IRPNCalculator _rpnCalc = new RPNCalculator();
        [TestMethod]
        public void OneOperand()
        {
            string[] input = { "4", "^" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(256, f);
        }

        [TestMethod]
        public void BigOperandWithUnaryAtEnd()
        {
            string[] input = { "5", "4", "-", "2", "+", "!","^" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(46656, f);
        }
    }
}
