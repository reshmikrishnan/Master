using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculatorRefactor;
using NUnit.Framework;

namespace RPNCalcualtionRefactor
{
    #region AddTest
    [TestClass]
    public class RPNCalculatorAddTest
    {
        IRPNCalculator _rpnCalc = new RPNCalculator();
        [TestMethod]
        public void AddOperatorTestFor2()
        {
            string[] input = { "2", "3", "+" };            
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(5, f);
        }

        [TestMethod]
        public void AddOperatorTestFor3()
        {
            string[] input = { "2", "3", "4", "+", "+" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(9, f);

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddOperatorTestForWithoutSecondNumber()
        {

            string[] input = { "2", "+" };

            float f = _rpnCalc.GetResults(input);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddOperatorTestForWithoutOperand()
        {

            string[] input = { "2", "3", "+", "+" };
            float f = _rpnCalc.GetResults(input);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PassInvalidOperands()
        {
            string[] input = { "c", "3", "+" };
            float f = _rpnCalc.GetResults(input);
        }
        #endregion
    }
}
