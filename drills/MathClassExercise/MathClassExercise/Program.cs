using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {          
            MathOperations mathOperator = new MathOperations();

            Console.WriteLine("Enter a number for math operations: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            int squaredNumber = mathOperator.Squared(numberOne);
            Console.WriteLine("Squared method: " + squaredNumber);

            int halvedNumber = mathOperator.Halved(numberOne);
            Console.WriteLine("Halved method: " +  halvedNumber);

            int hundredsNumber = mathOperator.Hundreds(numberOne);
            Console.WriteLine("Hundreds method: " + hundredsNumber);
            Console.ReadLine();

        }
    }
}
