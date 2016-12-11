using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    public class Exponential : ICalculate
    {
        public float Calculate(Stack<float> stack)
        {
            float input1 = stack.Pop();
            return (float)Math.Pow(input1,input1);

        }
    }
}
