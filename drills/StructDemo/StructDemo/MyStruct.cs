using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* The two fields (myClass and myDays) are specially included in this example to demonstrate 
 * how we can include a class instance and an enum variable as the fields of a struct.
 * Structs (and classes) can contain enum variables and instances of other structs and classes as fields.
 * In this example, we declared the class and enum outside the struct myStruct.  
 * However, it is possible for us to declare the enum or class inside the struct itself.
 * An enum, struct or class can be nested inside another struct or class.
 */

namespace StructDemo
{
    struct MyStruct
    {
        private int x, y;
        private AnotherClass myClass;
        private Days myDays;

        //Constructor
        public MyStruct(int a, int b, int c)
        {
            myClass = new AnotherClass();
            myClass.number = a;
            x = b;
            y = c;
            myDays = Days.Mon;
        }

        //Method
        public void PrintStatement()
        {
            Console.WriteLine("x = {0}, y = {1}, myDays = {2}", x, y, myDays);
        }
    }
}
