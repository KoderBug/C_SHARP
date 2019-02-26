using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Assignment: Given a string, reverse it.
 
namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string s = Console.ReadLine();             
            int sLength = s.Length;
            char[] sArray;
            sArray = s.ToCharArray(0,sLength);
            Array.Reverse(sArray);

            Console.WriteLine("\nString reversed ");
            foreach (char x in sArray)
            {
                Console.Write(x);                                
            }         
            
            Console.ReadLine();
        }
    }
}
