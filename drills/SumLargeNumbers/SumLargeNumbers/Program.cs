using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLargeNumbers
{
    /* Assignment: Given an array of integers, write a method to sum the elements in the array,
       knowing that some of the elements may be very large integers.*/

    class Program
    {
        static void Main(string[] args)
        {

            double[] largeNumbers = {5949504345,
            3249483928, 435678387238};
            
            double result = SumNumbers(largeNumbers);
            PrintArray(largeNumbers);
            String s = String.Format("{0:N0}", result);
            Console.Write(s);
            Console.ReadLine();
        }

        static double SumNumbers(double[] numberArray)
        {
            double total = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                total = total + numberArray[i];
            }
            return total;
        }

        static void PrintArray(double[] numberArray)
        {
            Console.WriteLine("Adding numbers in an array");
            for (int i = 0; i < numberArray.Length; i++)
            {
                String addends;
                if (i == numberArray.Length - 1)
                    addends = String.Format("{0:N0} = ", numberArray[i]);
                else
                    addends = String.Format("{0:N0} + ", numberArray[i]);
                Console.Write(addends);

            }
        }
    }
}

