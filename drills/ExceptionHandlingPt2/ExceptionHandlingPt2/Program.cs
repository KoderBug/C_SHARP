using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPt2
{
    class Program
    {
        static void Main(string[] args)
        {
           bool validAnswer = false;
            int age = 0;
            try
            {
                 Console.WriteLine("Please enter your age: ");
                validAnswer = int.TryParse(Console.ReadLine(), out age);

                if (!validAnswer)
                {
                    throw new InvalidAgeException();
                 }  else    if ( age  <=  0)  { 
                    Console.WriteLine("Age cannot be zero or less.");
                    Console.ReadLine();
                }
                else if  (age  > 0)  {
                    Console.WriteLine("You are " +  age + " years old.");
                    Console.ReadLine();
                }  else   {
                    throw new InvalidAgeException();
                }
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("Age must be an integer only.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred.  Please contact your System Administrator.");
                Console.ReadLine();
                return;
            }

        }
    }
}
