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
            return CalculateFactorial(input1);
        }

        private float CalculateFactorial(float input)
        {
            int number= (int)input;
            int sum = number;
            do
            {
                sum *= number - 1;
                number--;
            } while (number > 1);
                return sum;
        }
    }
}
