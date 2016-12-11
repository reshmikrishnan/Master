using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    public class Factorial : ICalculate
    {
        public float Calculate(Stack<float> stack)
        {
            float input1 = stack.Pop();
            return 2;
        }

        private float CalculateFactorial(float input)
        {
            float number;
            number = input;
            
            
            for (int i = input - 1; i >= 1; i--)

            {

                fact = fact * i;

            }

            return 
        }
    }
}
