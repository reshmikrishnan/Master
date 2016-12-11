using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    public interface ICalculate
    {
        float Calculate(Stack<float> stk);
    }

}
