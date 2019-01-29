using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParameterClass3
{
    class MathClass
    {
        public int Rooted(int firstInt, int secondInt = 1)
        {            
            double answer = Math.Round(Math.Sqrt(Convert.ToDouble(firstInt))) * Convert.ToDouble(secondInt);
            int answerInt = Convert.ToInt32(answer);
            return answerInt;
        }
    }
}
