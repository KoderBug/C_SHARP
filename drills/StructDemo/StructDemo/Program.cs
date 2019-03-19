using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct example = new MyStruct(2, 3, 5);
            example.PrintStatement();
            Console.Read();
        }
    }
}
