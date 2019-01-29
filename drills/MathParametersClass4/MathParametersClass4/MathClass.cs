using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParametersClass4
{
    class MathClass
    {
        public void Halved(int inputNumber, out int quoteInt)
        {
            quoteInt = inputNumber / 2;
        }

        public void Powered(double inputNumber, out double productRet)
        {           
            productRet = Math.Pow(inputNumber, 3);
        }

        public void Powered(double inputNumber, double exp, out double productRet)
        {
            productRet = Math.Pow(inputNumber, exp);
        }
    }
}
