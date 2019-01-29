using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParametersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathCall = new MathClass();           
            mathCall.Equation(18, 25);
            mathCall.Equation(firstInt: 12, secondInt: 56);
            Console.ReadLine();
        }
    }
}
