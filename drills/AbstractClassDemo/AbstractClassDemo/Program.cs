using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// If you uncomment the instantiation of MyAbstractClass you will get an error
//  since an abstract class cannot be instantiated.

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyAbstractClass abClass = new MyAbstractClass();
            ClassA a = new ClassA();
            a.PrintMessage();
            a.PrintMessageAbstract();
            Console.Read();
        }
    }
}
