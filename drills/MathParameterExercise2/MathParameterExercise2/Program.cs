using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParameterExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overloading function MathClass\n");
            Console.WriteLine("MathClass accepts an integer, decimal or string\n");
            MathClass mathCall1 = new MathClass();
            int answer = mathCall1.EasyMath(12);
            Console.WriteLine("Math class passed an Integer (12 * 25)/ 7 = " + answer);
            Console.ReadLine();

            MathClass mathCall2 = new MathClass();
            answer = mathCall2.EasyMath(83.65m);
            Console.WriteLine("Math class passed a Decimal (83.65 + 1000)/ 25 = " + answer);
            Console.ReadLine();

            MathClass mathCall3 = new MathClass();
            answer = mathCall3.EasyMath("75");
            Console.WriteLine("Math class passed a String (75 + 25) = " + answer);         
            Console.ReadLine();
        }
    }
}
