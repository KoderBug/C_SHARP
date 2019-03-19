using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Demonstration of passing by VALUE TYPE vs passing by REFERENCE TYPE.
 * 
 * PassByValue method accepts a value type variable and tries to change the value of that variable.
 * It then prints the value of the variable.
 * 
 * PassByReference method accepts an array (reference type) and tries to change the value of the first element in the array.  
 * It then prints the value of that element.
 * 
 * Demonstrates when you pass in a value type variable, any change made to the value of that variable is only valid within the method iteself.
 * Once the program exits the method, the change is no longer valid.
 * On the other hand, if you pass in a reference type variable, any change made to the variable is valid even after the method ends.
 */

namespace PassingTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int[] b = { 1, 2, 3 };
            MethodDemo obj = new MethodDemo();

            Console.WriteLine("a before = {0}", a);
            obj.PassByValue(a);
            Console.WriteLine("a after = {0}", a);

            Console.WriteLine("\n\n");

            Console.WriteLine("b[0] before = {0}", b[0]);
            obj.PassByReference(b);
            Console.WriteLine("b[0] after = {0}", b[0]);

            Console.ReadLine();

        }       
    }
}
