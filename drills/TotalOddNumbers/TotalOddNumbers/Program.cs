using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Assignment: Given an array of integers, 
    write a method to total the odd numbers  */

namespace TotalOddNumbers
{
    class Program
    {
        static void Main()
        {
            
            int[] numberList = { 34, 55, 89, 24, 21, 94 };
            SumNumbers sumNumbers = new SumNumbers();
            sumNumbers.printArray(numberList);
            int total = sumNumbers.SumOddNumbers(numberList);

            Console.WriteLine("The total of the odd numbers in the array is " + total);
            Console.ReadLine();
        }
    }
}
