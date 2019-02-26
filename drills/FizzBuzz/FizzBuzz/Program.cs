using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Print numbers 1 to 100.  When a number is a multiple of
 * three, print "Fizz" instead of a number on the console  
 * and if multiple of five then print "Buzz" on the console.  
 * For numbers which are multiples of three as well as five, 
 * print "FizzBuzz" on the console.    */

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            { 
                if  ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine("FizzBuzz");
                else if (i%3 == 0 )
                    Console.WriteLine("Fizz");
                    else if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                        else
                            Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
