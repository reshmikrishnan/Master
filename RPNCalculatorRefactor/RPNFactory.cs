using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    public class RPNFactory
    {
        static Dictionary<string, ICalculate> op = new Dictionary<string, ICalculate>();
        static RPNFactory()
        {
            op.Add("+", new Add());
            op.Add("-", new Substract());
            op.Add("*", new Multipy());
            op.Add("!", new Factorial());
            op.Add("^", new Exponential());
        }

        public static ICalculate GetOperator(string operators)
        {

            return op[operators];

        }
        public static string[] GetOperators()
        {
            return op.Keys.ToArray<string>(); ;
        }


    }


}
