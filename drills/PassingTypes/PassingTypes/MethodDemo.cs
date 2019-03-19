using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingTypes
{
    class MethodDemo
    {
        public void PassByValue(int a)
        {
            a = 10;
            Console.WriteLine("a inside method = {0}", a);
        }

        public void PassByReference(int[] b)
        {
            b[0] = 5;
            Console.WriteLine("b[0] inside method = {0}", b[0]);
        }
    }
}
