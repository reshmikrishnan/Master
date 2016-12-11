using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    public class RPNCalculator : IRPNCalculator
    {
        public float GetResults(string[] input)
        {
            Stack<float> stack = new Stack<float>();
            bool isAnyOperation = false;
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (IsValidOperator(input[i]))
                    {
                        isAnyOperation = true;                        
                        stack.Push(RPNFactory.GetOperator(input[i]).Calculate(stack));
                    }
                    else
                    {
                        float f1;
                        bool IsNumber = float.TryParse(input[i], out f1);
                        if (IsNumber)                            
                         stack.Push(f1);

                    }
                }
                if (!isAnyOperation  || stack.Count>1)
                    throw new InvalidOperationException();
            }
            catch (InvalidOperationException op)
            {
                throw op;
            }
            return stack.Pop();
        }
        private bool IsValidOperator(string op)
        {
            return RPNFactory.GetOperators().Contains(op);
        }
       
    }

}
