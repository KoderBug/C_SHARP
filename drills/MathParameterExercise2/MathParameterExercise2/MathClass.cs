using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParameterExercise2
{
    public class MathClass
    {

        public int EasyMath(int firstNumber)
        {
            int answer = (firstNumber * 25) / 7;
            return answer;
        }

        public int EasyMath(decimal firstNumber)
        {
            decimal answer = ((firstNumber + 1000)/25);    
            int answerInt = Convert.ToInt32(answer);
            return answerInt;
        }

        public int EasyMath(string firstNumber)
        {

            int answer = Convert.ToInt32(firstNumber) + 25;

            return answer;
        }
    }
}
