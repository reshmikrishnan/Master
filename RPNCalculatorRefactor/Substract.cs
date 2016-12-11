using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    public class Substract : ICalculate
    {
        public float Calculate(Stack<float> stack)
        {
            float input2 = stack.Pop();
            float input1 = stack.Pop();
            return (input1 - input2);
        }
    }
}
