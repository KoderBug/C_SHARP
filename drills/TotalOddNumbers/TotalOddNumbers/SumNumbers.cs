using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalOddNumbers
{
    class SumNumbers
    {
        public int SumOddNumbers(int[] numberList)
        {
            int total = 0;
            foreach (int i in numberList)
            {
                if (i % 2 != 0)
                {
                    total = total + i;
                }
            }            
            return total;
        }

        public void printArray(int[] numberList)
        {
            Console.Write("Numbers in the array: ");

            for(int i=0;i<numberList.Length;i++)
            {
                if (i == numberList.Length-1)
                    Console.WriteLine(numberList[i] + "\n");
                else
                    Console.Write(numberList[i] + ", " );          
            }            
        }
    }
}
