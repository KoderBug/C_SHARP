using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathParametersClass4
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathClass = new MathClass();
            Console.WriteLine("Please enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int quoteInt = 0;
            mathClass.Halved(inputNumber, out quoteInt);
            Console.WriteLine("Halved " + quoteInt);
            Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            double input2 = Convert.ToDouble(Console.ReadLine());           
            double productRet = 0;
            mathClass.Powered(input2, out productRet);
            Console.WriteLine(input2 + " to the 3rd power equals " + productRet);
            Console.ReadLine();

            Console.WriteLine("Please enter a number: ");
            input2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter an exponent: ");
            double exp = Convert.ToDouble(Console.ReadLine());
            mathClass.Powered(input2, exp, out productRet);
            Console.WriteLine(input2 + " to the power of " + exp + " equals " + productRet);
            Console.ReadLine();

            Console.WriteLine("Please enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            int volume = RectPrismVol(length, width, height);
            Console.WriteLine("Volume of the Rectangular Prism is: " + volume);
            Console.ReadLine();
        }

        public static int RectPrismVol(int length, int width, int height)
        {
            int volume = length * width * height;
            return volume;
        }
    }
}
