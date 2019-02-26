using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assignment: Given a string, remove any repeated letters.

namespace StringNoRepeats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string s = Console.ReadLine();          
            char[] sArray = s.Distinct().ToArray();
           
            Console.WriteLine("\nRepeated letters have been removed from the string entered \n");
            foreach (char item in sArray)
            {
                Console.Write(item);
            }
            Console.ReadLine();           
        }
    }
}
