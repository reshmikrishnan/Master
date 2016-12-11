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
            string[] input = { "3", "!" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(6, f);
        }

        
        [TestMethod]
        public void BigOperand()
        {
            string[] input = { "6", "!" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(720, f);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoOperand()
        {
            string[] input = { "6" };
            float f = _rpnCalc.GetResults(input);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MixOfOperandsOperand()
        {
            string[] input = { "5", "4","3","!","+","2","-" };
            float f = _rpnCalc.GetResults(input);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MixOfOperandsOperand2()
        {
            string[] input = { "5", "4", "3", "!", "+", "2", "-","!" };
            float f = _rpnCalc.GetResults(input);
        }

        [TestMethod]
        public void BigOperandWithUnaryAtEnd()
        {
            string[] input = { "5", "4", "-","3","+", "!" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(24, f);
        }



    }
}
