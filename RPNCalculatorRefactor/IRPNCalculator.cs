using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculatorRefactor
{
    public interface IRPNCalculator
    {
        float GetResults(string [] input);
    }
}
