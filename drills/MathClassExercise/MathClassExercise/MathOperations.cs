using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassExercise
{
    class MathOperations
    {

        public int Squared(int numberOne)
        {
            int squaredNumber = numberOne * numberOne;
            return squaredNumber;
        }

        public int Halved(int numberOne)
        {
            int halvedNumber = numberOne / 2;
            return halvedNumber;
        }

        public int Hundreds(int numberOne)
        {
            int timesHundreds = numberOne * 100;
            return timesHundreds;
        }
    }
}
