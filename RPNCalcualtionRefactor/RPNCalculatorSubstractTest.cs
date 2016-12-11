using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculatorRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalcualtionRefactor
{

    [TestClass]
    public class RPNCalculatorSubstractTest
    {
        IRPNCalculator _rpnCalc = new RPNCalculator();
        [TestMethod]
        public void SubstractionOperatorTest()
        {
            string[] input = { "2", "3", "-" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(-1, f);
        }

        [TestMethod]
        public void SubOperatorTestFor3()
        {
            string[] input = { "2", "3", "4", "-", "-" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(3, f);

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SubOperatorWithoutSecondNumber()
        {
            string[] input = { "2", "-" };
            float f = _rpnCalc.GetResults(input);
        }
        [TestMethod]
        public void Add_Sub_Operator()
        {
            string[] input = { "5", "3", "+", "4", "-" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(4, f);

        }
        [TestMethod]
        public void Add_Sub_Operator2()
        {
            string[] input = { "5", "3", "-", "4", "+" };
            float f = _rpnCalc.GetResults(input);
            NUnit.Framework.Assert.AreEqual(6, f);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Add_Sub_Operator_Operand_Missing()
        {
            string[] input = { "5", "3", "-", "4", "+", "+" };
            float f = _rpnCalc.GetResults(input);
        }
        
    }
}
