using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculatorRefactor;

namespace RPNCalcualtionRefactor
{
    [TestClass]
    public class RPNCalculateMutiply
    {
        IRPNCalculator _rpnCalc = new RPNCalculator();
        [TestMethod]
        public void Multiply()
        {
            string[] input = { "5", "3", "*" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(15, f);
        }

        [TestMethod]

        public void Multiply_Boundry()
        {
            float r = float.MaxValue * float.MaxValue;
            string[] input = { float.MaxValue.ToString(), float.MaxValue.ToString(), "*" };            
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(r, f);
        }
        [TestMethod]
        public void Add_Sub_Mul()
        {
            string[] input = { "5", "3", "4", "+", "2", "-", "3", "*", "4", "+", "+" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(24, f);
        }
    }
}
