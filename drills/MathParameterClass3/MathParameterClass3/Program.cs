using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParameterClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathClass = new MathClass();
            Console.WriteLine("Please enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number or enter to skip: ");
            string secondNumber = Console.ReadLine();

            bool n2 = string.IsNullOrEmpty(secondNumber);
            int rootAnswer = 0;
            if (!n2)
            { 
                int Number2 = Convert.ToInt32(secondNumber);
                rootAnswer = mathClass.Rooted(firstNumber, Number2);
            } else
            {
                rootAnswer = mathClass.Rooted(firstNumber);
            }

            Console.WriteLine("The square root of " + firstNumber.ToString() + " rounded and multiplied by " 
                                + secondNumber + " equals " + rootAnswer);
            
            Console.ReadLine();
        }
    }
}
