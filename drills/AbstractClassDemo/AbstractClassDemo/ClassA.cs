using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class ClassA : MyAbstractClass
    {
        public override void PrintMessageAbstract()
        {
            Console.WriteLine("C# is fun!");
        }
    }
}
